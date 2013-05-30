using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = OpenPop.Mime.Message;
using OpenPop;
using System.Diagnostics;


namespace EmailClient
{
    public partial class Form1 : Form
    {
        string ActiveWindow;
        DataTable table;
        DBHandler dbHandler;
        ShowMail ShowMailWindow;
        EmailConfiguration ConfigWindow;
        Dictionary<string, string> MailContent;
        private BackgroundWorker worker;

        public Form1()
        {
            this.Load += Form1_Load;
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(POPClient.GetAllMails);
            worker.ProgressChanged += new ProgressChangedEventHandler(WorkerProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerRunCompleted);

            dbHandler = new DBHandler();

        }
        void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Super Mail Klient by Mathias & Nicolai";

        }
        
        private void inbox_btn_Click(object sender, EventArgs e)
        {
            Mail_Groupbox.Visible = false;
            inboxDataGridView.Visible = true;

            ActiveWindow = "inbox";
            /* Load empty table and do UI optimization*/
            table = new DataTable();
            table.Columns.Add("Mail-ID", typeof(int));
            table.Columns.Add("From", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            inboxDataGridView.DataSource = table;
            inboxDataGridView.RowHeadersVisible = false;
            inboxDataGridView.Columns["Mail-ID"].Visible = false;
            inboxDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            /* Get all Subjects and Senders from DB */
            inboxDataGridView.DataSource = dbHandler.GetAllSendersSubjects();
        }

        private void WorkerRunCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<Message> mails = new List<Message>();
            mails = (List<Message>)e.Result;
            DBHandler dbh = new DBHandler();
            foreach (Message mail in mails)
            {
                dbh.InsertMail(mail);
            }
            StripProgressBar.Value = 0;
            if (ActiveWindow == "inbox")
            {
                //dbHandler = new DBHandler();
                inboxDataGridView.DataSource = dbHandler.GetAllSendersSubjects();
            }
        }

        private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StripProgressBar.Value = e.ProgressPercentage;
        }

        private void Retrieve_btn_Click(object sender, EventArgs e)
        {

            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void inboxDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            Debug.WriteLine("Current Row: " + e.RowIndex.ToString());
            Debug.WriteLine("Mail-ID: " + inboxDataGridView.Rows[e.RowIndex].Cells["Mail-ID"].FormattedValue.ToString());
            string mail_id = inboxDataGridView.Rows[e.RowIndex].Cells["Mail-ID"].FormattedValue.ToString();
            
            MailContent = new Dictionary<string,string>();
            //dbHandler = new DBHandler();

            MailContent = dbHandler.GetFullMailFromMailID(mail_id);
            ShowMailWindow = new ShowMail(MailContent["recipient"],MailContent["sender"], MailContent["subject"],MailContent["message"]);
            ShowMailWindow.Show();

        }

        private void newMail_btn_Click(object sender, EventArgs e)
        {
            Mail_Groupbox.Visible = true;
            inboxDataGridView.Visible = false;
        }
     
        private void ClearStatus(object sender, MouseEventArgs e)
        {
            StripStatusLabel.Text = string.Empty;
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            bool flag = SMTPClient.Send(To_textbox.Text, Subject_textbox.Text, Message_textbox.Text, this.checkBoxEncrypt.Checked);
            if (flag == true)
            {
                StripStatusLabel.Text = "Sucess ! 1 Email send from the nr 1 email client"; 
                To_textbox.Text = string.Empty;
                Subject_textbox.Text = string.Empty;
                Message_textbox.Text = string.Empty;
            }
            else
            {
                StripStatusLabel.Text = "Error ! you fucked up.. sorry...";
            }
        }

        private void emailConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigWindow = new EmailConfiguration();
            ConfigWindow.Show();
        }
 

    }
}
