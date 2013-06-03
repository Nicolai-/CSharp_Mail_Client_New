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
using System.Globalization;


namespace EmailClient
{
    public partial class MailClient : Form
    {
        private BackgroundWorker POP3Worker;
        private BackgroundWorker SMTPWorker;

        DataTable table;
        DBHandler dbHandler;
        ShowMail ShowMailWindow;
        EmailConfiguration ConfigWindow;
        Dictionary<string, string> MailContent;

        POPClient pop3;
        SMTPClient smtp;

        public MailClient()
        {
            this.Load += MailClient_Load;
            InitializeComponent();
            pop3 = new POPClient();
            smtp = new SMTPClient();
            dbHandler = new DBHandler();

            POP3Worker = new BackgroundWorker();
            POP3Worker.WorkerReportsProgress = true;
            POP3Worker.DoWork += new DoWorkEventHandler(pop3.GetAllMails);
            POP3Worker.ProgressChanged += new ProgressChangedEventHandler(WorkerProgressChanged);
            POP3Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerRunCompleted);

            SMTPWorker = new BackgroundWorker();
            SMTPWorker.DoWork += new DoWorkEventHandler(smtp.Send);
            SMTPWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(sendWorkerRunCompleted);
        }

        /* Event to happen when the form1 is loaded */                                                                             
        void MailClient_Load(object sender, EventArgs e)
        {
            /* Set the window text */
        }
        
        /* Events to execute when the "indbox" button is clicked */
        private void inbox_btn_Click(object sender, EventArgs e)
        {
            /* Hide the Mail groupbox and show the inbox gridview */
            Mail_Groupbox.Visible = false;
            inboxDataGridView.Visible = true;

            /* Load empty table and do UI optimization */
            table = new DataTable();
            table.Columns.Add("Mail-ID", typeof(int));
            table.Columns.Add("From", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Date", typeof(string));
            inboxDataGridView.DataSource = table;
            inboxDataGridView.RowHeadersVisible = false;
            inboxDataGridView.Columns["Mail-ID"].Visible = false;
            inboxDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            /* Get all Subjects and Senders from DB */
            inboxDataGridView.DataSource = dbHandler.GetAllSendersSubjects();
        }

        /* Events to execute when ProgressChanged has been completed */
        private void WorkerRunCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            /* Create a new list and insert the values e.result from RunWorkerAsync*/
            List<Message> mails = new List<Message>();
            mails = (List<Message>)e.Result;
            
            /* for each mail run the insertmail function */
            foreach (Message mail in mails)
            {
                dbHandler.InsertMail(mail);
            }

            /* Reset the progressbar to 0 */
            StripProgressBar.Value = 0;

            /* insert data into the datagridview */
            inboxDataGridView.DataSource = dbHandler.GetAllSendersSubjects();
        }

        /* Events to execute when the progress in the backgroundworker is changed */
        private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /* sets the progressbar to the result from ProgressPercentage */
            StripProgressBar.Value = e.ProgressPercentage;
        }

        /* Events to execute when the "retrive" button is clicked */
        private void Retrieve_btn_Click(object sender, EventArgs e)
        {
            /* runs worker.RunWorkerAsync if the worker is NOT busy */
            if (!POP3Worker.IsBusy)
            {
                POP3Worker.RunWorkerAsync();
            }
        }

        /* Events to execute when a cell in "indox" is doubleclicked */                                                        
        private void inboxDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* If statment to check to see if you did not click on a vaild cell */
            if (e.RowIndex == -1)
            {
                return;
            }
            Debug.WriteLine("Current Row: " + e.RowIndex.ToString());
            Debug.WriteLine("Mail-ID: " + inboxDataGridView.Rows[e.RowIndex].Cells["Mail-ID"].FormattedValue.ToString());
            
            /* Finds the hidden MailID */
            string mail_id = inboxDataGridView.Rows[e.RowIndex].Cells["Mail-ID"].FormattedValue.ToString();
            
            /* Create a new Dictionary and add the full mail based on the MailID */
            MailContent = new Dictionary<string,string>();
            MailContent = dbHandler.GetFullMailFromMailID(mail_id);
           
            /* create a new instance of ShowMail and send the information to be shown */
            ShowMailWindow = new ShowMail(MailContent["recipient"],MailContent["sender"], MailContent["subject"],MailContent["message"]);
            ShowMailWindow.Show();

        }

        /* Events to execute when the "New" button is clicked */
        private void newMail_btn_Click(object sender, EventArgs e)
        {
            /* Makes the mail_Groupbox visible and hides the indboxDataGridView */
            Mail_Groupbox.Visible = true;
            inboxDataGridView.Visible = false;
        }
        
        /* Function to clear the status strip */
        private void ClearStatus(object sender, MouseEventArgs e)
        {
            /* Sets the text in StripStatusLabel to empty */
            StripStatusLabel.Text = string.Empty;
        }

        /* Events to execute when the send button is clicked */
        private void Send_Button_Click(object sender, EventArgs e)
        {
            /* Create a list with the content besed on the textboxes and checkbox on the mail form */
            List<object> arguments = new List<object>();
            arguments.Add(To_textbox.Text);
            arguments.Add(Subject_textbox.Text);
            arguments.Add(Message_textbox.Text);
            arguments.Add(this.checkBoxEncrypt.Checked);

            /* If senderworker is NOT busy set the text in StripstatusLable and run senderworker.runworkerasync(); */
            if (!SMTPWorker.IsBusy)
            {
                StripStatusLabel.Text = "Sending Email...";
                SMTPWorker.RunWorkerAsync(arguments);
            }
        }

        /* Events to execute when the background worker is complete */
        private void sendWorkerRunCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            /* Converts the result to a boolean */
            bool flag = Convert.ToBoolean(e.Result);

            /* If the Result is true */
            if (flag == true)
            {
                /* Set the text in StripStatusLabel, To_textbox, Subject_textbox and Message_textbox */
                StripStatusLabel.Text = "Sucess ! Email Sent...";
                To_textbox.Text = string.Empty;
                Subject_textbox.Text = string.Empty;
                Message_textbox.Text = string.Empty;
                /* Set the encryption checkbox to unchecked */
                checkBoxEncrypt.Checked = false;
            }

            /* If the result is falsh */
            else
            {
                /* Set the text in StripStatusLabel */
                StripStatusLabel.Text = "Error ! you fucked up.. sorry...";
            }
        }
        
        /* Events to execute when the "Email Configuration" tab is clicked */
        private void emailConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Create a new instance of EmailConfigration and show it */
            ConfigWindow = new EmailConfiguration();
            ConfigWindow.Show();
        }

        /* Events to execute when focus form the "TO" textbox is lost */
        private void To_textbox_Leave(object sender, EventArgs e)
        {
            /* Create a bollean to check if the email is vaild */
            bool isValid = EMailValidator.EmailIsValid(this.To_textbox.Text);
            Debug.WriteLine("Valid: " + isValid);

            /* If the email entered is NOT valid AND the text is NOT empty, sets the LblEmailInvalid text */
            if (!isValid && (this.To_textbox.Text != string.Empty))
                this.LblEmailInvalid.Text = "*) Invalid Email Address";

            /* Leaves the LblEmailInvalid textbox empty */
            else
            {
                this.LblEmailInvalid.Text = string.Empty;
            }
        }

        private void danishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RuntimeLocalizer.ChangeCulture(this, "da-DK");
        }

        private void danishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuntimeLocalizer.ChangeCulture(this, "en-US");
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
