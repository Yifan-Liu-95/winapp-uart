namespace Usart1
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.usartButton = new System.Windows.Forms.Button();
            this.comSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkHexSend = new System.Windows.Forms.CheckBox();
            this.checkTXNewLine = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.checkTiming = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UniqIDBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UniqID = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackColor = System.Drawing.SystemColors.Window;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendButton.Location = new System.Drawing.Point(298, 20);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(65, 46);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version: V0.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port:";
            // 
            // sendBox
            // 
            this.sendBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBox.Location = new System.Drawing.Point(6, 20);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(286, 46);
            this.sendBox.TabIndex = 9;
            this.sendBox.TextChanged += new System.EventHandler(this.sendBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.usartButton);
            this.groupBox1.Controls.Add(this.comSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 391);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox1.Size = new System.Drawing.Size(194, 259);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // usartButton
            // 
            this.usartButton.BackColor = System.Drawing.SystemColors.Window;
            this.usartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usartButton.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.usartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.usartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.usartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usartButton.Location = new System.Drawing.Point(11, 330);
            this.usartButton.Name = "usartButton";
            this.usartButton.Size = new System.Drawing.Size(196, 40);
            this.usartButton.TabIndex = 16;
            this.usartButton.Text = "Open";
            this.usartButton.UseVisualStyleBackColor = false;
            this.usartButton.Click += new System.EventHandler(this.usartButton_Click);
            // 
            // comSelect
            // 
            this.comSelect.FormattingEnabled = true;
            this.comSelect.Location = new System.Drawing.Point(69, 31);
            this.comSelect.MaxDropDownItems = 30;
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(88, 20);
            this.comSelect.TabIndex = 15;
            this.comSelect.Click += new System.EventHandler(this.comSelect_Click);
            this.comSelect.MouseLeave += new System.EventHandler(this.comSelect_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkHexSend);
            this.groupBox2.Controls.Add(this.checkTXNewLine);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.timeBox);
            this.groupBox2.Controls.Add(this.checkTiming);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Controls.Add(this.sendBox);
            this.groupBox2.Location = new System.Drawing.Point(253, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 122);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // checkHexSend
            // 
            this.checkHexSend.AutoSize = true;
            this.checkHexSend.Location = new System.Drawing.Point(205, 92);
            this.checkHexSend.Name = "checkHexSend";
            this.checkHexSend.Size = new System.Drawing.Size(60, 16);
            this.checkHexSend.TabIndex = 16;
            this.checkHexSend.Text = "In Hex";
            this.checkHexSend.UseVisualStyleBackColor = true;
            this.checkHexSend.Click += new System.EventHandler(this.checkHexSend_Click);
            // 
            // checkTXNewLine
            // 
            this.checkTXNewLine.AutoSize = true;
            this.checkTXNewLine.Location = new System.Drawing.Point(205, 74);
            this.checkTXNewLine.Name = "checkTXNewLine";
            this.checkTXNewLine.Size = new System.Drawing.Size(72, 16);
            this.checkTXNewLine.TabIndex = 15;
            this.checkTXNewLine.Text = "New line";
            this.checkTXNewLine.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "ms";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(74, 70);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(72, 21);
            this.timeBox.TabIndex = 13;
            this.timeBox.Text = "1000";
            // 
            // checkTiming
            // 
            this.checkTiming.AutoSize = true;
            this.checkTiming.Location = new System.Drawing.Point(6, 74);
            this.checkTiming.Name = "checkTiming";
            this.checkTiming.Size = new System.Drawing.Size(72, 16);
            this.checkTiming.TabIndex = 12;
            this.checkTiming.Text = "Interval";
            this.checkTiming.UseVisualStyleBackColor = true;
            this.checkTiming.CheckStateChanged += new System.EventHandler(this.checkTiming_CheckStateChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.UniqIDBox);
            this.groupBox3.Controls.Add(this.DeleteBtn);
            this.groupBox3.Controls.Add(this.AddBtn);
            this.groupBox3.Controls.Add(this.UniqID);
            this.groupBox3.Location = new System.Drawing.Point(253, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 263);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensors";
            // 
            // UniqIDBox
            // 
            this.UniqIDBox.Location = new System.Drawing.Point(208, 26);
            this.UniqIDBox.Name = "UniqIDBox";
            this.UniqIDBox.Size = new System.Drawing.Size(152, 21);
            this.UniqIDBox.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(255, 121);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(65, 26);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(255, 65);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(65, 26);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UniqID
            // 
            this.UniqID.FormattingEnabled = true;
            this.UniqID.Location = new System.Drawing.Point(9, 26);
            this.UniqID.Name = "UniqID";
            this.UniqID.Size = new System.Drawing.Size(178, 212);
            this.UniqID.TabIndex = 0;
            this.UniqID.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.UniqID_ItemCheck);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Sending_Checked_Items);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "usart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.TextBox UniqIDBox;

        private System.Windows.Forms.Button DeleteBtn;

        private System.Windows.Forms.CheckedListBox UniqID;

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.CheckedListBox checkedListBox1;

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox bpsSelect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comSelect;
        private System.Windows.Forms.Button usartButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox chickBitSelect;
        private System.Windows.Forms.ComboBox stopBitSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dataBitSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox flowControlSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.CheckBox checkTiming;
        private System.Windows.Forms.CheckBox checkHexSend;
        private System.Windows.Forms.CheckBox checkTXNewLine;
        private System.Windows.Forms.Timer timer1;
    }
}

