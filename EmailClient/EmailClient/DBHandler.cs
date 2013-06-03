using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Setting = EmailClient.Properties.Settings;
using System.Diagnostics;
using Message = OpenPop.Mime.Message;

namespace EmailClient
{
    /* Class to handle all communication with the SQLite database */
    class DBHandler
    {
        public static SQLiteConnection DbConn;

        /* Function to connect to the database and create the database and tables if it does not allready excist. */
        public DBHandler()
        {
            /* Connection string and commands to create the database + table. */
            DbConn = new SQLiteConnection("Data source=" + Setting.Default.db_file_name + ";Version=3;");
            string sql = "CREATE TABLE IF NOT EXISTS mailInbox (mailid INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                "sender NVARCHAR(100) NOT NULL, " +
                "recipient NVARCHAR(100) NOT NULL, " +
                "bc NVARCHAR(100), " +
                "cc NVARCHAR(100), " +
                "subject NVARCHAR(500), " +
                "message NVARCHAR(500), " +
                "datetime text," +
                "attachment blob);";
            Debug.WriteLine(sql);
           
            /* Try/catch statment to connect to the database and run the above commands. */
            try
            {
                DbConn.Open();
                Debug.WriteLine("Trying to connect to DB");
                SQLiteCommand cmd = new SQLiteCommand(sql, DbConn);
                cmd.ExecuteNonQuery();
    
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception");
                Debug.WriteLine(ex.Message);
            }   
                       
        }

        /* Function to retrive mails from pop3 and insert the data into the database. */
        public void InsertMail(Message mail)
        {
            /* Variable containing the SQLite commands needed to insert the data into the database */
            Debug.WriteLine("Insert mail to DB");
            string sql = "INSERT INTO mailInbox (sender,recipient,bc,cc,subject,message,datetime) " +
                "VALUES (@sender,@recipient,@bc,@cc,@subject,@message,@datetime)";

            /* Variables created to contain data from the pop3/"real" mail. */
            string message;
            string sender = mail.Headers.From.ToString();
            string recipient = String.Join(",", mail.Headers.To);
            string bc = String.Join(",", mail.Headers.Bcc);
            string cc = String.Join(",", mail.Headers.Cc);
            string subject =  mail.Headers.Subject;
            DateTime datetime = mail.Headers.DateSent;
            Debug.WriteLine(datetime);

            /* check if the mail message if multilined. */
            if (!mail.MessagePart.IsMultiPart)
            {
                message = mail.MessagePart.GetBodyAsText();
            }
            else
            {
                OpenPop.Mime.MessagePart plainText = mail.FindFirstPlainTextVersion();
                message = plainText.GetBodyAsText();
            }

            /* Debug output */
           //Debug.WriteLine("Sender: " + sender);
           //Debug.WriteLine("Recipient: " + recipient);
           //Debug.WriteLine("Bc: " + bc);
           //Debug.WriteLine("Cc: " + cc);
           //Debug.WriteLine("Subject: " + subject);
           //Debug.WriteLine("Message: " + message);

            /* SQLite Commands to insert the data from the variables into the database */
            SQLiteCommand cmd = new SQLiteCommand(sql, DbConn);
            cmd.Parameters.AddWithValue("@sender", sender);
            cmd.Parameters.AddWithValue("@recipient", recipient);
            cmd.Parameters.AddWithValue("@bc", bc);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@datetime", datetime);
            //cmd.Parameters.AddWithValue("@attachment", mail.MessagePart.FileName);
            cmd.ExecuteNonQuery();
        }

        /* Function to retrive data from the database and insert it into a datatable */
        public DataTable GetAllSendersSubjects()
        {
            /* Create the table, define the SQLite command and connect to the database */
            DataTable SenderSubject = new DataTable();
            
            SenderSubject.Columns.Add("Mail-ID",typeof(int));
            SenderSubject.Columns.Add("From", typeof(string));
            SenderSubject.Columns.Add("Subject", typeof(string));
            SenderSubject.Columns.Add("Date", typeof(DateTime));
            
            string sql = "SELECT mailid,sender,subject,datetime from mailInbox ORDER BY datetime DESC";
            
            SQLiteCommand cmd = new SQLiteCommand(sql, DbConn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                SenderSubject.Rows.Add();
                SenderSubject.Rows[SenderSubject.Rows.Count - 1]["Mail-ID"] = reader.GetInt32(0);  // Mail-ID
                SenderSubject.Rows[SenderSubject.Rows.Count - 1]["From"] = reader.GetString(1);    // Sender
                SenderSubject.Rows[SenderSubject.Rows.Count - 1]["Subject"] = reader.GetString(2); // Subject
                SenderSubject.Rows[SenderSubject.Rows.Count - 1]["Date"] = reader.GetDateTime(3); // Datetime
            }
            return SenderSubject;
        }

        /* Funtion to Extract mail message based on mailID from the database */
        public Dictionary<string, string> GetFullMailFromMailID(string mail_id)
        {
            Dictionary<string, string> FullMail = new Dictionary<string, string>();

            string sql = "SELECT sender,recipient,subject,message FROM mailInbox WHERE mailid=@mailid";
            
            /* Create new SQLite command based on the sql string above and the connection created in DBHandler */
            SQLiteCommand cmd = new SQLiteCommand(sql, DbConn);
            
            /* Replaceses the @mailid in the SELECT statment with the value in mail_id */
            cmd.Parameters.AddWithValue("@mailid", mail_id);
            
            Debug.WriteLine(cmd.CommandText.ToString());
            
            /*  */
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            /* adds a key and value to the Dictionary string */
            while (reader.Read())
            {
                FullMail.Add("sender", reader.GetString(0));
                FullMail.Add("recipient", reader.GetString(1));
                FullMail.Add("subject", reader.GetString(2));
                FullMail.Add("message", reader.GetString(3));
            }
            return FullMail;
        }
    }
}
