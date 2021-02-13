namespace SocketResender
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
            if(disposing && (components != null))
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
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServerRemoteIP = new System.Windows.Forms.TextBox();
            this.btnServerRemoteClose = new System.Windows.Forms.Button();
            this.lblIPport = new System.Windows.Forms.Label();
            this.spinServerIPport = new System.Windows.Forms.NumericUpDown();
            this.lblIPaddr = new System.Windows.Forms.Label();
            this.tbServerIPaddr = new System.Windows.Forms.TextBox();
            this.btnServerCreate = new System.Windows.Forms.Button();
            this.btnServerClose = new System.Windows.Forms.Button();
            this.grpCon = new System.Windows.Forms.GroupBox();
            this.tbClientIPaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudClientIPPort = new System.Windows.Forms.NumericUpDown();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.lblCliLocaleIP = new System.Windows.Forms.Label();
            this.tbClientLocaleIP = new System.Windows.Forms.TextBox();
            this.btnClientLocaleClose = new System.Windows.Forms.Button();
            this.checkAlwaysTop = new System.Windows.Forms.CheckBox();
            this.grpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinServerIPport)).BeginInit();
            this.grpCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientIPPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grpServer
            // 
            this.grpServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpServer.Controls.Add(this.label4);
            this.grpServer.Controls.Add(this.tbServerRemoteIP);
            this.grpServer.Controls.Add(this.btnServerRemoteClose);
            this.grpServer.Controls.Add(this.lblIPport);
            this.grpServer.Controls.Add(this.spinServerIPport);
            this.grpServer.Controls.Add(this.lblIPaddr);
            this.grpServer.Controls.Add(this.tbServerIPaddr);
            this.grpServer.Controls.Add(this.btnServerCreate);
            this.grpServer.Controls.Add(this.btnServerClose);
            this.grpServer.Location = new System.Drawing.Point(8, 8);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(360, 134);
            this.grpServer.TabIndex = 22;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Remote:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbServerRemoteIP
            // 
            this.tbServerRemoteIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServerRemoteIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbServerRemoteIP.Location = new System.Drawing.Point(89, 84);
            this.tbServerRemoteIP.Name = "tbServerRemoteIP";
            this.tbServerRemoteIP.ReadOnly = true;
            this.tbServerRemoteIP.Size = new System.Drawing.Size(144, 20);
            this.tbServerRemoteIP.TabIndex = 14;
            this.tbServerRemoteIP.Text = "none";
            // 
            // btnServerRemoteClose
            // 
            this.btnServerRemoteClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerRemoteClose.Location = new System.Drawing.Point(241, 84);
            this.btnServerRemoteClose.Name = "btnServerRemoteClose";
            this.btnServerRemoteClose.Size = new System.Drawing.Size(104, 24);
            this.btnServerRemoteClose.TabIndex = 15;
            this.btnServerRemoteClose.Text = "Close";
            this.btnServerRemoteClose.Click += new System.EventHandler(this.btnServerRemoteClose_Click);
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
            // spinServerIPport
            // 
            this.spinServerIPport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinServerIPport.Location = new System.Drawing.Point(88, 16);
            this.spinServerIPport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.spinServerIPport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinServerIPport.Name = "spinServerIPport";
            this.spinServerIPport.Size = new System.Drawing.Size(144, 20);
            this.spinServerIPport.TabIndex = 0;
            this.spinServerIPport.Value = new decimal(new int[] {
            899,
            0,
            0,
            0});
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
            // tbServerIPaddr
            // 
            this.tbServerIPaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServerIPaddr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbServerIPaddr.Location = new System.Drawing.Point(88, 42);
            this.tbServerIPaddr.Name = "tbServerIPaddr";
            this.tbServerIPaddr.ReadOnly = true;
            this.tbServerIPaddr.Size = new System.Drawing.Size(144, 20);
            this.tbServerIPaddr.TabIndex = 4;
            // 
            // btnServerCreate
            // 
            this.btnServerCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerCreate.Location = new System.Drawing.Point(240, 16);
            this.btnServerCreate.Name = "btnServerCreate";
            this.btnServerCreate.Size = new System.Drawing.Size(104, 24);
            this.btnServerCreate.TabIndex = 2;
            this.btnServerCreate.Text = "Create && Listen";
            this.btnServerCreate.Click += new System.EventHandler(this.btnServerCreate_Click);
            // 
            // btnServerClose
            // 
            this.btnServerClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerClose.Location = new System.Drawing.Point(240, 40);
            this.btnServerClose.Name = "btnServerClose";
            this.btnServerClose.Size = new System.Drawing.Size(104, 24);
            this.btnServerClose.TabIndex = 5;
            this.btnServerClose.Text = "Close";
            this.btnServerClose.Click += new System.EventHandler(this.btnServerClose_Click);
            // 
            // grpCon
            // 
            this.grpCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCon.Controls.Add(this.tbClientIPaddr);
            this.grpCon.Controls.Add(this.label1);
            this.grpCon.Controls.Add(this.label2);
            this.grpCon.Controls.Add(this.nudClientIPPort);
            this.grpCon.Controls.Add(this.btnClientConnect);
            this.grpCon.Controls.Add(this.lblCliLocaleIP);
            this.grpCon.Controls.Add(this.tbClientLocaleIP);
            this.grpCon.Controls.Add(this.btnClientLocaleClose);
            this.grpCon.Location = new System.Drawing.Point(8, 132);
            this.grpCon.Name = "grpCon";
            this.grpCon.Size = new System.Drawing.Size(360, 139);
            this.grpCon.TabIndex = 25;
            this.grpCon.TabStop = false;
            this.grpCon.Text = "Client";
            // 
            // tbClientIPaddr
            // 
            this.tbClientIPaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientIPaddr.Location = new System.Drawing.Point(89, 15);
            this.tbClientIPaddr.Name = "tbClientIPaddr";
            this.tbClientIPaddr.Size = new System.Drawing.Size(143, 20);
            this.tbClientIPaddr.TabIndex = 36;
            this.tbClientIPaddr.Text = "192.168.10.215";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port #:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudClientIPPort
            // 
            this.nudClientIPPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudClientIPPort.Location = new System.Drawing.Point(88, 42);
            this.nudClientIPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudClientIPPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClientIPPort.Name = "nudClientIPPort";
            this.nudClientIPPort.Size = new System.Drawing.Size(144, 20);
            this.nudClientIPPort.TabIndex = 0;
            this.nudClientIPPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientConnect.Location = new System.Drawing.Point(240, 28);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(104, 24);
            this.btnClientConnect.TabIndex = 2;
            this.btnClientConnect.Text = "Connect";
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // lblCliLocaleIP
            // 
            this.lblCliLocaleIP.Location = new System.Drawing.Point(7, 88);
            this.lblCliLocaleIP.Name = "lblCliLocaleIP";
            this.lblCliLocaleIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliLocaleIP.Size = new System.Drawing.Size(76, 20);
            this.lblCliLocaleIP.TabIndex = 24;
            this.lblCliLocaleIP.Text = "Locale:";
            this.lblCliLocaleIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbClientLocaleIP
            // 
            this.tbClientLocaleIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientLocaleIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbClientLocaleIP.Location = new System.Drawing.Point(89, 88);
            this.tbClientLocaleIP.Name = "tbClientLocaleIP";
            this.tbClientLocaleIP.ReadOnly = true;
            this.tbClientLocaleIP.Size = new System.Drawing.Size(144, 20);
            this.tbClientLocaleIP.TabIndex = 25;
            this.tbClientLocaleIP.Text = "none";
            // 
            // btnClientLocaleClose
            // 
            this.btnClientLocaleClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientLocaleClose.Location = new System.Drawing.Point(240, 85);
            this.btnClientLocaleClose.Name = "btnClientLocaleClose";
            this.btnClientLocaleClose.Size = new System.Drawing.Size(104, 24);
            this.btnClientLocaleClose.TabIndex = 26;
            this.btnClientLocaleClose.Text = "Close";
            this.btnClientLocaleClose.Click += new System.EventHandler(this.btnClientRemoteClose_Click);
            // 
            // checkAlwaysTop
            // 
            this.checkAlwaysTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysTop.Location = new System.Drawing.Point(8, 283);
            this.checkAlwaysTop.Name = "checkAlwaysTop";
            this.checkAlwaysTop.Size = new System.Drawing.Size(272, 20);
            this.checkAlwaysTop.TabIndex = 26;
            this.checkAlwaysTop.Text = "always on the top";
            this.checkAlwaysTop.CheckedChanged += new System.EventHandler(this.checkAlwaysTop_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 315);
            this.Controls.Add(this.checkAlwaysTop);
            this.Controls.Add(this.grpCon);
            this.Controls.Add(this.grpServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 350);
            this.Name = "FormMain";
            this.Text = "Socket resender";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinServerIPport)).EndInit();
            this.grpCon.ResumeLayout(false);
            this.grpCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientIPPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Label lblIPport;
        private System.Windows.Forms.NumericUpDown spinServerIPport;
        private System.Windows.Forms.Label lblIPaddr;
        private System.Windows.Forms.TextBox tbServerIPaddr;
        private System.Windows.Forms.Button btnServerCreate;
        private System.Windows.Forms.Button btnServerClose;
        private System.Windows.Forms.GroupBox grpCon;
        private System.Windows.Forms.TextBox tbClientIPaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudClientIPPort;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.Label lblCliLocaleIP;
        private System.Windows.Forms.TextBox tbClientLocaleIP;
        private System.Windows.Forms.Button btnClientLocaleClose;
        private System.Windows.Forms.CheckBox checkAlwaysTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServerRemoteIP;
        private System.Windows.Forms.Button btnServerRemoteClose;

    }
}

