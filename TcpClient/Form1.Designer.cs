namespace TcpClientProgram
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
			this.SendMsgButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.serveripTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.userNameTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.totextbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.messagebodytextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.portTextbox = new System.Windows.Forms.TextBox();
			this.showMyPresenceCheckBox = new System.Windows.Forms.CheckBox();
			this.onlineUsersListBox = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SendMsgButton
			// 
			this.SendMsgButton.Location = new System.Drawing.Point(286, 136);
			this.SendMsgButton.Name = "SendMsgButton";
			this.SendMsgButton.Size = new System.Drawing.Size(75, 23);
			this.SendMsgButton.TabIndex = 0;
			this.SendMsgButton.Text = "Send";
			this.SendMsgButton.UseVisualStyleBackColor = true;
			this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "UserName";
			// 
			// serveripTextbox
			// 
			this.serveripTextbox.Location = new System.Drawing.Point(88, 20);
			this.serveripTextbox.Name = "serveripTextbox";
			this.serveripTextbox.Size = new System.Drawing.Size(177, 20);
			this.serveripTextbox.TabIndex = 2;
			this.serveripTextbox.Text = "127.0.0.1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chat Server i.p";
			// 
			// ConnectButton
			// 
			this.ConnectButton.Location = new System.Drawing.Point(272, 53);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(75, 23);
			this.ConnectButton.TabIndex = 4;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// userNameTextbox
			// 
			this.userNameTextbox.Location = new System.Drawing.Point(88, 55);
			this.userNameTextbox.Name = "userNameTextbox";
			this.userNameTextbox.Size = new System.Drawing.Size(177, 20);
			this.userNameTextbox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "To :";
			// 
			// totextbox
			// 
			this.totextbox.Location = new System.Drawing.Point(78, 28);
			this.totextbox.Name = "totextbox";
			this.totextbox.Size = new System.Drawing.Size(139, 20);
			this.totextbox.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.messagebodytextbox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.SendMsgButton);
			this.groupBox1.Controls.Add(this.totextbox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 279);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 178);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ChatBox";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "(leave blank to send to all)";
			// 
			// messagebodytextbox
			// 
			this.messagebodytextbox.Location = new System.Drawing.Point(78, 54);
			this.messagebodytextbox.Multiline = true;
			this.messagebodytextbox.Name = "messagebodytextbox";
			this.messagebodytextbox.Size = new System.Drawing.Size(283, 72);
			this.messagebodytextbox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Message :";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 140);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(381, 121);
			this.listBox1.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "ChatLog";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(271, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Server Port";
			// 
			// portTextbox
			// 
			this.portTextbox.Location = new System.Drawing.Point(337, 21);
			this.portTextbox.Name = "portTextbox";
			this.portTextbox.Size = new System.Drawing.Size(68, 20);
			this.portTextbox.TabIndex = 12;
			this.portTextbox.Text = "8201";
			// 
			// showMyPresenceCheckBox
			// 
			this.showMyPresenceCheckBox.AutoSize = true;
			this.showMyPresenceCheckBox.Checked = true;
			this.showMyPresenceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showMyPresenceCheckBox.Location = new System.Drawing.Point(88, 82);
			this.showMyPresenceCheckBox.Name = "showMyPresenceCheckBox";
			this.showMyPresenceCheckBox.Size = new System.Drawing.Size(116, 17);
			this.showMyPresenceCheckBox.TabIndex = 16;
			this.showMyPresenceCheckBox.Text = "Show my presence";
			this.showMyPresenceCheckBox.UseVisualStyleBackColor = true;
			// 
			// onlineUsersListBox
			// 
			this.onlineUsersListBox.FormattingEnabled = true;
			this.onlineUsersListBox.Location = new System.Drawing.Point(422, 140);
			this.onlineUsersListBox.Margin = new System.Windows.Forms.Padding(2);
			this.onlineUsersListBox.Name = "onlineUsersListBox";
			this.onlineUsersListBox.Size = new System.Drawing.Size(152, 316);
			this.onlineUsersListBox.TabIndex = 17;
			this.onlineUsersListBox.DoubleClick += new System.EventHandler(this.onlineUsersListBox_DoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 475);
			this.Controls.Add(this.onlineUsersListBox);
			this.Controls.Add(this.showMyPresenceCheckBox);
			this.Controls.Add(this.portTextbox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.userNameTextbox);
			this.Controls.Add(this.ConnectButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.serveripTextbox);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Tcp Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serveripTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messagebodytextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox portTextbox;
		private System.Windows.Forms.CheckBox showMyPresenceCheckBox;
		private System.Windows.Forms.ListBox onlineUsersListBox;
		private System.Windows.Forms.Label label7;
    }
}

