namespace ledSend
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbDecrypt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSaveFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbEncrypt = new System.Windows.Forms.CheckBox();
            this.tbFileType = new System.Windows.Forms.TextBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSendFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRevCount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendCount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBleStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeralStatus = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tbrevType = new System.Windows.Forms.TextBox();
            this.tbrevSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbRevNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbrevName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.chbdev3 = new System.Windows.Forms.CheckBox();
            this.chbdev2 = new System.Windows.Forms.CheckBox();
            this.chbdev1 = new System.Windows.Forms.CheckBox();
            this.pgbFileSIze = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnSendNum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendNum);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(9, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 116);
            this.panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "三号设备";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "二号设备";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "一号设备";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(196, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口信息:";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(72, 17);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(106, 20);
            this.cmbPort.TabIndex = 0;
            this.cmbPort.Click += new System.EventHandler(this.cmbPort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据发送和接收设置";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chbDecrypt);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.tbSaveFile);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(7, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 125);
            this.panel3.TabIndex = 6;
            // 
            // chbDecrypt
            // 
            this.chbDecrypt.AutoSize = true;
            this.chbDecrypt.Location = new System.Drawing.Point(5, 62);
            this.chbDecrypt.Name = "chbDecrypt";
            this.chbDecrypt.Size = new System.Drawing.Size(72, 16);
            this.chbDecrypt.TabIndex = 10;
            this.chbDecrypt.Text = "是否解密";
            this.chbDecrypt.UseVisualStyleBackColor = true;
            this.chbDecrypt.CheckedChanged += new System.EventHandler(this.chbDecrypt_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSaveFile
            // 
            this.tbSaveFile.Location = new System.Drawing.Point(5, 24);
            this.tbSaveFile.Name = "tbSaveFile";
            this.tbSaveFile.Size = new System.Drawing.Size(231, 21);
            this.tbSaveFile.TabIndex = 5;
            this.tbSaveFile.Text = "D:\\test\\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "设置保存地址:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbEncrypt);
            this.panel2.Controls.Add(this.tbFileType);
            this.panel2.Controls.Add(this.tbFileSize);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbSendFile);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.Location = new System.Drawing.Point(7, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 143);
            this.panel2.TabIndex = 5;
            // 
            // chbEncrypt
            // 
            this.chbEncrypt.AutoSize = true;
            this.chbEncrypt.Location = new System.Drawing.Point(9, 116);
            this.chbEncrypt.Name = "chbEncrypt";
            this.chbEncrypt.Size = new System.Drawing.Size(72, 16);
            this.chbEncrypt.TabIndex = 9;
            this.chbEncrypt.Text = "是否加密";
            this.chbEncrypt.UseVisualStyleBackColor = true;
            this.chbEncrypt.CheckedChanged += new System.EventHandler(this.chbEncrypt_CheckedChanged);
            // 
            // tbFileType
            // 
            this.tbFileType.Location = new System.Drawing.Point(71, 89);
            this.tbFileType.Name = "tbFileType";
            this.tbFileType.Size = new System.Drawing.Size(100, 21);
            this.tbFileType.TabIndex = 8;
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(71, 62);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(100, 21);
            this.tbFileSize.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "文件类型:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "文件大小:";
            // 
            // tbSendFile
            // 
            this.tbSendFile.Location = new System.Drawing.Point(3, 35);
            this.tbSendFile.Name = "tbSendFile";
            this.tbSendFile.Size = new System.Drawing.Size(231, 21);
            this.tbSendFile.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "发送文件:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(240, 35);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(42, 23);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClean);
            this.groupBox3.Controls.Add(this.btnRevCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSendCount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnBleStatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSeralStatus);
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "状态信息";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(636, 18);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "清空";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRevCount
            // 
            this.btnRevCount.Location = new System.Drawing.Point(492, 18);
            this.btnRevCount.Name = "btnRevCount";
            this.btnRevCount.Size = new System.Drawing.Size(99, 23);
            this.btnRevCount.TabIndex = 10;
            this.btnRevCount.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "已接收:";
            // 
            // btnSendCount
            // 
            this.btnSendCount.Location = new System.Drawing.Point(324, 18);
            this.btnSendCount.Name = "btnSendCount";
            this.btnSendCount.Size = new System.Drawing.Size(88, 23);
            this.btnSendCount.TabIndex = 8;
            this.btnSendCount.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "已发送:";
            // 
            // btnBleStatus
            // 
            this.btnBleStatus.Location = new System.Drawing.Point(231, 18);
            this.btnBleStatus.Name = "btnBleStatus";
            this.btnBleStatus.Size = new System.Drawing.Size(34, 23);
            this.btnBleStatus.TabIndex = 6;
            this.btnBleStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "蓝牙链接状态:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "串口链接状态:";
            // 
            // btnSeralStatus
            // 
            this.btnSeralStatus.Location = new System.Drawing.Point(90, 18);
            this.btnSeralStatus.Name = "btnSeralStatus";
            this.btnSeralStatus.Size = new System.Drawing.Size(34, 23);
            this.btnSeralStatus.TabIndex = 0;
            this.btnSeralStatus.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(805, 12);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(191, 347);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // tbrevType
            // 
            this.tbrevType.Location = new System.Drawing.Point(76, 72);
            this.tbrevType.Name = "tbrevType";
            this.tbrevType.Size = new System.Drawing.Size(100, 21);
            this.tbrevType.TabIndex = 14;
            // 
            // tbrevSize
            // 
            this.tbrevSize.Location = new System.Drawing.Point(76, 45);
            this.tbrevSize.Name = "tbrevSize";
            this.tbrevSize.Size = new System.Drawing.Size(100, 21);
            this.tbrevSize.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "文件类型:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "文件大小:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Location = new System.Drawing.Point(599, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 294);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据发送/接收";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbRevNum);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.tbrevName);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tbrevType);
            this.panel5.Controls.Add(this.tbrevSize);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(7, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 123);
            this.panel5.TabIndex = 12;
            // 
            // tbRevNum
            // 
            this.tbRevNum.Location = new System.Drawing.Point(76, 16);
            this.tbRevNum.Name = "tbRevNum";
            this.tbRevNum.Size = new System.Drawing.Size(100, 21);
            this.tbRevNum.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "接收对象:";
            // 
            // tbrevName
            // 
            this.tbrevName.Location = new System.Drawing.Point(76, 99);
            this.tbrevName.Name = "tbrevName";
            this.tbrevName.Size = new System.Drawing.Size(100, 21);
            this.tbrevName.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "文件名:";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(83, 261);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(111, 27);
            this.btnSendData.TabIndex = 11;
            this.btnSendData.Text = "发送";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.chbdev3);
            this.panel4.Controls.Add(this.chbdev2);
            this.panel4.Controls.Add(this.chbdev1);
            this.panel4.Location = new System.Drawing.Point(6, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 100);
            this.panel4.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "发送对象:";
            // 
            // chbdev3
            // 
            this.chbdev3.AutoSize = true;
            this.chbdev3.Location = new System.Drawing.Point(90, 65);
            this.chbdev3.Name = "chbdev3";
            this.chbdev3.Size = new System.Drawing.Size(54, 16);
            this.chbdev3.TabIndex = 12;
            this.chbdev3.Text = "设备3";
            this.chbdev3.UseVisualStyleBackColor = true;
            // 
            // chbdev2
            // 
            this.chbdev2.AutoSize = true;
            this.chbdev2.Location = new System.Drawing.Point(90, 37);
            this.chbdev2.Name = "chbdev2";
            this.chbdev2.Size = new System.Drawing.Size(54, 16);
            this.chbdev2.TabIndex = 11;
            this.chbdev2.Text = "设备2";
            this.chbdev2.UseVisualStyleBackColor = true;
            // 
            // chbdev1
            // 
            this.chbdev1.AutoSize = true;
            this.chbdev1.Location = new System.Drawing.Point(90, 10);
            this.chbdev1.Name = "chbdev1";
            this.chbdev1.Size = new System.Drawing.Size(54, 16);
            this.chbdev1.TabIndex = 10;
            this.chbdev1.Text = "设备1";
            this.chbdev1.UseVisualStyleBackColor = true;
            // 
            // pgbFileSIze
            // 
            this.pgbFileSIze.Location = new System.Drawing.Point(24, 369);
            this.pgbFileSIze.Name = "pgbFileSIze";
            this.pgbFileSIze.Size = new System.Drawing.Size(775, 23);
            this.pgbFileSIze.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(37, 369);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(8, 8);
            this.progressBar2.TabIndex = 6;
            // 
            // btnSendNum
            // 
            this.btnSendNum.Location = new System.Drawing.Point(167, 90);
            this.btnSendNum.Name = "btnSendNum";
            this.btnSendNum.Size = new System.Drawing.Size(89, 23);
            this.btnSendNum.TabIndex = 3;
            this.btnSendNum.Text = "设置本地编号";
            this.btnSendNum.UseVisualStyleBackColor = true;
            this.btnSendNum.Click += new System.EventHandler(this.btnSendNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 408);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pgbFileSIze);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeralStatus;
        private System.Windows.Forms.Button btnBleStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendCount;
        private System.Windows.Forms.Button btnRevCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbSendFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFileType;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.CheckBox chbEncrypt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSaveFile;
        private System.Windows.Forms.CheckBox chbDecrypt;
        private System.Windows.Forms.TextBox tbrevType;
        private System.Windows.Forms.TextBox tbrevSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chbdev3;
        private System.Windows.Forms.CheckBox chbdev2;
        private System.Windows.Forms.CheckBox chbdev1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbrevName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox tbRevNum;
        private System.Windows.Forms.ProgressBar pgbFileSIze;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnSendNum;
    }
}

