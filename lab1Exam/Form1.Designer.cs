namespace lab1Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxGesture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxSavetofile = new System.Windows.Forms.CheckBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonFilename = new System.Windows.Forms.Button();
            this.textBoxOrientation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSerialDataStream = new System.Windows.Forms.TextBox();
            this.textBoxItemsInQueue = new System.Windows.Forms.TextBox();
            this.textBoxTempStringLength = new System.Windows.Forms.TextBox();
            this.textBoxBytesToRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxQueueContents = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonDQAvg = new System.Windows.Forms.Button();
            this.textBoxAvgZ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAvgY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAvgX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAvgZ2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxAvgY2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxAvgX2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonDQAvg2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(75, 454);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(101, 30);
            this.textBoxState.TabIndex = 43;
            this.textBoxState.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gesture";
            // 
            // textBoxGesture
            // 
            this.textBoxGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGesture.Location = new System.Drawing.Point(305, 454);
            this.textBoxGesture.Name = "textBoxGesture";
            this.textBoxGesture.Size = new System.Drawing.Size(101, 30);
            this.textBoxGesture.TabIndex = 41;
            this.textBoxGesture.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "State";
            // 
            // checkBoxSavetofile
            // 
            this.checkBoxSavetofile.AutoSize = true;
            this.checkBoxSavetofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSavetofile.Location = new System.Drawing.Point(13, 498);
            this.checkBoxSavetofile.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSavetofile.Name = "checkBoxSavetofile";
            this.checkBoxSavetofile.Size = new System.Drawing.Size(119, 24);
            this.checkBoxSavetofile.TabIndex = 23;
            this.checkBoxSavetofile.Text = "Save to File";
            this.checkBoxSavetofile.UseVisualStyleBackColor = true;
            this.checkBoxSavetofile.CheckedChanged += new System.EventHandler(this.checkBoxSavetofile_CheckedChanged);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.Location = new System.Drawing.Point(220, 523);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(183, 30);
            this.textBoxFileName.TabIndex = 26;
            // 
            // buttonFilename
            // 
            this.buttonFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilename.Location = new System.Drawing.Point(12, 522);
            this.buttonFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilename.Name = "buttonFilename";
            this.buttonFilename.Size = new System.Drawing.Size(200, 33);
            this.buttonFilename.TabIndex = 29;
            this.buttonFilename.Text = "Select Filename";
            this.buttonFilename.UseVisualStyleBackColor = true;
            this.buttonFilename.Click += new System.EventHandler(this.buttonFilename_Click);
            // 
            // textBoxOrientation
            // 
            this.textBoxOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrientation.Location = new System.Drawing.Point(220, 419);
            this.textBoxOrientation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOrientation.Name = "textBoxOrientation";
            this.textBoxOrientation.Size = new System.Drawing.Size(187, 30);
            this.textBoxOrientation.TabIndex = 38;
            this.textBoxOrientation.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Orientation";
            // 
            // textBoxAz
            // 
            this.textBoxAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAz.Location = new System.Drawing.Point(338, 385);
            this.textBoxAz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAz.Name = "textBoxAz";
            this.textBoxAz.Size = new System.Drawing.Size(69, 30);
            this.textBoxAz.TabIndex = 37;
            this.textBoxAz.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Az";
            // 
            // textBoxAy
            // 
            this.textBoxAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAy.Location = new System.Drawing.Point(196, 385);
            this.textBoxAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAy.Name = "textBoxAy";
            this.textBoxAy.Size = new System.Drawing.Size(69, 30);
            this.textBoxAy.TabIndex = 35;
            this.textBoxAy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ay";
            // 
            // textBoxAx
            // 
            this.textBoxAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAx.Location = new System.Drawing.Point(49, 385);
            this.textBoxAx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAx.Name = "textBoxAx";
            this.textBoxAx.Size = new System.Drawing.Size(69, 30);
            this.textBoxAx.TabIndex = 33;
            this.textBoxAx.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ax";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(216, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Connect Serial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSerialDataStream
            // 
            this.textBoxSerialDataStream.Location = new System.Drawing.Point(12, 182);
            this.textBoxSerialDataStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSerialDataStream.Multiline = true;
            this.textBoxSerialDataStream.Name = "textBoxSerialDataStream";
            this.textBoxSerialDataStream.Size = new System.Drawing.Size(408, 190);
            this.textBoxSerialDataStream.TabIndex = 31;
            this.textBoxSerialDataStream.TabStop = false;
            // 
            // textBoxItemsInQueue
            // 
            this.textBoxItemsInQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemsInQueue.Location = new System.Drawing.Point(220, 119);
            this.textBoxItemsInQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxItemsInQueue.Name = "textBoxItemsInQueue";
            this.textBoxItemsInQueue.Size = new System.Drawing.Size(187, 30);
            this.textBoxItemsInQueue.TabIndex = 30;
            this.textBoxItemsInQueue.TabStop = false;
            // 
            // textBoxTempStringLength
            // 
            this.textBoxTempStringLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempStringLength.Location = new System.Drawing.Point(220, 85);
            this.textBoxTempStringLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTempStringLength.Name = "textBoxTempStringLength";
            this.textBoxTempStringLength.Size = new System.Drawing.Size(187, 30);
            this.textBoxTempStringLength.TabIndex = 27;
            this.textBoxTempStringLength.TabStop = false;
            // 
            // textBoxBytesToRead
            // 
            this.textBoxBytesToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBytesToRead.Location = new System.Drawing.Point(220, 50);
            this.textBoxBytesToRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBytesToRead.Name = "textBoxBytesToRead";
            this.textBoxBytesToRead.Size = new System.Drawing.Size(187, 30);
            this.textBoxBytesToRead.TabIndex = 24;
            this.textBoxBytesToRead.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Items in Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Temp String Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Serial Bytes to Read";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Serial Data Stream";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxQueueContents
            // 
            this.textBoxQueueContents.Location = new System.Drawing.Point(448, 113);
            this.textBoxQueueContents.Multiline = true;
            this.textBoxQueueContents.Name = "textBoxQueueContents";
            this.textBoxQueueContents.Size = new System.Drawing.Size(595, 186);
            this.textBoxQueueContents.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(444, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Queue Contents";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(556, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Max accel in g";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(473, 44);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(67, 30);
            this.textBoxN.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(445, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "N:";
            // 
            // buttonDQAvg
            // 
            this.buttonDQAvg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDQAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDQAvg.Location = new System.Drawing.Point(448, 4);
            this.buttonDQAvg.Name = "buttonDQAvg";
            this.buttonDQAvg.Size = new System.Drawing.Size(472, 35);
            this.buttonDQAvg.TabIndex = 44;
            this.buttonDQAvg.Text = "Dequeue and Average First N Data Points";
            this.buttonDQAvg.UseVisualStyleBackColor = false;
            this.buttonDQAvg.Click += new System.EventHandler(this.buttonDQAvg_Click);
            // 
            // textBoxAvgZ
            // 
            this.textBoxAvgZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgZ.Location = new System.Drawing.Point(961, 42);
            this.textBoxAvgZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgZ.Name = "textBoxAvgZ";
            this.textBoxAvgZ.Size = new System.Drawing.Size(82, 30);
            this.textBoxAvgZ.TabIndex = 56;
            this.textBoxAvgZ.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(940, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "z";
            // 
            // textBoxAvgY
            // 
            this.textBoxAvgY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgY.Location = new System.Drawing.Point(856, 42);
            this.textBoxAvgY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgY.Name = "textBoxAvgY";
            this.textBoxAvgY.Size = new System.Drawing.Size(78, 30);
            this.textBoxAvgY.TabIndex = 54;
            this.textBoxAvgY.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(836, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "y";
            // 
            // textBoxAvgX
            // 
            this.textBoxAvgX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgX.Location = new System.Drawing.Point(749, 42);
            this.textBoxAvgX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgX.Name = "textBoxAvgX";
            this.textBoxAvgX.Size = new System.Drawing.Size(81, 30);
            this.textBoxAvgX.TabIndex = 52;
            this.textBoxAvgX.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(729, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 25);
            this.label16.TabIndex = 51;
            this.label16.Text = "x";
            // 
            // textBoxAvgZ2
            // 
            this.textBoxAvgZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgZ2.Location = new System.Drawing.Point(963, 354);
            this.textBoxAvgZ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgZ2.Name = "textBoxAvgZ2";
            this.textBoxAvgZ2.Size = new System.Drawing.Size(82, 30);
            this.textBoxAvgZ2.TabIndex = 66;
            this.textBoxAvgZ2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(942, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 25);
            this.label17.TabIndex = 65;
            this.label17.Text = "z";
            // 
            // textBoxAvgY2
            // 
            this.textBoxAvgY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgY2.Location = new System.Drawing.Point(858, 354);
            this.textBoxAvgY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgY2.Name = "textBoxAvgY2";
            this.textBoxAvgY2.Size = new System.Drawing.Size(78, 30);
            this.textBoxAvgY2.TabIndex = 64;
            this.textBoxAvgY2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(838, 359);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 25);
            this.label18.TabIndex = 63;
            this.label18.Text = "y";
            // 
            // textBoxAvgX2
            // 
            this.textBoxAvgX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgX2.Location = new System.Drawing.Point(751, 354);
            this.textBoxAvgX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvgX2.Name = "textBoxAvgX2";
            this.textBoxAvgX2.Size = new System.Drawing.Size(81, 30);
            this.textBoxAvgX2.TabIndex = 62;
            this.textBoxAvgX2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(731, 359);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 25);
            this.label19.TabIndex = 61;
            this.label19.Text = "x";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(558, 359);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 25);
            this.label20.TabIndex = 60;
            this.label20.Text = "Max accel in g";
            // 
            // textBoxN2
            // 
            this.textBoxN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN2.Location = new System.Drawing.Point(475, 356);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(67, 30);
            this.textBoxN2.TabIndex = 59;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(447, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 25);
            this.label21.TabIndex = 58;
            this.label21.Text = "N:";
            // 
            // buttonDQAvg2
            // 
            this.buttonDQAvg2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDQAvg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDQAvg2.Location = new System.Drawing.Point(450, 316);
            this.buttonDQAvg2.Name = "buttonDQAvg2";
            this.buttonDQAvg2.Size = new System.Drawing.Size(472, 35);
            this.buttonDQAvg2.TabIndex = 57;
            this.buttonDQAvg2.Text = "Dequeue and Average First N Data Points";
            this.buttonDQAvg2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 564);
            this.Controls.Add(this.textBoxAvgZ2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxAvgY2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxAvgX2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonDQAvg2);
            this.Controls.Add(this.textBoxAvgZ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxAvgY);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxAvgX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxQueueContents);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonDQAvg);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxGesture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxSavetofile);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonFilename);
            this.Controls.Add(this.textBoxOrientation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSerialDataStream);
            this.Controls.Add(this.textBoxItemsInQueue);
            this.Controls.Add(this.textBoxTempStringLength);
            this.Controls.Add(this.textBoxBytesToRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Lab 1 Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxGesture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxSavetofile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonFilename;
        private System.Windows.Forms.TextBox textBoxOrientation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSerialDataStream;
        private System.Windows.Forms.TextBox textBoxItemsInQueue;
        private System.Windows.Forms.TextBox textBoxTempStringLength;
        private System.Windows.Forms.TextBox textBoxBytesToRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxQueueContents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonDQAvg;
        private System.Windows.Forms.TextBox textBoxAvgZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAvgY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAvgX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAvgZ2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxAvgY2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxAvgX2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonDQAvg2;
    }
}

