using System;
using System.IO;
using System.Windows.Forms;


namespace I2cDriver2
{
    public class Eeprom
    {
        static Byte[] FileBuffer = new Byte[0x10000];
        public static bool MemRdRunning = false;
        public static bool MemWrRunning = false;
        public static int Addr;
        public static int Length;
        static int EndAddr;
        public static byte PageSize;
        public static bool TwoByteAddr = false;
        public static byte DeviceAddr;
        public static string FileName;
        static int FileBufferIndex;

        public static void SetEepromParam(int add, int len, 
                                          byte page, byte dev,
                                          bool twobyte)
        { 
            Addr = add;
            Length = len;
            PageSize = page;
            DeviceAddr = dev;
            TwoByteAddr = twobyte;
            EndAddr = Addr + Length - 1;

            FileBufferIndex = 0;

            if(MemWrRunning == true)
            {
                FileStream fs = new FileStream(FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                for (FileBufferIndex = 0; FileBufferIndex < Length; FileBufferIndex++)
                {
                    FileBuffer[FileBufferIndex] = br.ReadByte();
                }
                br.Close();
                fs.Close();

                FileBufferIndex = 0;
            }
        }

        public static bool Write()
        {
            bool Ack;
            byte CurrentDevAddr = DeviceAddr;

            // convert Addr to string "ll hh"
            byte AddrLow = (byte)Addr;
            byte AddrHigh = (byte)(Addr >> 8);
            string MemAddr = "";

            if (TwoByteAddr == true)
            {
                MemAddr += Convert.ToString((AddrHigh & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString((AddrHigh & 0x0f), 16) + " ";
                MemAddr += Convert.ToString((AddrLow & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString(AddrLow & 0x0f, 16);
            }
            else
            {
                MemAddr += Convert.ToString((AddrLow & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString(AddrLow & 0x0f, 16);
                CurrentDevAddr |= (byte)(AddrHigh << 1);
            }

            // Set address
            string TxBytes = MemAddr + " ";
            // Convert FileBuffer to string 
            int i;

            for (i = FileBufferIndex; i < FileBufferIndex + PageSize-1; i++)
            {
                TxBytes += Convert.ToString((FileBuffer[i] & 0xf0) >> 4, 16);
                TxBytes += Convert.ToString(FileBuffer[i] & 0x0f, 16) + " ";
            }

            TxBytes += Convert.ToString((FileBuffer[i] & 0xf0) >> 4, 16);
            TxBytes += Convert.ToString(FileBuffer[i] & 0x0f, 16);

            FileBufferIndex = i + 1;

            Ack = I2c.WriteBytes(CurrentDevAddr, TxBytes);
            I2c.StopCond();
            if (Ack == false)
            {
                MemWrRunning = false;
                return false;
            }
            else
            {
                Addr += PageSize;
                // check if finish
                if (Addr > EndAddr)
                {
                    MemWrRunning = false;
                }
                return true;
            }      
        }

//--------------Eeprom Read ---------------------------------------------------

        public static bool Read()
        {
            bool Ack;
            byte CurrentDevAddr = DeviceAddr;

            // convert Addr to string "ll hh"
            byte AddrLow = (byte)Addr;
            byte AddrHigh = (byte)(Addr >> 8);
            string MemAddr = "";
            string Log = "";

            if (TwoByteAddr == true)
            {
                MemAddr += " " + Convert.ToString((AddrHigh & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString((AddrHigh & 0x0f), 16) + " ";
                MemAddr += Convert.ToString((AddrLow & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString(AddrLow & 0x0f, 16);
            }
            else
            {
                MemAddr += Convert.ToString((AddrLow & 0xf0) >> 4, 16);
                MemAddr += Convert.ToString(AddrLow & 0x0f, 16);
                CurrentDevAddr |= (byte)(AddrHigh << 1);
            }

            // Set address
            Ack = I2c.WriteBytes(CurrentDevAddr, MemAddr);

            if (Ack == false)
            {
                MemRdRunning = false;
                I2c.StopCond();
                return false;
            }
            else
            {   // Read page, no I2c.StopCond() -> repeated Start
                Ack = I2c.ReadBytes(CurrentDevAddr, PageSize);
                if (Ack == false)
                {
                    MemRdRunning = false;
                }
                else
                {
                    if (I2c.LogOn == true)
                    {
                        I2c.fs = new FileStream("I2cDriver2.log", FileMode.Append);
                        I2c.sw = new StreamWriter(I2c.fs);
                        Log = "Rd: " + Convert.ToString(PageSize) + " bytes ";
                        if (Ack == true)
                            Log += "ACK";
                        else
                            Log += "NACK";
                        I2c.sw.WriteLine(Log);
                        I2c.LogCounter++;
                        I2c.sw.Close();
                        I2c.fs.Close();
                    }
                }
                I2c.StopCond();
            }

            Addr += PageSize;

            // fill file buffer
            int i;
            for (i = 0; i < PageSize; i++)
            {
                FileBuffer[FileBufferIndex] = I2c.bRdBuffer[i];
                FileBufferIndex++;
            }

            // check if finish
            if (Addr > EndAddr)
            {
                MemRdRunning = false;
                FileStream fs = new FileStream(FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                for (i = 0; i < Length; i++)
                {
                    bw.Write(FileBuffer[i]);
                }

                bw.Close();
                fs.Close();
            }
            return Ack;
        }

    }

}
