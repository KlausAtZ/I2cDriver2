namespace I2cDriver2
{
    partial class I2cDriver2Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label25 = new System.Windows.Forms.Label();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStartLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLogCounter = new System.Windows.Forms.TextBox();
            this.btnStopLog = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxNAKCnt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Terminal = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnI2cRx = new System.Windows.Forms.Button();
            this.cbxRepeatedStart = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxStopOnError = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxRepeatCounter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxRepeatDelay = new System.Windows.Forms.TextBox();
            this.cbxRepeat = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRxCount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxI2cRx = new System.Windows.Forms.TextBox();
            this.tbxI2cTx = new System.Windows.Forms.TextBox();
            this.btnI2cTx = new System.Windows.Forms.Button();
            this.tmPolling = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPageSize = new System.Windows.Forms.TextBox();
            this.tbxStartAddr = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnEepromRead = new System.Windows.Forms.Button();
            this.cbx2ByteAddr = new System.Windows.Forms.CheckBox();
            this.btnEepromWrite = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.tbxCurrentAddr = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbI2cSpeed = new System.Windows.Forms.GroupBox();
            this.btnCommOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxCommPort = new System.Windows.Forms.ComboBox();
            this.tbxCommParam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSerialNmb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMstVoltage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSlvCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMstTemp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxSDALevel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxSCLLevel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.btnI2cReset = new System.Windows.Forms.Button();
            this.btnSetSpeed = new System.Windows.Forms.Button();
            this.btnSetPullUpR = new System.Windows.Forms.Button();
            this.cbxPullUpR = new System.Windows.Forms.ComboBox();
            this.cbxI2cSpeed = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtMaster = new System.Windows.Forms.RadioButton();
            this.rbtMonitor = new System.Windows.Forms.RadioButton();
            this.rbtCapture = new System.Windows.Forms.RadioButton();
            this.btnReboot = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox4.SuspendLayout();
            this.Terminal.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbI2cSpeed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(501, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 13);
            this.label25.TabIndex = 74;
            this.label25.Text = "I2c addr. (8bit hex)";
            // 
            // tbxAddr
            // 
            this.tbxAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddr.Location = new System.Drawing.Point(504, 119);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(71, 21);
            this.tbxAddr.TabIndex = 73;
            this.tbxAddr.Text = "20";
            this.tbxAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStartLog);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbxLogCounter);
            this.groupBox4.Controls.Add(this.btnStopLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 70);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log file";
            // 
            // btnStartLog
            // 
            this.btnStartLog.Location = new System.Drawing.Point(21, 28);
            this.btnStartLog.Name = "btnStartLog";
            this.btnStartLog.Size = new System.Drawing.Size(82, 23);
            this.btnStartLog.TabIndex = 61;
            this.btnStartLog.Text = "Start Log";
            this.btnStartLog.UseVisualStyleBackColor = true;
            this.btnStartLog.Click += new System.EventHandler(this.btnStartLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Log line counter";
            // 
            // tbxLogCounter
            // 
            this.tbxLogCounter.Location = new System.Drawing.Point(208, 31);
            this.tbxLogCounter.Name = "tbxLogCounter";
            this.tbxLogCounter.Size = new System.Drawing.Size(85, 20);
            this.tbxLogCounter.TabIndex = 59;
            this.tbxLogCounter.Text = "0";
            // 
            // btnStopLog
            // 
            this.btnStopLog.Enabled = false;
            this.btnStopLog.Location = new System.Drawing.Point(110, 28);
            this.btnStopLog.Name = "btnStopLog";
            this.btnStopLog.Size = new System.Drawing.Size(75, 23);
            this.btnStopLog.TabIndex = 57;
            this.btnStopLog.Text = "Stop Log";
            this.btnStopLog.UseVisualStyleBackColor = true;
            this.btnStopLog.Click += new System.EventHandler(this.btnStopLog_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "NAK  cnt";
            // 
            // tbxNAKCnt
            // 
            this.tbxNAKCnt.Location = new System.Drawing.Point(426, 119);
            this.tbxNAKCnt.Name = "tbxNAKCnt";
            this.tbxNAKCnt.Size = new System.Drawing.Size(60, 20);
            this.tbxNAKCnt.TabIndex = 47;
            this.tbxNAKCnt.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(160, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Rx bytes (hex)";
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Terminal.Controls.Add(this.label30);
            this.Terminal.Controls.Add(this.btnI2cRx);
            this.Terminal.Controls.Add(this.cbxRepeatedStart);
            this.Terminal.Controls.Add(this.label12);
            this.Terminal.Controls.Add(this.tbxNAKCnt);
            this.Terminal.Controls.Add(this.label22);
            this.Terminal.Controls.Add(this.label21);
            this.Terminal.Controls.Add(this.cbxStopOnError);
            this.Terminal.Controls.Add(this.label11);
            this.Terminal.Controls.Add(this.tbxRepeatCounter);
            this.Terminal.Controls.Add(this.label10);
            this.Terminal.Controls.Add(this.label25);
            this.Terminal.Controls.Add(this.tbxRepeatDelay);
            this.Terminal.Controls.Add(this.tbxAddr);
            this.Terminal.Controls.Add(this.cbxRepeat);
            this.Terminal.Controls.Add(this.label5);
            this.Terminal.Controls.Add(this.tbxRxCount);
            this.Terminal.Controls.Add(this.btnClear);
            this.Terminal.Controls.Add(this.tbxI2cRx);
            this.Terminal.Controls.Add(this.tbxI2cTx);
            this.Terminal.Controls.Add(this.btnI2cTx);
            this.Terminal.Location = new System.Drawing.Point(12, 306);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(616, 189);
            this.Terminal.TabIndex = 79;
            this.Terminal.TabStop = false;
            this.Terminal.Text = "Terminal";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(89, 98);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 77;
            this.label30.Text = "nmb < 65";
            // 
            // btnI2cRx
            // 
            this.btnI2cRx.Enabled = false;
            this.btnI2cRx.Location = new System.Drawing.Point(6, 72);
            this.btnI2cRx.Name = "btnI2cRx";
            this.btnI2cRx.Size = new System.Drawing.Size(75, 23);
            this.btnI2cRx.TabIndex = 76;
            this.btnI2cRx.Text = "I2C Rd";
            this.btnI2cRx.UseVisualStyleBackColor = true;
            this.btnI2cRx.Click += new System.EventHandler(this.btnI2cRx_Click);
            // 
            // cbxRepeatedStart
            // 
            this.cbxRepeatedStart.AutoSize = true;
            this.cbxRepeatedStart.Location = new System.Drawing.Point(93, 34);
            this.cbxRepeatedStart.Name = "cbxRepeatedStart";
            this.cbxRepeatedStart.Size = new System.Drawing.Size(59, 17);
            this.cbxRepeatedStart.TabIndex = 75;
            this.cbxRepeatedStart.Text = "Rpt St.";
            this.cbxRepeatedStart.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(160, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Tx bytes (hex), nmb < 65";
            // 
            // cbxStopOnError
            // 
            this.cbxStopOnError.AutoSize = true;
            this.cbxStopOnError.Location = new System.Drawing.Point(426, 152);
            this.cbxStopOnError.Name = "cbxStopOnError";
            this.cbxStopOnError.Size = new System.Drawing.Size(87, 17);
            this.cbxStopOnError.TabIndex = 42;
            this.cbxStopOnError.Text = "Stop on error";
            this.cbxStopOnError.UseVisualStyleBackColor = true;
            this.cbxStopOnError.CheckedChanged += new System.EventHandler(this.cbxStopOnError_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Repeat cnt";
            // 
            // tbxRepeatCounter
            // 
            this.tbxRepeatCounter.Location = new System.Drawing.Point(347, 118);
            this.tbxRepeatCounter.Name = "tbxRepeatCounter";
            this.tbxRepeatCounter.Size = new System.Drawing.Size(56, 20);
            this.tbxRepeatCounter.TabIndex = 44;
            this.tbxRepeatCounter.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Repeat delay";
            // 
            // tbxRepeatDelay
            // 
            this.tbxRepeatDelay.Location = new System.Drawing.Point(257, 118);
            this.tbxRepeatDelay.Name = "tbxRepeatDelay";
            this.tbxRepeatDelay.Size = new System.Drawing.Size(56, 20);
            this.tbxRepeatDelay.TabIndex = 42;
            this.tbxRepeatDelay.Text = "100";
            // 
            // cbxRepeat
            // 
            this.cbxRepeat.AutoSize = true;
            this.cbxRepeat.Location = new System.Drawing.Point(257, 152);
            this.cbxRepeat.Name = "cbxRepeat";
            this.cbxRepeat.Size = new System.Drawing.Size(61, 17);
            this.cbxRepeat.TabIndex = 41;
            this.cbxRepeat.Text = "Repeat";
            this.cbxRepeat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Rx cnt (dec)";
            // 
            // tbxRxCount
            // 
            this.tbxRxCount.Location = new System.Drawing.Point(92, 75);
            this.tbxRxCount.Name = "tbxRxCount";
            this.tbxRxCount.Size = new System.Drawing.Size(42, 20);
            this.tbxRxCount.TabIndex = 31;
            this.tbxRxCount.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxI2cRx
            // 
            this.tbxI2cRx.Location = new System.Drawing.Point(156, 75);
            this.tbxI2cRx.Name = "tbxI2cRx";
            this.tbxI2cRx.Size = new System.Drawing.Size(439, 20);
            this.tbxI2cRx.TabIndex = 38;
            // 
            // tbxI2cTx
            // 
            this.tbxI2cTx.Location = new System.Drawing.Point(156, 34);
            this.tbxI2cTx.Name = "tbxI2cTx";
            this.tbxI2cTx.Size = new System.Drawing.Size(439, 20);
            this.tbxI2cTx.TabIndex = 36;
            // 
            // btnI2cTx
            // 
            this.btnI2cTx.Enabled = false;
            this.btnI2cTx.Location = new System.Drawing.Point(6, 31);
            this.btnI2cTx.Name = "btnI2cTx";
            this.btnI2cTx.Size = new System.Drawing.Size(75, 23);
            this.btnI2cTx.TabIndex = 37;
            this.btnI2cTx.Text = "I2C Wr";
            this.btnI2cTx.UseVisualStyleBackColor = true;
            this.btnI2cTx.Click += new System.EventHandler(this.btnI2cTx_Click);
            // 
            // tmPolling
            // 
            this.tmPolling.Interval = 10;
            this.tmPolling.Tick += new System.EventHandler(this.tmPolling_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "EEPROM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxCurrentAddr);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.btnEepromWrite);
            this.groupBox2.Controls.Add(this.cbx2ByteAddr);
            this.groupBox2.Controls.Add(this.btnEepromRead);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.tbxStartAddr);
            this.groupBox2.Controls.Add(this.tbxPageSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.tbxSize);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 114);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EEPROM Read/Write";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(220, 33);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(56, 20);
            this.tbxSize.TabIndex = 79;
            this.tbxSize.Text = "1024";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(217, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 13);
            this.label28.TabIndex = 80;
            this.label28.Text = "Rd/Wr size (dez)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Start addr. (dez)";
            // 
            // tbxPageSize
            // 
            this.tbxPageSize.Location = new System.Drawing.Point(312, 33);
            this.tbxPageSize.Name = "tbxPageSize";
            this.tbxPageSize.Size = new System.Drawing.Size(56, 20);
            this.tbxPageSize.TabIndex = 81;
            this.tbxPageSize.Text = "16";
            // 
            // tbxStartAddr
            // 
            this.tbxStartAddr.Location = new System.Drawing.Point(126, 33);
            this.tbxStartAddr.Name = "tbxStartAddr";
            this.tbxStartAddr.Size = new System.Drawing.Size(56, 20);
            this.tbxStartAddr.TabIndex = 77;
            this.tbxStartAddr.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(310, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 82;
            this.label29.Text = "Page size (dez, <=32)";
            // 
            // btnEepromRead
            // 
            this.btnEepromRead.Location = new System.Drawing.Point(11, 30);
            this.btnEepromRead.Name = "btnEepromRead";
            this.btnEepromRead.Size = new System.Drawing.Size(75, 23);
            this.btnEepromRead.TabIndex = 83;
            this.btnEepromRead.Text = "Read";
            this.btnEepromRead.UseVisualStyleBackColor = true;
            this.btnEepromRead.Click += new System.EventHandler(this.btnEepromRead_Click);
            // 
            // cbx2ByteAddr
            // 
            this.cbx2ByteAddr.AutoSize = true;
            this.cbx2ByteAddr.Location = new System.Drawing.Point(404, 36);
            this.cbx2ByteAddr.Name = "cbx2ByteAddr";
            this.cbx2ByteAddr.Size = new System.Drawing.Size(96, 17);
            this.cbx2ByteAddr.TabIndex = 76;
            this.cbx2ByteAddr.Text = "2 byte int.addr.";
            this.cbx2ByteAddr.UseVisualStyleBackColor = true;
            // 
            // btnEepromWrite
            // 
            this.btnEepromWrite.Location = new System.Drawing.Point(11, 69);
            this.btnEepromWrite.Name = "btnEepromWrite";
            this.btnEepromWrite.Size = new System.Drawing.Size(75, 23);
            this.btnEepromWrite.TabIndex = 84;
            this.btnEepromWrite.Text = "Write";
            this.btnEepromWrite.UseVisualStyleBackColor = true;
            this.btnEepromWrite.Click += new System.EventHandler(this.btnEepromWrite_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(123, 55);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(68, 13);
            this.label32.TabIndex = 86;
            this.label32.Text = "Current addr.";
            // 
            // tbxCurrentAddr
            // 
            this.tbxCurrentAddr.Location = new System.Drawing.Point(126, 71);
            this.tbxCurrentAddr.Name = "tbxCurrentAddr";
            this.tbxCurrentAddr.Size = new System.Drawing.Size(56, 20);
            this.tbxCurrentAddr.TabIndex = 85;
            this.tbxCurrentAddr.Text = "0";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grbI2cSpeed);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I2cDriverModule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbI2cSpeed
            // 
            this.grbI2cSpeed.Controls.Add(this.tbxCommParam);
            this.grbI2cSpeed.Controls.Add(this.cbxCommPort);
            this.grbI2cSpeed.Controls.Add(this.label18);
            this.grbI2cSpeed.Controls.Add(this.label4);
            this.grbI2cSpeed.Controls.Add(this.btnCommOpen);
            this.grbI2cSpeed.Location = new System.Drawing.Point(0, 15);
            this.grbI2cSpeed.Name = "grbI2cSpeed";
            this.grbI2cSpeed.Size = new System.Drawing.Size(417, 112);
            this.grbI2cSpeed.TabIndex = 78;
            this.grbI2cSpeed.TabStop = false;
            this.grbI2cSpeed.Text = "Serial COM status";
            // 
            // btnCommOpen
            // 
            this.btnCommOpen.Location = new System.Drawing.Point(10, 70);
            this.btnCommOpen.Name = "btnCommOpen";
            this.btnCommOpen.Size = new System.Drawing.Size(75, 23);
            this.btnCommOpen.TabIndex = 80;
            this.btnCommOpen.Text = "Open";
            this.btnCommOpen.UseVisualStyleBackColor = true;
            this.btnCommOpen.Click += new System.EventHandler(this.btnCommOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "COM Port";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(205, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "CommParam";
            // 
            // cbxCommPort
            // 
            this.cbxCommPort.FormattingEnabled = true;
            this.cbxCommPort.Location = new System.Drawing.Point(10, 33);
            this.cbxCommPort.Name = "cbxCommPort";
            this.cbxCommPort.Size = new System.Drawing.Size(75, 21);
            this.cbxCommPort.TabIndex = 100;
            // 
            // tbxCommParam
            // 
            this.tbxCommParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCommParam.Location = new System.Drawing.Point(100, 35);
            this.tbxCommParam.Multiline = true;
            this.tbxCommParam.Name = "tbxCommParam";
            this.tbxCommParam.ReadOnly = true;
            this.tbxCommParam.Size = new System.Drawing.Size(300, 58);
            this.tbxCommParam.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxI2cSpeed);
            this.groupBox1.Controls.Add(this.cbxPullUpR);
            this.groupBox1.Controls.Add(this.btnSetPullUpR);
            this.groupBox1.Controls.Add(this.btnSetSpeed);
            this.groupBox1.Controls.Add(this.btnI2cReset);
            this.groupBox1.Controls.Add(this.btnGetStatus);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbxSCLLevel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbxSDALevel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxMstTemp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxSlvCurrent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxMstVoltage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxSerialNmb);
            this.groupBox1.Location = new System.Drawing.Point(0, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 122);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I2c modul status";
            // 
            // tbxSerialNmb
            // 
            this.tbxSerialNmb.Location = new System.Drawing.Point(6, 34);
            this.tbxSerialNmb.Name = "tbxSerialNmb";
            this.tbxSerialNmb.Size = new System.Drawing.Size(75, 20);
            this.tbxSerialNmb.TabIndex = 39;
            this.tbxSerialNmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Serial No.";
            // 
            // tbxMstVoltage
            // 
            this.tbxMstVoltage.Location = new System.Drawing.Point(107, 34);
            this.tbxMstVoltage.Name = "tbxMstVoltage";
            this.tbxMstVoltage.Size = new System.Drawing.Size(75, 20);
            this.tbxMstVoltage.TabIndex = 41;
            this.tbxMstVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mst voltage [V]";
            // 
            // tbxSlvCurrent
            // 
            this.tbxSlvCurrent.Location = new System.Drawing.Point(209, 32);
            this.tbxSlvCurrent.Name = "tbxSlvCurrent";
            this.tbxSlvCurrent.Size = new System.Drawing.Size(75, 20);
            this.tbxSlvCurrent.TabIndex = 43;
            this.tbxSlvCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Slv current [mA]";
            // 
            // tbxMstTemp
            // 
            this.tbxMstTemp.Location = new System.Drawing.Point(310, 34);
            this.tbxMstTemp.Name = "tbxMstTemp";
            this.tbxMstTemp.Size = new System.Drawing.Size(75, 20);
            this.tbxMstTemp.TabIndex = 45;
            this.tbxMstTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mst temp. [°C]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "I2c speed [KHz]";
            // 
            // tbxSDALevel
            // 
            this.tbxSDALevel.Location = new System.Drawing.Point(107, 80);
            this.tbxSDALevel.Name = "tbxSDALevel";
            this.tbxSDALevel.Size = new System.Drawing.Size(75, 20);
            this.tbxSDALevel.TabIndex = 49;
            this.tbxSDALevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "SDA level";
            // 
            // tbxSCLLevel
            // 
            this.tbxSCLLevel.Location = new System.Drawing.Point(209, 80);
            this.tbxSCLLevel.Name = "tbxSCLLevel";
            this.tbxSCLLevel.Size = new System.Drawing.Size(75, 20);
            this.tbxSCLLevel.TabIndex = 51;
            this.tbxSCLLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "SCL level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Pull up R [K]";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Enabled = false;
            this.btnGetStatus.Location = new System.Drawing.Point(411, 34);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(75, 23);
            this.btnGetStatus.TabIndex = 82;
            this.btnGetStatus.Text = "Get status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // btnI2cReset
            // 
            this.btnI2cReset.Enabled = false;
            this.btnI2cReset.Location = new System.Drawing.Point(504, 34);
            this.btnI2cReset.Name = "btnI2cReset";
            this.btnI2cReset.Size = new System.Drawing.Size(75, 23);
            this.btnI2cReset.TabIndex = 83;
            this.btnI2cReset.Text = "I2c reset";
            this.btnI2cReset.UseVisualStyleBackColor = true;
            this.btnI2cReset.Click += new System.EventHandler(this.btnI2cReset_Click);
            // 
            // btnSetSpeed
            // 
            this.btnSetSpeed.Enabled = false;
            this.btnSetSpeed.Location = new System.Drawing.Point(411, 77);
            this.btnSetSpeed.Name = "btnSetSpeed";
            this.btnSetSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnSetSpeed.TabIndex = 84;
            this.btnSetSpeed.Text = "Set speed";
            this.btnSetSpeed.UseVisualStyleBackColor = true;
            this.btnSetSpeed.Click += new System.EventHandler(this.btnSetSpeed_Click);
            // 
            // btnSetPullUpR
            // 
            this.btnSetPullUpR.Enabled = false;
            this.btnSetPullUpR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPullUpR.Location = new System.Drawing.Point(504, 78);
            this.btnSetPullUpR.Name = "btnSetPullUpR";
            this.btnSetPullUpR.Size = new System.Drawing.Size(75, 23);
            this.btnSetPullUpR.TabIndex = 85;
            this.btnSetPullUpR.Text = "Set pull up R";
            this.btnSetPullUpR.UseVisualStyleBackColor = true;
            this.btnSetPullUpR.Click += new System.EventHandler(this.btnSetPullUpR_Click);
            // 
            // cbxPullUpR
            // 
            this.cbxPullUpR.FormattingEnabled = true;
            this.cbxPullUpR.Items.AddRange(new object[] {
            "4.7",
            "4.3",
            "2.2",
            "1.5",
            "1.1",
            "disabled"});
            this.cbxPullUpR.Location = new System.Drawing.Point(310, 80);
            this.cbxPullUpR.Name = "cbxPullUpR";
            this.cbxPullUpR.Size = new System.Drawing.Size(75, 21);
            this.cbxPullUpR.TabIndex = 85;
            // 
            // cbxI2cSpeed
            // 
            this.cbxI2cSpeed.FormattingEnabled = true;
            this.cbxI2cSpeed.Items.AddRange(new object[] {
            "100",
            "400"});
            this.cbxI2cSpeed.Location = new System.Drawing.Point(6, 77);
            this.cbxI2cSpeed.Name = "cbxI2cSpeed";
            this.cbxI2cSpeed.Size = new System.Drawing.Size(75, 21);
            this.cbxI2cSpeed.TabIndex = 86;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnReboot);
            this.groupBox6.Controls.Add(this.rbtCapture);
            this.groupBox6.Controls.Add(this.rbtMonitor);
            this.groupBox6.Controls.Add(this.rbtMaster);
            this.groupBox6.Location = new System.Drawing.Point(427, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 112);
            this.groupBox6.TabIndex = 86;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Module Mode";
            // 
            // rbtMaster
            // 
            this.rbtMaster.AutoSize = true;
            this.rbtMaster.Checked = true;
            this.rbtMaster.Location = new System.Drawing.Point(24, 18);
            this.rbtMaster.Name = "rbtMaster";
            this.rbtMaster.Size = new System.Drawing.Size(103, 17);
            this.rbtMaster.TabIndex = 0;
            this.rbtMaster.TabStop = true;
            this.rbtMaster.Text = "I2c master mode";
            this.rbtMaster.UseVisualStyleBackColor = true;
            this.rbtMaster.CheckedChanged += new System.EventHandler(this.rbtMaster_CheckedChanged);
            // 
            // rbtMonitor
            // 
            this.rbtMonitor.AutoSize = true;
            this.rbtMonitor.Location = new System.Drawing.Point(24, 38);
            this.rbtMonitor.Name = "rbtMonitor";
            this.rbtMonitor.Size = new System.Drawing.Size(89, 17);
            this.rbtMonitor.TabIndex = 1;
            this.rbtMonitor.Text = "Monitor mode";
            this.rbtMonitor.UseVisualStyleBackColor = true;
            this.rbtMonitor.CheckedChanged += new System.EventHandler(this.rbtMonitor_CheckedChanged);
            // 
            // rbtCapture
            // 
            this.rbtCapture.AutoSize = true;
            this.rbtCapture.Location = new System.Drawing.Point(24, 60);
            this.rbtCapture.Name = "rbtCapture";
            this.rbtCapture.Size = new System.Drawing.Size(91, 17);
            this.rbtCapture.TabIndex = 2;
            this.rbtCapture.Text = "Capture mode";
            this.rbtCapture.UseVisualStyleBackColor = true;
            this.rbtCapture.CheckedChanged += new System.EventHandler(this.rbtCapture_CheckedChanged);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(24, 83);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(89, 23);
            this.btnReboot.TabIndex = 84;
            this.btnReboot.Text = "Module reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 287);
            this.tabControl1.TabIndex = 85;
            // 
            // I2cDriver2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.groupBox4);
            this.Name = "I2cDriver2Form";
            this.Text = "I2cDriver2 (Master) - based on I2CDriver by Excamera Labs";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grbI2cSpeed.ResumeLayout(false);
            this.grbI2cSpeed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbxAddr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStartLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLogCounter;
        private System.Windows.Forms.Button btnStopLog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxNAKCnt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox Terminal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbxStopOnError;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxRepeatCounter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxRepeatDelay;
        private System.Windows.Forms.CheckBox cbxRepeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRxCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxI2cRx;
        private System.Windows.Forms.TextBox tbxI2cTx;
        private System.Windows.Forms.Button btnI2cTx;
        private System.Windows.Forms.Timer tmPolling;
        private System.Windows.Forms.CheckBox cbxRepeatedStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnI2cRx;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxCurrentAddr;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnEepromWrite;
        private System.Windows.Forms.CheckBox cbx2ByteAddr;
        private System.Windows.Forms.Button btnEepromRead;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbxStartAddr;
        private System.Windows.Forms.TextBox tbxPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.RadioButton rbtCapture;
        private System.Windows.Forms.RadioButton rbtMonitor;
        private System.Windows.Forms.RadioButton rbtMaster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxI2cSpeed;
        private System.Windows.Forms.ComboBox cbxPullUpR;
        private System.Windows.Forms.Button btnSetPullUpR;
        private System.Windows.Forms.Button btnSetSpeed;
        private System.Windows.Forms.Button btnI2cReset;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxSCLLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxSDALevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMstTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxSlvCurrent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxMstVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSerialNmb;
        private System.Windows.Forms.GroupBox grbI2cSpeed;
        private System.Windows.Forms.TextBox tbxCommParam;
        private System.Windows.Forms.ComboBox cbxCommPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCommOpen;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

