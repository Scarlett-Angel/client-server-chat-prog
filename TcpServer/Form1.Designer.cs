﻿namespace TcpServer
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
			this.startListnerButton = new System.Windows.Forms.Button();
			this.ipAddressTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.portTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.stopListnerButton = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startListnerButton
			// 
			this.startListnerButton.Location = new System.Drawing.Point(15, 97);
			this.startListnerButton.Name = "startListnerButton";
			this.startListnerButton.Size = new System.Drawing.Size(75, 23);
			this.startListnerButton.TabIndex = 0;
			this.startListnerButton.Text = "Start Listner";
			this.startListnerButton.UseVisualStyleBackColor = true;
			this.startListnerButton.Click += new System.EventHandler(this.startListnerButton_Click);
			// 
			// ipAddressTextbox
			// 
			this.ipAddressTextbox.Location = new System.Drawing.Point(75, 26);
			this.ipAddressTextbox.Name = "ipAddressTextbox";
			this.ipAddressTextbox.Size = new System.Drawing.Size(165, 20);
			this.ipAddressTextbox.TabIndex = 1;
			this.ipAddressTextbox.Text = "127.0.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "IpAddress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port";
			// 
			// portTextBox
			// 
			this.portTextBox.Location = new System.Drawing.Point(75, 62);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(74, 20);
			this.portTextBox.TabIndex = 3;
			this.portTextBox.Text = "8201";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(107, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Running";
			// 
			// stopListnerButton
			// 
			this.stopListnerButton.Location = new System.Drawing.Point(15, 126);
			this.stopListnerButton.Name = "stopListnerButton";
			this.stopListnerButton.Size = new System.Drawing.Size(75, 23);
			this.stopListnerButton.TabIndex = 6;
			this.stopListnerButton.Text = "Stop Listner";
			this.stopListnerButton.UseVisualStyleBackColor = true;
			this.stopListnerButton.Click += new System.EventHandler(this.stopListnerButton_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(18, 186);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(229, 225);
			this.listBox1.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Conencted Clients List";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 421);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.stopListnerButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.portTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ipAddressTextbox);
			this.Controls.Add(this.startListnerButton);
			this.Name = "Form1";
			this.Text = "Tcp/ip Server";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startListnerButton;
        private System.Windows.Forms.TextBox ipAddressTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopListnerButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}

