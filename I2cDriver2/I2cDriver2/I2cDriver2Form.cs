using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace I2cDriver2
{

    public partial class I2cDriver2Form : Form
    {
        UInt32 TxRepeatCounter;        
        Boolean StopOnError;
        UInt32 uiNAKCnt = 0;
        string RegReq;
        byte bFi;

        public static string[] AvailablePorts;

        public static FileStream Capfs;
        public static BinaryWriter Capbw;
        public static BinaryReader Capbr;
        public static Byte[] bCapRdBuffer = new Byte[0x400];

        public static bool CaptureRunning = false;

        public I2cDriver2Form()     // Constructor
        {
            InitializeComponent();
            PortNames();
            RegReq = "c0";
        }

        private void StatusResult()
        {
            if (I2c.bRdBuffer[0] == 0)
            {
                tbxMstVoltage.Text = "";
                tbxSerialNmb.Text = "";
                tbxSlvCurrent.Text = "";
                tbxMstTemp.Text = "";
                cbxI2cSpeed.Text = "";
                tbxSDALevel.Text = "";
                tbxSCLLevel.Text = "";
                cbxPullUpR.Text = "";
            }
            else
            {
                string Text = "";
                for (int i = 31; i < 36; i++)
                {
                    Text += (char)I2c.bRdBuffer[i];
                }
                tbxMstVoltage.Text = Text;

                Text = "";
                for (int i = 12; i < 20; i++)
                {
                    Text += (char)I2c.bRdBuffer[i];
                }
                tbxSerialNmb.Text = Text;

                Text = "";
                for (int i = 37; i < 40; i++)
                {
                    Text += (char)I2c.bRdBuffer[i];
                }
                tbxSlvCurrent.Text = Text;

                Text = "";
                for (int i = 41; i < 45; i++)
                {
                    Text += (char)I2c.bRdBuffer[i];
                }
                tbxMstTemp.Text = Text;

                Text = "";
                for (int i = 52; i < 55; i++)
                {
                    Text += (char)I2c.bRdBuffer[i];
                }
                cbxI2cSpeed.Text = Text;

                Text = "";
                Text += (char)I2c.bRdBuffer[48];
                tbxSDALevel.Text = Text;

                Text = "";
                Text += (char)I2c.bRdBuffer[50];
                tbxSCLLevel.Text = Text;

                Text = "";
                Text += (char)I2c.bRdBuffer[56];
                Text += (char)I2c.bRdBuffer[57];
                if (Text == "24")
                    cbxPullUpR.Text = "4.7";
                if (Text == "12")
                    cbxPullUpR.Text = "4.3";
                if (Text == "09")
                    cbxPullUpR.Text = "2.2";
                if (Text == "1b")
                    cbxPullUpR.Text = "1.5";
                if (Text == "3f")
                    cbxPullUpR.Text = "1.1";
                if (Text == "00")
                    cbxPullUpR.Text = "disabled";
            }
        }


        private void btnStartLog_Click(object sender, EventArgs e)
        {
            I2c.fs = new FileStream("I2cDriver2.log", FileMode.Create);
            I2c.sw = new StreamWriter(I2c.fs);
            I2c.sw.WriteLine(Convert.ToString(DateTime.Now));
            I2c.sw.WriteLine(" ");
            I2c.sw.Close();
            I2c.fs.Close();

            I2c.LogOn = true;
            I2c.LogCounter = 0;
            btnStartLog.Enabled = false;
            btnStopLog.Enabled = true;
        }

        private void btnStopLog_Click(object sender, EventArgs e)
        {
            I2c.LogOn = false;
            btnStopLog.Enabled = false;
            btnStartLog.Enabled = true;
        }

        private void btnI2cTx_Click(object sender, EventArgs e)
        {
            bool Ack;

            Ack = I2c.WriteBytes(Convert.ToByte(tbxAddr.Text, 16),
                                 tbxI2cTx.Text);

            if (cbxRepeatedStart.Checked == false)
                I2c.StopCond();

            if (Ack == false)
            {
                uiNAKCnt = Convert.ToUInt16(tbxNAKCnt.Text);
                uiNAKCnt++;
                tbxNAKCnt.Text = Convert.ToString(uiNAKCnt);
            }

            TxRepeatCounter = 0;
            tmPolling.Interval = Convert.ToUInt16(tbxRepeatDelay.Text);
            tmPolling.Start();
        }

        private void btnI2cRx_Click(object sender, EventArgs e)
        {
            if ((tbxRxCount.Text != "") || (tbxRxCount.Text != "0"))
            {                   // something to read
                ReadAndLog(Convert.ToByte(tbxRxCount.Text, 10));

                I2c.StopCond();
            }

            TxRepeatCounter = 0;
            tmPolling.Interval = Convert.ToUInt16(tbxRepeatDelay.Text);
            tmPolling.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            uiNAKCnt = 0;
            TxRepeatCounter = 0;
            tbxRepeatCounter.Text = Convert.ToString(TxRepeatCounter);
            ClearRxBuffer(Convert.ToByte(tbxRxCount.Text, 10));
            tbxI2cRx.Text = "";
            tbxNAKCnt.Text = "";
        }


        private void cbxStopOnError_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxStopOnError.Checked == true)
                StopOnError = true;
            else
                StopOnError = false;
        }

        private void btnCommOpen_Click(object sender, EventArgs e)
        {
            if (btnCommOpen.Text == "Close")
            {
                ComPort.ComPortClose();
                btnGetStatus.Enabled = false;
                btnI2cReset.Enabled = false;
                btnSetPullUpR.Enabled = false;
                btnSetSpeed.Enabled = false;
                btnI2cTx.Enabled = false;

                tbxCommParam.Text = "";
                tbxMstVoltage.Text = "";
                tbxSerialNmb.Text = "";
                tbxSlvCurrent.Text = "";
                tbxMstTemp.Text = "";
                cbxI2cSpeed.Text = "";
                tbxSDALevel.Text = "";
                tbxSCLLevel.Text = "";
                cbxPullUpR.Text = "";

                btnCommOpen.Text = "Open";
            }
            else
            { 
                if (cbxCommPort.Text == "")
                {
                    PortNames();
                    return;
                }

                ComPort.ComPortOpen(cbxCommPort.Text);

                I2c.GetStatus();

                if (I2c.bRdBuffer[0] == 0)
                {
                    ComPort.ComPortClose();
                }
                else
                {
                    btnGetStatus.Enabled = true;
                    btnI2cReset.Enabled = true;
                    btnSetPullUpR.Enabled = true;
                    btnSetSpeed.Enabled = true;
                    btnI2cTx.Enabled = true;
                    btnI2cRx.Enabled = true;

                    StatusResult();

                    tbxCommParam.Text = "Baudrate = " + Convert.ToString(I2cDriverDef.BaudRate) + "    ";
                    tbxCommParam.Text += "Databits = " + Convert.ToString(I2cDriverDef.DataBits) + "    ";
                    tbxCommParam.Text += "Stopbits = " + Convert.ToString(I2cDriverDef.StopBits) + " ";
                    tbxCommParam.Text += "Parity = " + Convert.ToString(I2cDriverDef.Parity) + "    ";
                    tbxCommParam.Text += "Handshake = " + Convert.ToString(I2cDriverDef.Handshake) + "                               ";
                    tbxCommParam.Text += "Read Timeout = " + Convert.ToString(I2cDriverDef.ReadTimeOut) + "    ";
                    tbxCommParam.Text += "Write Timeout = " + Convert.ToString(I2cDriverDef.WriteTimeOut);
                }

                btnCommOpen.Text = "Close";
            }
        }

        private void rbtMaster_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtMaster.Checked == true)
                I2c.SetMasterMode();
            btnI2cTx.Enabled = true;
            btnI2cRx.Enabled = true;
            btnGetStatus.Enabled = true;
            btnI2cReset.Enabled = true;
            btnSetPullUpR.Enabled = true;
            btnSetSpeed.Enabled = true;

            CaptureRunning = false;
        }

        private void rbtMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMonitor.Checked == true)
                I2c.SetMonitorMode();
            btnI2cTx.Enabled = false;
            btnI2cRx.Enabled = false;
            btnGetStatus.Enabled = false;
            btnI2cReset.Enabled = false;
            btnSetPullUpR.Enabled = false;
            btnSetSpeed.Enabled = false;

            CaptureRunning = false;
        }

        private void rbtCapture_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCapture.Checked == true)
            {
                I2c.SetCaptureMode();

                btnI2cTx.Enabled = false;
                btnI2cRx.Enabled = false;
                btnGetStatus.Enabled = false;
                btnI2cReset.Enabled = false;
                btnSetPullUpR.Enabled = false;
                btnSetSpeed.Enabled = false;

                I2c.LogOn = false;              // stop Logfile
                btnStopLog.Enabled = false;
                btnStartLog.Enabled = false;

/*                Capfs = new FileStream("I2cDriver2Cap.bin", FileMode.Create);
                Capbw = new BinaryWriter(Capfs);
                Capbw.Close();
                Capfs.Close();
*/                CaptureRunning = true;

                tmPolling.Interval = 3;
                tmPolling.Start();
            }
            else
            {
                I2c.SetCaptureMode();       // also for capture off
                CaptureRunning = false;
                tmPolling.Stop();
                // convert I2cDriver2Cap.bin to I2cDriver2Cap.csv
                CaptureConvert();
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            rbtCapture.Checked = false;
            rbtMonitor.Checked = false;
            rbtMaster.Checked = true;
            I2c.ModuleReboot();
        }

        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            I2c.GetStatus();
            StatusResult();
        }

        private void btnI2cReset_Click(object sender, EventArgs e)
        {
            I2c.I2cReset();
            if(I2c.bRdBuffer[0] != 0)
                I2c.GetStatus();
            StatusResult();
        }

        private void btnSetSpeed_Click(object sender, EventArgs e)
        {
            if (cbxI2cSpeed.Text == "100")
                I2c.I2cSetSpeed((byte)'1');
            else if (cbxI2cSpeed.Text == "400")
                I2c.I2cSetSpeed((byte)'4');
            else
                I2c.bRdBuffer[0] = 0;

            if (I2c.bRdBuffer[0] != 0)
                I2c.GetStatus();
            StatusResult();
        }

        private void btnSetPullUpR_Click(object sender, EventArgs e)
        {
            if (cbxPullUpR.Text == "4.7")
                I2c.I2cSetPullupR(0x24);
            else if (cbxPullUpR.Text == "4.3")
                I2c.I2cSetPullupR(0x12);
            else if (cbxPullUpR.Text == "2.2")
                I2c.I2cSetPullupR(0x09);
            else if (cbxPullUpR.Text == "1.5")
                I2c.I2cSetPullupR(0x1b);
            else if (cbxPullUpR.Text == "1.1")
                I2c.I2cSetPullupR(0x3f);
            else if (cbxPullUpR.Text == "disabled")
                I2c.I2cSetPullupR(0x00);
            else
                I2c.bRdBuffer[0] = 0;

            if (I2c.bRdBuffer[0] != 0)
                I2c.GetStatus();
            StatusResult();
        }

        private void PortNames()
        {
            int length = 0, i;
            AvailablePorts = ComPort.SerialPortNames ();
            length = AvailablePorts.GetLength(0);
            for (i = 0; i < length; i++)
            {
                cbxCommPort.Items.Add(AvailablePorts[i]);
            }
        }

        private void FillRxBox(Byte Size)
        {
            Byte I;

            tbxI2cRx.Text = "";
            tbxRxCount.Text = Convert.ToString(Size, 10);
            for (I = 0; I < Size; I++)
            {
                //tbxI2cRx.Text += Convert.ToString(RxData[I], 16) + " ";
                tbxI2cRx.Text += I2c.bRdBuffer[I].ToString("x2") + " ";
            }
        }

        public void ClearRxBuffer(Byte Size)
        {
            Byte I;
            for (I = 0; I < Size; I++)
            {
                I2c.bRdBuffer[I] = 0;
            }
        }

        private void ReadAndLog(byte bRxCnt)
        {
            bool Ack = I2c.ReadBytes(Convert.ToByte(tbxAddr.Text, 16),
                                bRxCnt);
            string Log = "";

            if (Ack == false)
            {
                uiNAKCnt = Convert.ToUInt16(tbxNAKCnt.Text);
                uiNAKCnt++;
                tbxNAKCnt.Text = Convert.ToString(uiNAKCnt);
            }
            else
            {
                FillRxBox(bRxCnt);
                if (I2c.LogOn == true)
                {
                    I2c.fs = new FileStream("I2cDriver2.log", FileMode.Append);
                    I2c.sw = new StreamWriter(I2c.fs);
                    Log = "Rd: " + tbxI2cRx.Text + " ";
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
        }



        //------------ Eeprom -------------------------------------------------------

        private void btnEepromRead_Click(object sender, EventArgs e)
        {
            Eeprom.SetEepromParam(Convert.ToInt32(tbxStartAddr.Text),  // Addr
                                      Convert.ToInt32(tbxSize.Text),       // Length
                                      Convert.ToByte(tbxPageSize.Text),    // PageSize
                                      Convert.ToByte(tbxAddr.Text, 16),    // DeviceAddr
                                      cbx2ByteAddr.Checked);               // TwoByteAddr

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Eeprom.MemRdRunning = false;
                return;
            }
            else
                Eeprom.FileName = saveFileDialog1.FileName;

            Eeprom.MemRdRunning = true;
            tbxCurrentAddr.Text = tbxStartAddr.Text;

            tmPolling.Interval = 1;
            tmPolling.Start();
        }

        private void btnEepromWrite_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Eeprom.MemWrRunning = false;
                return;
            }
            else
                Eeprom.FileName = openFileDialog1.FileName;

            Eeprom.MemWrRunning = true;
            tbxCurrentAddr.Text = tbxStartAddr.Text;
            
            Eeprom.SetEepromParam(Convert.ToInt32(tbxStartAddr.Text),  // Addr
                                  Convert.ToInt32(tbxSize.Text),       // Length
                                  Convert.ToByte(tbxPageSize.Text),    // PageSize
                                  Convert.ToByte(tbxAddr.Text, 16),    // DeviceAddr
                                  cbx2ByteAddr.Checked);               //

            tmPolling.Interval = 1;
            tmPolling.Start();
        }

        //------------- Capture ------------------------------------

        private void CaptureI2c()
        {
            Capfs = new FileStream("I2cDriver2Cap.bin", FileMode.Append);
            Capbw = new BinaryWriter(Capfs);

            int BytesRead = 0;
            BytesRead += ComPort._serialPort.Read(bCapRdBuffer, 0, 256);

            int i;
            for (i = 0; i < BytesRead; i++)
            {
                Capbw.Write(bCapRdBuffer[i]);
            }

            Capbw.Close();
            Capfs.Close();
        }

        private void CaptureConvert()
        {
            Byte[] Nibbels = new Byte[512];
            UInt16[] Bits = new UInt16[3];
            Int16 i , j, k=0, size, l;
            string Line = "";
            byte ack;
            bool Stop = false;
            UInt16 b9, b8;

            Capfs = new FileStream("I2cDriver2Cap.bin", FileMode.Open);
            Capbr = new BinaryReader(Capfs);

            I2c.fs = new FileStream("I2cDriver2Cap.txt", FileMode.Create);
            I2c.sw = new StreamWriter(I2c.fs);
            
            do
            {
                l = 0;

                if ((Capfs.Length - Capfs.Position) >= 256)
                {
                    size = 256;
                    for (i = 0; i < size; i++)
                    {
                        byte b = Capbr.ReadByte();
                        Nibbels[l++] = (byte)((b >> 4) & 0x0f);
                        Nibbels[l++] = (byte)(b & 0x0f);
                    }
                }
                else if ((Capfs.Length - Capfs.Position) > 0)
                {
                    size = (Int16)(Capfs.Length - Capfs.Position);
                    for (i = 0; i < size; i++)
                    {
                        byte b = Capbr.ReadByte();
                        Nibbels[l++] = (byte)((b >> 4) & 0x0f);
                        Nibbels[l++] = (byte)(b & 0x0f);
                    }
                }
                else
                {
                    size = 0;
                }

                l = 0;
                for (j = 0; j < (size<<1); j++)
                {

                    if (Nibbels[j] == 0)
                    {
                        Line += ". ";
                        Stop = true;
                        k = 0;
                        l++;
                        if (l == 40)
                        {
                            Line += "\n";
                            I2c.sw.WriteLine(Line);
                            Line = "";
                            l = 0;
                        }
                    }

                    else if (Nibbels[j] == 1)
                    {
                        I2c.sw.WriteLine(Line);
                        Line = "";
                        Line += "Start ";
                        Stop = false;
                        k = 0;
                    }
                    else if (Nibbels[j] == 2)
                    {
                        Line += "Stop\n";
                        Stop = true;
                    }
                    else if ((Nibbels[j] >= 8) && (Nibbels[j] <= 0x0f))
                    {
                        if (Stop == true)
                        {
                            I2c.sw.WriteLine(Line);
                            Line = "";
                            Line += "Start ";
                            Stop = false;
                        }
                        Bits[k] = (UInt16)(Nibbels[j] & 7);
                        k++;
                        if (k == 3)
                        {
                            k = 0;
                            b9 = (UInt16)(Bits[0] << 6 | Bits[1] << 3 | Bits[2]);
                            b8 = (UInt16)(b9 >> 1);
                            ack = (byte)(b9 & 1);
                            string Hex = Convert.ToString(b8, 16);
                            if (Hex.Length == 1)
                                Hex = "0" + Hex;
                            Line += Hex + "_";
                            if (ack == 0)
                                Line += "Ack ";
                            else
                                Line += "Nack ";
                        }
                    }
                    else
                        Line += "unexpected value ";
                }

            } while (size >= 3);

            I2c.sw.Close();
            I2c.fs.Close();

            Capbr.Close();
            Capfs.Close();
        }

    



        //---------------------------------------------------------------------------
        private delegate void tmPollingTickDelegate(object sender, EventArgs e);

        private void tmPolling_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new tmPollingTickDelegate(tmPolling_Tick), new object[] { sender, e });
            }
            else
            {
                if (cbxRepeat.Checked == true)       // Terminal Tx repeat
                {
                    bool Ack = true;

                    if (tbxI2cTx.Text != "") // if "", then supress I2cWr
                    {
                        Ack = I2c.WriteBytes(Convert.ToByte(tbxAddr.Text, 16),
                                             tbxI2cTx.Text);

                        if (cbxRepeatedStart.Checked == false)
                            I2c.StopCond();
                    }
                    if (Ack == false)
                    {
                        uiNAKCnt++;
                        tbxNAKCnt.Text = Convert.ToString(uiNAKCnt);
                    }
                    else
                    {
                        if ((tbxRxCount.Text != "") && (tbxRxCount.Text != "0"))
                        {                   // something to read
                            ReadAndLog(Convert.ToByte(tbxRxCount.Text, 10));

                            I2c.StopCond();
                        }                   // end of something to read
                    }



                    TxRepeatCounter++;
                    tbxRepeatCounter.Text = Convert.ToString(TxRepeatCounter);

                    if ((StopOnError == true) &&
                        (Ack == false))
                    {
                        cbxRepeat.Checked = false;
                    }
                }

                else if (Eeprom.MemRdRunning == true)
                {
                    if (Eeprom.Read() == false)
                    {
                        uiNAKCnt = Convert.ToUInt16(tbxNAKCnt.Text);
                        uiNAKCnt++;
                        tbxNAKCnt.Text = Convert.ToString(uiNAKCnt);
                        Eeprom.MemRdRunning = false;
                        tbxCurrentAddr.Text = "failed";
                    }
                    else
                    {
                        tbxCurrentAddr.Text = Convert.ToString(Eeprom.Addr);
                    }
                }

                else if (Eeprom.MemWrRunning == true)
                {
                    if (Eeprom.Write() == false)
                    {
                        uiNAKCnt = Convert.ToUInt16(tbxNAKCnt.Text);
                        uiNAKCnt++;
                        tbxNAKCnt.Text = Convert.ToString(uiNAKCnt);
                        Eeprom.MemWrRunning = false;
                        tbxCurrentAddr.Text = "failed";
                    }
                    else
                    {
                        Thread.Sleep(10);           // 10ms Eeprom Wr
                        tbxCurrentAddr.Text = Convert.ToString(Eeprom.Addr);
                    }
                }

                else if (I2c.LogOn == true)
                {
                    tbxLogCounter.Text = Convert.ToString(I2c.LogCounter);
                }

                else if (CaptureRunning == true)
                {
                    CaptureI2c();
                }

                else
                {
                    tmPolling.Stop();
                }

            }
        }
    }
}
