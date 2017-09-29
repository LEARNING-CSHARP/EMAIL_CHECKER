namespace EMAIL_CHECKER
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.sendButton = new System.Windows.Forms.Button();
			this.senderEmailAddressTextBox = new System.Windows.Forms.TextBox();
			this.senderDisplayNameTextBox = new System.Windows.Forms.TextBox();
			this.senderEmailAddressLabel = new System.Windows.Forms.Label();
			this.senderDisplayNameLabel = new System.Windows.Forms.Label();
			this.recipientDisplayNameLabel = new System.Windows.Forms.Label();
			this.recipientEmailAddressLabel = new System.Windows.Forms.Label();
			this.recipientDisplayNameTextBox = new System.Windows.Forms.TextBox();
			this.recipientEmailAddressTextBox = new System.Windows.Forms.TextBox();
			this.subjectLabel = new System.Windows.Forms.Label();
			this.subjectTextBox = new System.Windows.Forms.TextBox();
			this.bodyLabel = new System.Windows.Forms.Label();
			this.bodyTextBox = new System.Windows.Forms.TextBox();
			this.enableSslCheckBox = new System.Windows.Forms.CheckBox();
			this.timeoutLabel = new System.Windows.Forms.Label();
			this.timeoutTextBox = new System.Windows.Forms.TextBox();
			this.hostLabel = new System.Windows.Forms.Label();
			this.hostTextBox = new System.Windows.Forms.TextBox();
			this.portLabel = new System.Windows.Forms.Label();
			this.portTextBox = new System.Windows.Forms.TextBox();
			this.smtpUsernameLabel = new System.Windows.Forms.Label();
			this.smtpUsernameTextBox = new System.Windows.Forms.TextBox();
			this.smtpPasswordLabel = new System.Windows.Forms.Label();
			this.smtpPasswordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// sendButton
			// 
			this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.sendButton.Location = new System.Drawing.Point(12, 418);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(75, 23);
			this.sendButton.TabIndex = 0;
			this.sendButton.Text = "&Send";
			this.sendButton.UseVisualStyleBackColor = true;
			this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
			// 
			// senderEmailAddressTextBox
			// 
			this.senderEmailAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.senderEmailAddressTextBox.Location = new System.Drawing.Point(150, 12);
			this.senderEmailAddressTextBox.Name = "senderEmailAddressTextBox";
			this.senderEmailAddressTextBox.Size = new System.Drawing.Size(257, 20);
			this.senderEmailAddressTextBox.TabIndex = 1;
			this.senderEmailAddressTextBox.Text = "csharp.expert.a@gmail.com";
			// 
			// senderDisplayNameTextBox
			// 
			this.senderDisplayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.senderDisplayNameTextBox.Location = new System.Drawing.Point(150, 38);
			this.senderDisplayNameTextBox.Name = "senderDisplayNameTextBox";
			this.senderDisplayNameTextBox.Size = new System.Drawing.Size(257, 20);
			this.senderDisplayNameTextBox.TabIndex = 2;
			this.senderDisplayNameTextBox.Text = "آقای داریوش تصدیقی";
			// 
			// senderEmailAddressLabel
			// 
			this.senderEmailAddressLabel.AutoSize = true;
			this.senderEmailAddressLabel.Location = new System.Drawing.Point(12, 15);
			this.senderEmailAddressLabel.Name = "senderEmailAddressLabel";
			this.senderEmailAddressLabel.Size = new System.Drawing.Size(110, 13);
			this.senderEmailAddressLabel.TabIndex = 3;
			this.senderEmailAddressLabel.Text = "Sender Email Address";
			// 
			// senderDisplayNameLabel
			// 
			this.senderDisplayNameLabel.AutoSize = true;
			this.senderDisplayNameLabel.Location = new System.Drawing.Point(12, 41);
			this.senderDisplayNameLabel.Name = "senderDisplayNameLabel";
			this.senderDisplayNameLabel.Size = new System.Drawing.Size(109, 13);
			this.senderDisplayNameLabel.TabIndex = 4;
			this.senderDisplayNameLabel.Text = "Sender Display Name";
			// 
			// recipientDisplayNameLabel
			// 
			this.recipientDisplayNameLabel.AutoSize = true;
			this.recipientDisplayNameLabel.Location = new System.Drawing.Point(12, 93);
			this.recipientDisplayNameLabel.Name = "recipientDisplayNameLabel";
			this.recipientDisplayNameLabel.Size = new System.Drawing.Size(120, 13);
			this.recipientDisplayNameLabel.TabIndex = 8;
			this.recipientDisplayNameLabel.Text = "Recipient Display Name";
			// 
			// recipientEmailAddressLabel
			// 
			this.recipientEmailAddressLabel.AutoSize = true;
			this.recipientEmailAddressLabel.Location = new System.Drawing.Point(12, 67);
			this.recipientEmailAddressLabel.Name = "recipientEmailAddressLabel";
			this.recipientEmailAddressLabel.Size = new System.Drawing.Size(121, 13);
			this.recipientEmailAddressLabel.TabIndex = 7;
			this.recipientEmailAddressLabel.Text = "Recipient Email Address";
			// 
			// recipientDisplayNameTextBox
			// 
			this.recipientDisplayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.recipientDisplayNameTextBox.Location = new System.Drawing.Point(150, 90);
			this.recipientDisplayNameTextBox.Name = "recipientDisplayNameTextBox";
			this.recipientDisplayNameTextBox.Size = new System.Drawing.Size(257, 20);
			this.recipientDisplayNameTextBox.TabIndex = 6;
			this.recipientDisplayNameTextBox.Text = "خانم ابتسام آخرتی";
			// 
			// recipientEmailAddressTextBox
			// 
			this.recipientEmailAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.recipientEmailAddressTextBox.Location = new System.Drawing.Point(150, 64);
			this.recipientEmailAddressTextBox.Name = "recipientEmailAddressTextBox";
			this.recipientEmailAddressTextBox.Size = new System.Drawing.Size(257, 20);
			this.recipientEmailAddressTextBox.TabIndex = 5;
			this.recipientEmailAddressTextBox.Text = "e.akherati@gmail.com";
			// 
			// subjectLabel
			// 
			this.subjectLabel.AutoSize = true;
			this.subjectLabel.Location = new System.Drawing.Point(12, 119);
			this.subjectLabel.Name = "subjectLabel";
			this.subjectLabel.Size = new System.Drawing.Size(43, 13);
			this.subjectLabel.TabIndex = 10;
			this.subjectLabel.Text = "Subject";
			// 
			// subjectTextBox
			// 
			this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.subjectTextBox.Location = new System.Drawing.Point(150, 116);
			this.subjectTextBox.Name = "subjectTextBox";
			this.subjectTextBox.Size = new System.Drawing.Size(257, 20);
			this.subjectTextBox.TabIndex = 9;
			this.subjectTextBox.Text = "موضوع تستی";
			// 
			// bodyLabel
			// 
			this.bodyLabel.AutoSize = true;
			this.bodyLabel.Location = new System.Drawing.Point(12, 145);
			this.bodyLabel.Name = "bodyLabel";
			this.bodyLabel.Size = new System.Drawing.Size(31, 13);
			this.bodyLabel.TabIndex = 12;
			this.bodyLabel.Text = "Body";
			// 
			// bodyTextBox
			// 
			this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bodyTextBox.Location = new System.Drawing.Point(150, 142);
			this.bodyTextBox.Multiline = true;
			this.bodyTextBox.Name = "bodyTextBox";
			this.bodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.bodyTextBox.Size = new System.Drawing.Size(257, 70);
			this.bodyTextBox.TabIndex = 11;
			this.bodyTextBox.Text = "متن تستی";
			// 
			// enableSslCheckBox
			// 
			this.enableSslCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.enableSslCheckBox.AutoSize = true;
			this.enableSslCheckBox.Checked = true;
			this.enableSslCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableSslCheckBox.Location = new System.Drawing.Point(12, 395);
			this.enableSslCheckBox.Name = "enableSslCheckBox";
			this.enableSslCheckBox.Size = new System.Drawing.Size(82, 17);
			this.enableSslCheckBox.TabIndex = 13;
			this.enableSslCheckBox.Text = "Enable SSL";
			this.enableSslCheckBox.UseVisualStyleBackColor = true;
			// 
			// timeoutLabel
			// 
			this.timeoutLabel.AutoSize = true;
			this.timeoutLabel.Location = new System.Drawing.Point(12, 221);
			this.timeoutLabel.Name = "timeoutLabel";
			this.timeoutLabel.Size = new System.Drawing.Size(45, 13);
			this.timeoutLabel.TabIndex = 15;
			this.timeoutLabel.Text = "Timeout";
			// 
			// timeoutTextBox
			// 
			this.timeoutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeoutTextBox.Location = new System.Drawing.Point(150, 218);
			this.timeoutTextBox.Name = "timeoutTextBox";
			this.timeoutTextBox.Size = new System.Drawing.Size(257, 20);
			this.timeoutTextBox.TabIndex = 14;
			this.timeoutTextBox.Text = "100000";
			// 
			// hostLabel
			// 
			this.hostLabel.AutoSize = true;
			this.hostLabel.Location = new System.Drawing.Point(12, 247);
			this.hostLabel.Name = "hostLabel";
			this.hostLabel.Size = new System.Drawing.Size(71, 13);
			this.hostLabel.TabIndex = 17;
			this.hostLabel.Text = "SMTP Server";
			// 
			// hostTextBox
			// 
			this.hostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hostTextBox.Location = new System.Drawing.Point(150, 244);
			this.hostTextBox.Name = "hostTextBox";
			this.hostTextBox.Size = new System.Drawing.Size(257, 20);
			this.hostTextBox.TabIndex = 16;
			this.hostTextBox.Text = "smtp.gmail.com";
			// 
			// portLabel
			// 
			this.portLabel.AutoSize = true;
			this.portLabel.Location = new System.Drawing.Point(12, 273);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size(93, 13);
			this.portLabel.TabIndex = 19;
			this.portLabel.Text = "SMTP Server Port";
			// 
			// portTextBox
			// 
			this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.portTextBox.Location = new System.Drawing.Point(150, 270);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(257, 20);
			this.portTextBox.TabIndex = 18;
			this.portTextBox.Text = "587";
			// 
			// smtpUsernameLabel
			// 
			this.smtpUsernameLabel.AutoSize = true;
			this.smtpUsernameLabel.Location = new System.Drawing.Point(12, 299);
			this.smtpUsernameLabel.Name = "smtpUsernameLabel";
			this.smtpUsernameLabel.Size = new System.Drawing.Size(88, 13);
			this.smtpUsernameLabel.TabIndex = 21;
			this.smtpUsernameLabel.Text = "SMTP Username";
			// 
			// smtpUsernameTextBox
			// 
			this.smtpUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.smtpUsernameTextBox.Location = new System.Drawing.Point(150, 296);
			this.smtpUsernameTextBox.Name = "smtpUsernameTextBox";
			this.smtpUsernameTextBox.Size = new System.Drawing.Size(257, 20);
			this.smtpUsernameTextBox.TabIndex = 20;
			this.smtpUsernameTextBox.Text = "csharp.expert.a@gmail.com";
			// 
			// smtpPasswordLabel
			// 
			this.smtpPasswordLabel.AutoSize = true;
			this.smtpPasswordLabel.Location = new System.Drawing.Point(12, 325);
			this.smtpPasswordLabel.Name = "smtpPasswordLabel";
			this.smtpPasswordLabel.Size = new System.Drawing.Size(86, 13);
			this.smtpPasswordLabel.TabIndex = 23;
			this.smtpPasswordLabel.Text = "SMTP Password";
			// 
			// smtpPasswordTextBox
			// 
			this.smtpPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.smtpPasswordTextBox.Location = new System.Drawing.Point(150, 322);
			this.smtpPasswordTextBox.Name = "smtpPasswordTextBox";
			this.smtpPasswordTextBox.Size = new System.Drawing.Size(257, 20);
			this.smtpPasswordTextBox.TabIndex = 22;
			this.smtpPasswordTextBox.Text = "qwerty@123456";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 453);
			this.Controls.Add(this.smtpPasswordLabel);
			this.Controls.Add(this.smtpPasswordTextBox);
			this.Controls.Add(this.smtpUsernameLabel);
			this.Controls.Add(this.smtpUsernameTextBox);
			this.Controls.Add(this.portLabel);
			this.Controls.Add(this.portTextBox);
			this.Controls.Add(this.hostLabel);
			this.Controls.Add(this.hostTextBox);
			this.Controls.Add(this.timeoutLabel);
			this.Controls.Add(this.timeoutTextBox);
			this.Controls.Add(this.enableSslCheckBox);
			this.Controls.Add(this.bodyLabel);
			this.Controls.Add(this.bodyTextBox);
			this.Controls.Add(this.subjectLabel);
			this.Controls.Add(this.subjectTextBox);
			this.Controls.Add(this.recipientDisplayNameLabel);
			this.Controls.Add(this.recipientEmailAddressLabel);
			this.Controls.Add(this.recipientDisplayNameTextBox);
			this.Controls.Add(this.recipientEmailAddressTextBox);
			this.Controls.Add(this.senderDisplayNameLabel);
			this.Controls.Add(this.senderEmailAddressLabel);
			this.Controls.Add(this.senderDisplayNameTextBox);
			this.Controls.Add(this.senderEmailAddressTextBox);
			this.Controls.Add(this.sendButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email Checker";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.TextBox senderEmailAddressTextBox;
		private System.Windows.Forms.TextBox senderDisplayNameTextBox;
		private System.Windows.Forms.Label senderEmailAddressLabel;
		private System.Windows.Forms.Label senderDisplayNameLabel;
		private System.Windows.Forms.Label recipientDisplayNameLabel;
		private System.Windows.Forms.Label recipientEmailAddressLabel;
		private System.Windows.Forms.TextBox recipientDisplayNameTextBox;
		private System.Windows.Forms.TextBox recipientEmailAddressTextBox;
		private System.Windows.Forms.Label subjectLabel;
		private System.Windows.Forms.TextBox subjectTextBox;
		private System.Windows.Forms.Label bodyLabel;
		private System.Windows.Forms.TextBox bodyTextBox;
		private System.Windows.Forms.CheckBox enableSslCheckBox;
		private System.Windows.Forms.Label timeoutLabel;
		private System.Windows.Forms.TextBox timeoutTextBox;
		private System.Windows.Forms.Label hostLabel;
		private System.Windows.Forms.TextBox hostTextBox;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.TextBox portTextBox;
		private System.Windows.Forms.Label smtpUsernameLabel;
		private System.Windows.Forms.TextBox smtpUsernameTextBox;
		private System.Windows.Forms.Label smtpPasswordLabel;
		private System.Windows.Forms.TextBox smtpPasswordTextBox;
	}
}
