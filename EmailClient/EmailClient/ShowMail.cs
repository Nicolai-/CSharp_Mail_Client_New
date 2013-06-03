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

        /*  */                                                                                                                      /*********** ASK NICOLAI *********/
        public ShowMail(string to, string from, string subject, string message)
        {
            InitializeComponent();
            this.ToLblText.Text = to;
            this.FromLblText.Text = from;
            this.SubjectLblText.Text = subject;
            this.ShowMailTextBox.BackColor = Color.White;
            this.ShowMailTextBox.Text = message;
            /* Set title of window */
            this.Text = subject;
        }

        /* Fuction to create a page to print */
        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            /* Sets the content and properties of the page to print */
            string FullMessage = "To: " + this.ToLblText.Text + "\r\n\r\n" + "From. " + this.FromLblText.Text + "\r\n\r\n" + "Subject: " + this.SubjectLblText.Text + "\r\n\r\n\r\n\r\n" + this.ShowMailTextBox.Text;
            e.Graphics.DrawString(FullMessage, this.ShowMailTextBox.Font, Brushes.Black, 10, 25);
        }

        /* Events to execute when the "Print" button is clicked */
        private void Print_button_Click(object sender, EventArgs e)
        {
            /* Creates a new instance of printDocument, appends the result from PrintDocumentOnPrintPage and prints the result */
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }

        /* Events to execute when then "Decrypt" button is pressed */
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            /* Decrypts the message to plain text */
            string plaintext = Crypto.DecryptStringAES(this.ShowMailTextBox.Text.Trim(), this.textBoxAESKey.Text);
            this.ShowMailTextBox.Text = plaintext;
        }

    }
}
