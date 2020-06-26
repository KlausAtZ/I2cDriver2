using System;
using System.Threading;
using System.IO;

namespace I2cDriver2
{
    public class I2c
    {
        public static int bytesRead;
        public static Byte[] bRdBuffer = new Byte[0x400];
        public static Byte[] bWrBuffer = new Byte[0x400];
        public static bool LogOn;
        public static UInt32 LogCounter;
        public static FileStream fs;
        public static StreamWriter sw;

        public static bool StartCond(byte SlaveAddr)
        {
            byte[] Ack = new byte[1];
            bool ack;
            string Log = "";
            bWrBuffer[0] = (byte)'s';
            bWrBuffer[1] = SlaveAddr;
            Ack[0] = 0xff;
            ComPort._serialPort.DiscardInBuffer();
            ComPort._serialPort.Write(bWrBuffer, 0, 2);
            ComPort._serialPort.Read(Ack, 0, 1);
            if (Ack[0] != 0x31)  // ASCII 1 (0x31) or 0 (0x30)
                ack = false;
            else
                ack = true;
            if (LogOn == true)
            {
                fs = new FileStream("I2cDriver2.log", FileMode.Append);
                sw = new StreamWriter(fs);
                Log = "S " + Convert.ToString(SlaveAddr, 16) + " ";
                if (ack == true)
                    Log += "ACK";
                else
                    Log += "NACK";
                sw.WriteLine(Log);
                LogCounter++;
                sw.Close();
                fs.Close();
            }
            return ack;
        }

        public static void StopCond()
        {
            bWrBuffer[0] = (byte)'p';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
            if (LogOn == true)
            {
                fs = new FileStream("I2cDriver2.log", FileMode.Append);
                sw = new StreamWriter(fs);
                sw.WriteLine("P");
                LogCounter++;
                sw.Close();
                fs.Close();
            }
        }


        // start cond. + slave addr (wr) + write bytes (bTxCnt), no stop cond.
        public static bool WriteBytes(byte Addr, String TxbTxData)
        {
            byte[] Ack = new byte[1];
            byte I, K;
            Byte bTxCnt;
            Byte bTxCnt1;
            bool ack;
            string Log = "";

            if (TxbTxData == "")
                return true;

            Ack[0] = 0xff;
            ComPort._serialPort.DiscardInBuffer();

            ack = I2c.StartCond(Addr);
            if(ack == true)
            {
                bTxCnt1 = (Byte)TxbTxData.Length;
                bTxCnt = 0;
                K = 1;

                for (I = 0; I < bTxCnt1; I++)
                {
                    if (TxbTxData[I] != ' ')
                    {
                        bTxCnt++;
                        if ((Byte)TxbTxData[I] < 0x3a)
                        {
                            I2c.bWrBuffer[K] = (Byte)((TxbTxData[I++] - 0x30) * 16);
                            if ((Byte)TxbTxData[I] < 0x3a)
                                I2c.bWrBuffer[K++] += (Byte)(TxbTxData[I] - 0x30);
                            else
                                I2c.bWrBuffer[K++] += (Byte)(TxbTxData[I] - 0x57);
                        }
                        else
                        {
                            I2c.bWrBuffer[K] = (Byte)((TxbTxData[I++] - 0x57) * 16);
                            if ((Byte)TxbTxData[I] < 0x3a)
                                I2c.bWrBuffer[K++] += (Byte)(TxbTxData[I] - 0x30);
                            else
                                I2c.bWrBuffer[K++] += (Byte)(TxbTxData[I] - 0x57);
                        }
                    }
                }

                bWrBuffer[0] = (byte)(0xc0 + bTxCnt - 1);
                ComPort._serialPort.Write(bWrBuffer, 0, bTxCnt + 1);
                ComPort._serialPort.Read(Ack, 0, 1);
                if (Ack[0] == 0x31) // "1" bei Ack, "0" bei Nack
                    ack = true;
                else
                    ack = false;
            }
            if (LogOn == true)
            {
                fs = new FileStream("I2cDriver2.log", FileMode.Append);
                sw = new StreamWriter(fs);
                Log = "Wr: " + TxbTxData + " ";
                if (ack == true)
                    Log += "ACK";
                else
                    Log += "NACK";
                sw.WriteLine(Log);
                LogCounter++;
                sw.Close();
                fs.Close();
            }
            return ack;
        }

        // start cond. + slave addr (rd) + read bytes (Cnt), no stop cond.
        public static bool ReadBytes(byte Addr, byte Cnt)
        {
            int BytesRead = 0, i;

            if (I2c.StartCond((byte)(Addr + 1)) == true)
            {
                bWrBuffer[0] = (byte)(0x80 + Cnt - 1);
                ComPort._serialPort.DiscardInBuffer();
                ComPort._serialPort.Write(bWrBuffer, 0, 1);
                for (i = 0; i < 10; i++)
                {
                    BytesRead += ComPort._serialPort.Read(bRdBuffer, BytesRead, Cnt);
                    if (BytesRead == Cnt)
                        break;
                }
                if (i == 10)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
     
        //---------------------------------------------------------------------------

        public static void GetStatus()
        {
            int i;
            bytesRead = 0;
            bRdBuffer[0] = 0;
            bRdBuffer[79] = 0;

            bWrBuffer[0] = (byte)'?';

            for (i = 0; i < 10; i++)
            {
                ComPort._serialPort.DiscardInBuffer();
                ComPort._serialPort.Write(bWrBuffer, 0, 1);
                Thread.Sleep(50);
                bytesRead = ComPort._serialPort.Read(bRdBuffer, 0, 80);
                if ((bytesRead == 80) &&
                    (bRdBuffer[0] == 0x5b) &&
                    (bRdBuffer[79] == 0x5d))
                    break;
                Thread.Sleep(50);
            }
            if (i == 10)
                bRdBuffer[0] = 0;       // failed
        }

        public static void I2cReset()
        {
            bytesRead = 0;
            bWrBuffer[0] = (byte)'x';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
            //Thread.Sleep(5);
            bytesRead = ComPort._serialPort.Read(bRdBuffer, 0, 1);
            if ((bytesRead != 1) || (bRdBuffer[0] != (byte)'3'))
                bRdBuffer[0] = 0;       // failed
        }


        public static void I2cSetSpeed(byte speed)
        {
            bytesRead = 0;
            bWrBuffer[0] = speed;
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
        }

        public static void I2cSetPullupR(byte pullUpR)
        {
            bytesRead = 0;
            bWrBuffer[0] = (byte)'u';
            bWrBuffer[1] = pullUpR;
            ComPort._serialPort.Write(I2c.bWrBuffer, 0, 2);
        }

        public static void SetMonitorMode()
        {
            bWrBuffer[0] = (byte)'m';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
        }

        public static void SetCaptureMode()
        {
            bWrBuffer[0] = (byte)'c';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
        }

        public static void SetMasterMode()
        {
            bWrBuffer[0] = (byte)' ';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
        }

        public static void ModuleReboot()
        {
            bWrBuffer[0] = (byte)'_';
            ComPort._serialPort.Write(bWrBuffer, 0, 1);
        }
    }
}
