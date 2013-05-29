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

        public static void GetAllMails(object sender, DoWorkEventArgs e)
        {
            using(Pop3Client client = new Pop3Client())
            {
                client.Connect(Setting.Default.pop3_server, Setting.Default.pop3_port, Setting.Default.ssl);

                client.Authenticate(Setting.Default.username, Setting.Default.password);

                int messageCount = client.GetMessageCount();

                Debug.WriteLine(messageCount);

                List<Message> allMessages = new List<Message>();

                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                    Debug.WriteLine(client.GetMessage(i).MessagePart);
                }
                e.Result =  allMessages;
            }            
        
        }
    }
}
