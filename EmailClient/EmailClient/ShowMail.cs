using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace EmailClient
{
    public partial class ShowMail : Form
    {
        public ShowMail(string to, string from, string subject, string message)
        {
            InitializeComponent();
            ToLblText.Text = to;
            FromLblText.Text = from;
            SubjectLblText.Text = subject;
            ShowMailTextBox.BackColor = Color.White;
            ShowMailTextBox.Text = "To: " + to + "\r\n\r\n" + "From. " + from + "\r\n\r\n" + "Subject: " + subject + "\r\n\r\n\r\n\r\n" + message;
            /* Set title of window */
            this.Text = subject;
        }

        private void ShowMail_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.ShowMailTextBox.Text, this.ShowMailTextBox.Font, Brushes.Black, 10, 25);
        }


        private void Print_button_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }
    }
}
