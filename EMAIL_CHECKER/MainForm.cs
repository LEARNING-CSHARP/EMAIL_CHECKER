namespace EMAIL_CHECKER
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}

		private void sendButton_Click(object sender, System.EventArgs e)
		{
			System.Net.Mail.SmtpClient oSmtpClient = null;
			System.Net.Mail.MailMessage oMailMessage = null;

			try
			{
				oMailMessage =
					new System.Net.Mail.MailMessage();

				oMailMessage.To.Clear();
				oMailMessage.CC.Clear();
				oMailMessage.Bcc.Clear();
				oMailMessage.ReplyToList.Clear();
				oMailMessage.Attachments.Clear();

				System.Net.Mail.MailAddress oSender = null;

				if (string.IsNullOrWhiteSpace(senderDisplayNameTextBox.Text))
				{
					oSender =
						new System.Net.Mail.MailAddress(address: senderEmailAddressTextBox.Text);
				}
				else
				{
					oSender =
						new System.Net.Mail.MailAddress
							(address: senderEmailAddressTextBox.Text,
							displayName: senderDisplayNameTextBox.Text,
							displayNameEncoding: System.Text.Encoding.UTF8);
				}

				oMailMessage.From = oSender;
				oMailMessage.Sender = oSender;
				oMailMessage.ReplyToList.Add(oSender);

				System.Net.Mail.MailAddress oRecipient = null;

				if (string.IsNullOrWhiteSpace(recipientDisplayNameTextBox.Text))
				{
					oRecipient =
						new System.Net.Mail.MailAddress(address: recipientEmailAddressTextBox.Text);
				}
				else
				{
					oRecipient =
						new System.Net.Mail.MailAddress
							(address: recipientEmailAddressTextBox.Text,
							displayName: recipientDisplayNameTextBox.Text,
							displayNameEncoding: System.Text.Encoding.UTF8);
				}

				oMailMessage.To.Add(oRecipient);

				oMailMessage.Subject = subjectTextBox.Text;
				oMailMessage.SubjectEncoding = System.Text.Encoding.UTF8;

				oMailMessage.IsBodyHtml = true;
				oMailMessage.Body = bodyTextBox.Text;
				oMailMessage.BodyEncoding = System.Text.Encoding.UTF8;
				//oMailMessage.BodyTransferEncoding = System.Net.Mime.TransferEncoding.Base64;

				oMailMessage.Priority = System.Net.Mail.MailPriority.Normal;
				oMailMessage.DeliveryNotificationOptions =
					System.Net.Mail.DeliveryNotificationOptions.Delay |
					System.Net.Mail.DeliveryNotificationOptions.OnFailure |
					System.Net.Mail.DeliveryNotificationOptions.OnSuccess;

				oMailMessage.HeadersEncoding = System.Text.Encoding.UTF8;

				oMailMessage.Headers.Add("Dtx_Mailer_Version", "4.4");
				oMailMessage.Headers.Add("Dtx_Mailer_Date", "2013/06/20");
				oMailMessage.Headers.Add("Dtx_Mailer_Author", "Mr. Dariush Tasdighi");
				oMailMessage.Headers.Add("Dtx_Mailer_Company", "www.IranianExperts.ir");

				oSmtpClient =
					new System.Net.Mail.SmtpClient();

				oSmtpClient.EnableSsl = enableSslCheckBox.Checked;

				oSmtpClient.Timeout =
					System.Convert.ToInt32(timeoutTextBox.Text);

				oSmtpClient.DeliveryMethod =
					System.Net.Mail.SmtpDeliveryMethod.Network;

				oSmtpClient.Host = hostTextBox.Text;

				oSmtpClient.Port =
					System.Convert.ToInt32(portTextBox.Text);

				oSmtpClient.UseDefaultCredentials = false;

				System.Net.NetworkCredential oNetworkCredential =
					new System.Net.NetworkCredential
						(userName: smtpUsernameTextBox.Text, password: smtpPasswordTextBox.Text);

				oSmtpClient.Credentials = oNetworkCredential;

				oSmtpClient.Send(oMailMessage);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (oSmtpClient != null)
				{
					oSmtpClient.Dispose();
					oSmtpClient = null;
				}

				if (oMailMessage != null)
				{
					oMailMessage.Dispose();
					oMailMessage = null;
				}
			}
		}
	}
}
