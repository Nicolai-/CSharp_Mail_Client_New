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
            ShowMailTextBox.Text = message;
            /* Set title of window */
            this.Text = subject;
        }

        private void ShowMail_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            string FullMessage = "To: " + this.ToLblText.Text + "\r\n\r\n" + "From. " + this.FromLblText.Text + "\r\n\r\n" + "Subject: " + this.SubjectLblText.Text + "\r\n\r\n\r\n\r\n" + this.ShowMailTextBox.Text;
            e.Graphics.DrawString(FullMessage, this.ShowMailTextBox.Font, Brushes.Black, 10, 25);
        }


        private void Print_button_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }
    }
}
