using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Pop3;
using Message = OpenPop.Mime.Message;
using System.Diagnostics;
using Setting = EmailClient.Properties.Settings;
using System.ComponentModel;

namespace EmailClient
{
    class POPClient
    {
        /* Function to retrive Email from the POP3 Server */
        public void GetAllMails(object sender, DoWorkEventArgs e)
        {
            int percentComplete;

            using(Pop3Client client = new Pop3Client())
            {
                /* Set the Server, Port, ssl and username/password */
                client.Connect(Setting.Default.pop3_server, Setting.Default.pop3_port, Setting.Default.smtp_ssl);
                client.Authenticate(Setting.Default.username, Setting.Default.password);

                int messageCount = client.GetMessageCount();

                Debug.WriteLine(messageCount);

                /* Create a list to contain the messages */
                List<Message> allMessages = new List<Message>();

                /* A loop to calculate the progress of retriving the Emails  */
                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                    percentComplete = Convert.ToInt16((Convert.ToDouble(allMessages.Count) / Convert.ToDouble(messageCount)) * 100);
                    (sender as BackgroundWorker).ReportProgress(percentComplete);
                }
                e.Result =  allMessages;
            }            
        
        }
    }
}
