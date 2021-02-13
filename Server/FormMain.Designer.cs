namespace SocketServer
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
            this.spinIPport = new System.Windows.Forms.NumericUpDown();
            this.tbCliRemoteIP = new System.Windows.Forms.TextBox();
            this.tbCliLocaleIP = new System.Windows.Forms.TextBox();
            this.btnSrvClose = new System.Windows.Forms.Button();
            this.lblCliRemoteIP = new System.Windows.Forms.Label();
            this.tbIPaddr = new System.Windows.Forms.TextBox();
            this.lblCliLocaleIP = new System.Windows.Forms.Label();
            this.lblIPaddr = new System.Windows.Forms.Label();
            this.lblIPport = new System.Windows.Forms.Label();
            this.btnCliClose = new System.Windows.Forms.Button();
            this.btnSrvCreate = new System.Windows.Forms.Button();
            this.btnRcvClear = new System.Windows.Forms.Button();
            this.listRcv = new System.Windows.Forms.ListBox();
            this.btnSendClear = new System.Windows.Forms.Button();
            this.listSend = new System.Windows.Forms.ListBox();
            this.checkAlwaysTop = new System.Windows.Forms.CheckBox();
            this.tbSendData = new System.Windows.Forms.TextBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.lblSendData = new System.Windows.Forms.Label();
            this.cbSendData = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpRcv = new System.Windows.Forms.GroupBox();
            this.lblRcvData = new System.Windows.Forms.Label();
            this.grpServer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinIPport)).BeginInit();
            this.grpClient.SuspendLayout();
            this.grpServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinIPport
            // 
            this.spinIPport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinIPport.Location = new System.Drawing.Point(88, 16);
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
            // tbCliRemoteIP
            // 
            this.tbCliRemoteIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliRemoteIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCliRemoteIP.Location = new System.Drawing.Point(88, 40);
            this.tbCliRemoteIP.Name = "tbCliRemoteIP";
            this.tbCliRemoteIP.ReadOnly = true;
            this.tbCliRemoteIP.Size = new System.Drawing.Size(144, 20);
            this.tbCliRemoteIP.TabIndex = 9;
            this.tbCliRemoteIP.Text = "none";
            // 
            // tbCliLocaleIP
            // 
            this.tbCliLocaleIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliLocaleIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCliLocaleIP.Location = new System.Drawing.Point(88, 16);
            this.tbCliLocaleIP.Name = "tbCliLocaleIP";
            this.tbCliLocaleIP.ReadOnly = true;
            this.tbCliLocaleIP.Size = new System.Drawing.Size(144, 20);
            this.tbCliLocaleIP.TabIndex = 7;
            this.tbCliLocaleIP.Text = "none";
            // 
            // btnSrvClose
            // 
            this.btnSrvClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrvClose.Location = new System.Drawing.Point(240, 40);
            this.btnSrvClose.Name = "btnSrvClose";
            this.btnSrvClose.Size = new System.Drawing.Size(104, 24);
            this.btnSrvClose.TabIndex = 5;
            this.btnSrvClose.Text = "Close";
            this.btnSrvClose.Click += new System.EventHandler(this.btnSrvClose_Click);
            // 
            // lblCliRemoteIP
            // 
            this.lblCliRemoteIP.Location = new System.Drawing.Point(16, 40);
            this.lblCliRemoteIP.Name = "lblCliRemoteIP";
            this.lblCliRemoteIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliRemoteIP.Size = new System.Drawing.Size(64, 20);
            this.lblCliRemoteIP.TabIndex = 8;
            this.lblCliRemoteIP.Text = "Remote:";
            this.lblCliRemoteIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbIPaddr
            // 
            this.tbIPaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPaddr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbIPaddr.Location = new System.Drawing.Point(88, 42);
            this.tbIPaddr.Name = "tbIPaddr";
            this.tbIPaddr.ReadOnly = true;
            this.tbIPaddr.Size = new System.Drawing.Size(144, 20);
            this.tbIPaddr.TabIndex = 4;
            // 
            // lblCliLocaleIP
            // 
            this.lblCliLocaleIP.Location = new System.Drawing.Point(16, 16);
            this.lblCliLocaleIP.Name = "lblCliLocaleIP";
            this.lblCliLocaleIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliLocaleIP.Size = new System.Drawing.Size(64, 20);
            this.lblCliLocaleIP.TabIndex = 6;
            this.lblCliLocaleIP.Text = "Locale:";
            this.lblCliLocaleIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIPaddr
            // 
            this.lblIPaddr.Location = new System.Drawing.Point(16, 40);
            this.lblIPaddr.Name = "lblIPaddr";
            this.lblIPaddr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPaddr.Size = new System.Drawing.Size(64, 20);
            this.lblIPaddr.TabIndex = 3;
            this.lblIPaddr.Text = "Local IP:";
            this.lblIPaddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIPport
            // 
            this.lblIPport.Location = new System.Drawing.Point(16, 16);
            this.lblIPport.Name = "lblIPport";
            this.lblIPport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPport.Size = new System.Drawing.Size(64, 20);
            this.lblIPport.TabIndex = 0;
            this.lblIPport.Text = "Port#:";
            this.lblIPport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCliClose
            // 
            this.btnCliClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliClose.Location = new System.Drawing.Point(240, 24);
            this.btnCliClose.Name = "btnCliClose";
            this.btnCliClose.Size = new System.Drawing.Size(104, 24);
            this.btnCliClose.TabIndex = 10;
            this.btnCliClose.Text = "Close";
            this.btnCliClose.Click += new System.EventHandler(this.btnCliClose_Click);
            // 
            // btnSrvCreate
            // 
            this.btnSrvCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrvCreate.Location = new System.Drawing.Point(240, 16);
            this.btnSrvCreate.Name = "btnSrvCreate";
            this.btnSrvCreate.Size = new System.Drawing.Size(104, 24);
            this.btnSrvCreate.TabIndex = 2;
            this.btnSrvCreate.Text = "Create && Listen";
            this.btnSrvCreate.Click += new System.EventHandler(this.btnSrvCreate_Click);
            // 
            // btnRcvClear
            // 
            this.btnRcvClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRcvClear.Location = new System.Drawing.Point(296, 248);
            this.btnRcvClear.Name = "btnRcvClear";
            this.btnRcvClear.Size = new System.Drawing.Size(48, 84);
            this.btnRcvClear.TabIndex = 19;
            this.btnRcvClear.Text = "Clear";
            this.btnRcvClear.Click += new System.EventHandler(this.btnRcvClear_Click);
            // 
            // listRcv
            // 
            this.listRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRcv.HorizontalScrollbar = true;
            this.listRcv.IntegralHeight = false;
            this.listRcv.Location = new System.Drawing.Point(16, 248);
            this.listRcv.Name = "listRcv";
            this.listRcv.Size = new System.Drawing.Size(280, 84);
            this.listRcv.TabIndex = 18;
            // 
            // btnSendClear
            // 
            this.btnSendClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendClear.Location = new System.Drawing.Point(296, 124);
            this.btnSendClear.Name = "btnSendClear";
            this.btnSendClear.Size = new System.Drawing.Size(48, 88);
            this.btnSendClear.TabIndex = 16;
            this.btnSendClear.Text = "Clear";
            this.btnSendClear.Click += new System.EventHandler(this.btnSendClear_Click);
            // 
            // listSend
            // 
            this.listSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSend.HorizontalScrollbar = true;
            this.listSend.IntegralHeight = false;
            this.listSend.Location = new System.Drawing.Point(16, 124);
            this.listSend.Name = "listSend";
            this.listSend.Size = new System.Drawing.Size(280, 88);
            this.listSend.TabIndex = 15;
            // 
            // checkAlwaysTop
            // 
            this.checkAlwaysTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysTop.Location = new System.Drawing.Point(24, 438);
            this.checkAlwaysTop.Name = "checkAlwaysTop";
            this.checkAlwaysTop.Size = new System.Drawing.Size(272, 20);
            this.checkAlwaysTop.TabIndex = 23;
            this.checkAlwaysTop.Text = "always on the top";
            this.checkAlwaysTop.CheckedChanged += new System.EventHandler(this.checkAlwaysTop_CheckedChanged);
            // 
            // tbSendData
            // 
            this.tbSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendData.Location = new System.Drawing.Point(16, 104);
            this.tbSendData.Name = "tbSendData";
            this.tbSendData.Size = new System.Drawing.Size(280, 20);
            this.tbSendData.TabIndex = 13;
            // 
            // grpClient
            // 
            this.grpClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClient.Controls.Add(this.lblCliLocaleIP);
            this.grpClient.Controls.Add(this.tbCliLocaleIP);
            this.grpClient.Controls.Add(this.lblCliRemoteIP);
            this.grpClient.Controls.Add(this.tbCliRemoteIP);
            this.grpClient.Controls.Add(this.btnCliClose);
            this.grpClient.Controls.Add(this.grpSend);
            this.grpClient.Controls.Add(this.lblSendData);
            this.grpClient.Controls.Add(this.cbSendData);
            this.grpClient.Controls.Add(this.tbSendData);
            this.grpClient.Controls.Add(this.btnSend);
            this.grpClient.Controls.Add(this.listSend);
            this.grpClient.Controls.Add(this.btnSendClear);
            this.grpClient.Controls.Add(this.grpRcv);
            this.grpClient.Controls.Add(this.lblRcvData);
            this.grpClient.Controls.Add(this.listRcv);
            this.grpClient.Controls.Add(this.btnRcvClear);
            this.grpClient.Location = new System.Drawing.Point(8, 88);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(360, 344);
            this.grpClient.TabIndex = 22;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Connection - asynchronous client socket";
            // 
            // grpSend
            // 
            this.grpSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSend.Location = new System.Drawing.Point(0, 64);
            this.grpSend.Name = "grpSend";
            this.grpSend.Size = new System.Drawing.Size(360, 5);
            this.grpSend.TabIndex = 0;
            this.grpSend.TabStop = false;
            // 
            // lblSendData
            // 
            this.lblSendData.Location = new System.Drawing.Point(8, 80);
            this.lblSendData.Name = "lblSendData";
            this.lblSendData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSendData.Size = new System.Drawing.Size(72, 20);
            this.lblSendData.TabIndex = 11;
            this.lblSendData.Text = "Data to send:";
            this.lblSendData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSendData
            // 
            this.cbSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSendData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendData.ItemHeight = 13;
            this.cbSendData.Location = new System.Drawing.Point(88, 80);
            this.cbSendData.Name = "cbSendData";
            this.cbSendData.Size = new System.Drawing.Size(208, 21);
            this.cbSendData.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(296, 80);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 44);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grpRcv
            // 
            this.grpRcv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRcv.Location = new System.Drawing.Point(0, 220);
            this.grpRcv.Name = "grpRcv";
            this.grpRcv.Size = new System.Drawing.Size(360, 5);
            this.grpRcv.TabIndex = 1;
            this.grpRcv.TabStop = false;
            // 
            // lblRcvData
            // 
            this.lblRcvData.Location = new System.Drawing.Point(16, 232);
            this.lblRcvData.Name = "lblRcvData";
            this.lblRcvData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRcvData.Size = new System.Drawing.Size(336, 13);
            this.lblRcvData.TabIndex = 17;
            this.lblRcvData.Text = "Received data:";
            this.lblRcvData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpServer
            // 
            this.grpServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpServer.Controls.Add(this.lblIPport);
            this.grpServer.Controls.Add(this.spinIPport);
            this.grpServer.Controls.Add(this.lblIPaddr);
            this.grpServer.Controls.Add(this.tbIPaddr);
            this.grpServer.Controls.Add(this.btnSrvCreate);
            this.grpServer.Controls.Add(this.btnSrvClose);
            this.grpServer.Location = new System.Drawing.Point(8, 8);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(360, 72);
            this.grpServer.TabIndex = 21;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server socket";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 469);
            this.Controls.Add(this.grpServer);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.checkAlwaysTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Socket Server";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinIPport)).EndInit();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spinIPport;
        private System.Windows.Forms.TextBox tbCliRemoteIP;
        private System.Windows.Forms.TextBox tbCliLocaleIP;
        private System.Windows.Forms.Button btnSrvClose;
        private System.Windows.Forms.Label lblCliRemoteIP;
        private System.Windows.Forms.TextBox tbIPaddr;
        private System.Windows.Forms.Label lblCliLocaleIP;
        private System.Windows.Forms.Label lblIPaddr;
        private System.Windows.Forms.Label lblIPport;
        private System.Windows.Forms.Button btnCliClose;
        private System.Windows.Forms.Button btnSrvCreate;
        private System.Windows.Forms.Button btnRcvClear;
        private System.Windows.Forms.ListBox listRcv;
        private System.Windows.Forms.Button btnSendClear;
        private System.Windows.Forms.ListBox listSend;
        private System.Windows.Forms.CheckBox checkAlwaysTop;
        private System.Windows.Forms.TextBox tbSendData;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Label lblRcvData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbSendData;
        private System.Windows.Forms.Label lblSendData;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.GroupBox grpRcv;
        private System.Windows.Forms.GroupBox grpServer;
    }
}

