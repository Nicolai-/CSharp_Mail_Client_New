using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Setting = EmailClient.Properties.Settings;
using System.Diagnostics;
using System.ComponentModel;

namespace EmailClient
{
    class SMTPClient
    {
        public void Send(object sender, DoWorkEventArgs e)
        {
            List<object> generic = e.Argument as List<object>;
            bool flag = true;
            SmtpClient Client = new SmtpClient(Setting.Default.smtp_server, Setting.Default.smtp_port);
            Client.Credentials = new NetworkCredential(Setting.Default.username, Setting.Default.password);
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(Setting.Default.username, Setting.Default.sender_name);
            msg.To.Add(new MailAddress(Convert.ToString(generic[0])));
            msg.Subject = Convert.ToString(generic[1]);
            string rawmsg = Convert.ToString(generic[2]);
            Debug.WriteLine("Message: " + rawmsg);
            if (Convert.ToBoolean(generic[3]))
            {
                msg.Body = Crypto.EncryptStringAES(rawmsg, Setting.Default.aes_key);
                Debug.WriteLine("Encrypted: " + msg.Body);
            }
            else
            {
                msg.Body = rawmsg;
            }
            
            Client.EnableSsl = Setting.Default.smtp_ssl;
            try
            {
                Client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
                flag = false;
            }
            e.Result = flag;
        }
    }
}
