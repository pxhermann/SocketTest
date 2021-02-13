namespace SocketClient
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkAlwaysTop = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblIPaddr = new System.Windows.Forms.Label();
            this.spinIPport = new System.Windows.Forms.NumericUpDown();
            this.lblIPport = new System.Windows.Forms.Label();
            this.grpCon = new System.Windows.Forms.GroupBox();
            this.tbIPaddr = new System.Windows.Forms.TextBox();
            this.lblCliLocaleIP = new System.Windows.Forms.Label();
            this.tbCliLocaleIP = new System.Windows.Forms.TextBox();
            this.lblCliRemoteIP = new System.Windows.Forms.Label();
            this.tbCliRemoteIP = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.lblSendData = new System.Windows.Forms.Label();
            this.cbSendData = new System.Windows.Forms.ComboBox();
            this.tbSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listSend = new System.Windows.Forms.ListBox();
            this.btnSendClear = new System.Windows.Forms.Button();
            this.grpRcv = new System.Windows.Forms.GroupBox();
            this.lblRcvData = new System.Windows.Forms.Label();
            this.listRcv = new System.Windows.Forms.ListBox();
            this.btnRcvClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinIPport)).BeginInit();
            this.grpCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkAlwaysTop
            // 
            this.checkAlwaysTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysTop.AutoSize = true;
            this.checkAlwaysTop.Location = new System.Drawing.Point(24, 442);
            this.checkAlwaysTop.Name = "checkAlwaysTop";
            this.checkAlwaysTop.Size = new System.Drawing.Size(109, 17);
            this.checkAlwaysTop.TabIndex = 26;
            this.checkAlwaysTop.Text = "always on the top";
            this.checkAlwaysTop.CheckedChanged += new System.EventHandler(this.checkAlwaysTop_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(240, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 24);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblIPaddr
            // 
            this.lblIPaddr.Location = new System.Drawing.Point(6, 16);
            this.lblIPaddr.Name = "lblIPaddr";
            this.lblIPaddr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPaddr.Size = new System.Drawing.Size(76, 20);
            this.lblIPaddr.TabIndex = 3;
            this.lblIPaddr.Text = "IP address:";
            this.lblIPaddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spinIPport
            // 
            this.spinIPport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinIPport.Location = new System.Drawing.Point(88, 42);
            this.spinIPport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.spinIPport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinIPport.Name = "spinIPport";
            this.spinIPport.Size = new System.Drawing.Size(144, 20);
            this.spinIPport.TabIndex = 0;
            this.spinIPport.Value = new decimal(new int[] {
            899,
            0,
            0,
            0});
            // 
            // lblIPport
            // 
            this.lblIPport.Location = new System.Drawing.Point(6, 40);
            this.lblIPport.Name = "lblIPport";
            this.lblIPport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPport.Size = new System.Drawing.Size(76, 20);
            this.lblIPport.TabIndex = 0;
            this.lblIPport.Text = "Port #:";
            this.lblIPport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpCon
            // 
            this.grpCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCon.Controls.Add(this.tbIPaddr);
            this.grpCon.Controls.Add(this.lblIPaddr);
            this.grpCon.Controls.Add(this.lblIPport);
            this.grpCon.Controls.Add(this.spinIPport);
            this.grpCon.Controls.Add(this.btnConnect);
            this.grpCon.Controls.Add(this.lblCliLocaleIP);
            this.grpCon.Controls.Add(this.tbCliLocaleIP);
            this.grpCon.Controls.Add(this.lblCliRemoteIP);
            this.grpCon.Controls.Add(this.tbCliRemoteIP);
            this.grpCon.Controls.Add(this.btnClose);
            this.grpCon.Controls.Add(this.grpSend);
            this.grpCon.Controls.Add(this.lblSendData);
            this.grpCon.Controls.Add(this.cbSendData);
            this.grpCon.Controls.Add(this.tbSendData);
            this.grpCon.Controls.Add(this.btnSend);
            this.grpCon.Controls.Add(this.listSend);
            this.grpCon.Controls.Add(this.btnSendClear);
            this.grpCon.Controls.Add(this.grpRcv);
            this.grpCon.Controls.Add(this.lblRcvData);
            this.grpCon.Controls.Add(this.listRcv);
            this.grpCon.Controls.Add(this.btnRcvClear);
            this.grpCon.Location = new System.Drawing.Point(8, 9);
            this.grpCon.Name = "grpCon";
            this.grpCon.Size = new System.Drawing.Size(360, 424);
            this.grpCon.TabIndex = 24;
            this.grpCon.TabStop = false;
            this.grpCon.Text = "Connection";
            // 
            // tbIPaddr
            // 
            this.tbIPaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPaddr.Location = new System.Drawing.Point(89, 15);
            this.tbIPaddr.Name = "tbIPaddr";
            this.tbIPaddr.Size = new System.Drawing.Size(143, 20);
            this.tbIPaddr.TabIndex = 36;
            this.tbIPaddr.Text = "192.168.10.202";
            // 
            // lblCliLocaleIP
            // 
            this.lblCliLocaleIP.Location = new System.Drawing.Point(9, 76);
            this.lblCliLocaleIP.Name = "lblCliLocaleIP";
            this.lblCliLocaleIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliLocaleIP.Size = new System.Drawing.Size(73, 20);
            this.lblCliLocaleIP.TabIndex = 22;
            this.lblCliLocaleIP.Text = "Locale:";
            this.lblCliLocaleIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCliLocaleIP
            // 
            this.tbCliLocaleIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliLocaleIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCliLocaleIP.Location = new System.Drawing.Point(88, 76);
            this.tbCliLocaleIP.Name = "tbCliLocaleIP";
            this.tbCliLocaleIP.ReadOnly = true;
            this.tbCliLocaleIP.Size = new System.Drawing.Size(144, 20);
            this.tbCliLocaleIP.TabIndex = 23;
            this.tbCliLocaleIP.Text = "none";
            // 
            // lblCliRemoteIP
            // 
            this.lblCliRemoteIP.Location = new System.Drawing.Point(6, 100);
            this.lblCliRemoteIP.Name = "lblCliRemoteIP";
            this.lblCliRemoteIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliRemoteIP.Size = new System.Drawing.Size(76, 20);
            this.lblCliRemoteIP.TabIndex = 24;
            this.lblCliRemoteIP.Text = "Remote:";
            this.lblCliRemoteIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCliRemoteIP
            // 
            this.tbCliRemoteIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliRemoteIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCliRemoteIP.Location = new System.Drawing.Point(88, 100);
            this.tbCliRemoteIP.Name = "tbCliRemoteIP";
            this.tbCliRemoteIP.ReadOnly = true;
            this.tbCliRemoteIP.Size = new System.Drawing.Size(144, 20);
            this.tbCliRemoteIP.TabIndex = 25;
            this.tbCliRemoteIP.Text = "none";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(240, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 24);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSend
            // 
            this.grpSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSend.Location = new System.Drawing.Point(0, 124);
            this.grpSend.Name = "grpSend";
            this.grpSend.Size = new System.Drawing.Size(360, 5);
            this.grpSend.TabIndex = 20;
            this.grpSend.TabStop = false;
            // 
            // lblSendData
            // 
            this.lblSendData.Location = new System.Drawing.Point(8, 140);
            this.lblSendData.Name = "lblSendData";
            this.lblSendData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSendData.Size = new System.Drawing.Size(72, 20);
            this.lblSendData.TabIndex = 27;
            this.lblSendData.Text = "Data to send:";
            this.lblSendData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSendData
            // 
            this.cbSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSendData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendData.ItemHeight = 13;
            this.cbSendData.Location = new System.Drawing.Point(88, 140);
            this.cbSendData.Name = "cbSendData";
            this.cbSendData.Size = new System.Drawing.Size(208, 21);
            this.cbSendData.TabIndex = 28;
            // 
            // tbSendData
            // 
            this.tbSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendData.Location = new System.Drawing.Point(16, 164);
            this.tbSendData.Name = "tbSendData";
            this.tbSendData.Size = new System.Drawing.Size(280, 20);
            this.tbSendData.TabIndex = 29;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(296, 140);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 44);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listSend
            // 
            this.listSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSend.HorizontalScrollbar = true;
            this.listSend.IntegralHeight = false;
            this.listSend.Location = new System.Drawing.Point(16, 184);
            this.listSend.Name = "listSend";
            this.listSend.Size = new System.Drawing.Size(280, 88);
            this.listSend.TabIndex = 31;
            // 
            // btnSendClear
            // 
            this.btnSendClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendClear.Location = new System.Drawing.Point(296, 184);
            this.btnSendClear.Name = "btnSendClear";
            this.btnSendClear.Size = new System.Drawing.Size(48, 88);
            this.btnSendClear.TabIndex = 32;
            this.btnSendClear.Text = "Clear";
            this.btnSendClear.Click += new System.EventHandler(this.btnSendClear_Click);
            // 
            // grpRcv
            // 
            this.grpRcv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRcv.Location = new System.Drawing.Point(0, 280);
            this.grpRcv.Name = "grpRcv";
            this.grpRcv.Size = new System.Drawing.Size(360, 5);
            this.grpRcv.TabIndex = 21;
            this.grpRcv.TabStop = false;
            // 
            // lblRcvData
            // 
            this.lblRcvData.Location = new System.Drawing.Point(16, 292);
            this.lblRcvData.Name = "lblRcvData";
            this.lblRcvData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRcvData.Size = new System.Drawing.Size(328, 13);
            this.lblRcvData.TabIndex = 33;
            this.lblRcvData.Text = "Received data:";
            this.lblRcvData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listRcv
            // 
            this.listRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRcv.HorizontalScrollbar = true;
            this.listRcv.IntegralHeight = false;
            this.listRcv.Location = new System.Drawing.Point(16, 308);
            this.listRcv.Name = "listRcv";
            this.listRcv.Size = new System.Drawing.Size(280, 98);
            this.listRcv.TabIndex = 34;
            // 
            // btnRcvClear
            // 
            this.btnRcvClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRcvClear.Location = new System.Drawing.Point(296, 308);
            this.btnRcvClear.Name = "btnRcvClear";
            this.btnRcvClear.Size = new System.Drawing.Size(48, 98);
            this.btnRcvClear.TabIndex = 35;
            this.btnRcvClear.Text = "Clear";
            this.btnRcvClear.Click += new System.EventHandler(this.btnRcvClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 469);
            this.Controls.Add(this.grpCon);
            this.Controls.Add(this.checkAlwaysTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Socket Client";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinIPport)).EndInit();
            this.grpCon.ResumeLayout(false);
            this.grpCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAlwaysTop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblIPaddr;
        private System.Windows.Forms.NumericUpDown spinIPport;
        private System.Windows.Forms.Label lblIPport;
        private System.Windows.Forms.GroupBox grpCon;
        private System.Windows.Forms.Label lblCliLocaleIP;
        private System.Windows.Forms.TextBox tbCliLocaleIP;
        private System.Windows.Forms.Label lblCliRemoteIP;
        private System.Windows.Forms.TextBox tbCliRemoteIP;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.Label lblSendData;
        private System.Windows.Forms.ComboBox cbSendData;
        private System.Windows.Forms.TextBox tbSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listSend;
        private System.Windows.Forms.Button btnSendClear;
        private System.Windows.Forms.GroupBox grpRcv;
        private System.Windows.Forms.Label lblRcvData;
        private System.Windows.Forms.ListBox listRcv;
        private System.Windows.Forms.Button btnRcvClear;
        private System.Windows.Forms.TextBox tbIPaddr;
    }
}

