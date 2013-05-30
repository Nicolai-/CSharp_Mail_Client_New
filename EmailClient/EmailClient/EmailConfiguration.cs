using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Setting = EmailClient.Properties.Settings;
using System.Diagnostics;

namespace EmailClient
{
    public partial class EmailConfiguration : Form
    {
        public EmailConfiguration()
        {
            this.Load += EmailConfigurationLoadInfo;

            InitializeComponent();

        }

        void EmailConfigurationLoadInfo(object sender, EventArgs e)
        {
            this.Text = "Super Mail Klient by Mathias & Nicolai";
            this.textBoxSmtpAddress.Text = Setting.Default.smtp_server;
            this.textBoxSmtpPort.Text = Convert.ToString(Setting.Default.smtp_port);
            this.textBoxSmtpUsername.Text = Setting.Default.username;
            this.textBoxSmtpPassword.Text = Setting.Default.password;
            this.CheckBoxSmtpSSL.Checked = Setting.Default.smtp_ssl;

            this.textBoxPop3Address.Text = Setting.Default.pop3_server;
            this.textBoxPop3Port.Text = Convert.ToString(Setting.Default.pop3_port);
            this.textBoxPop3Username.Text = Setting.Default.username;
            this.textBoxPop3Password.Text = Setting.Default.password;
            this.checkBoxPop3SSL.Checked = Setting.Default.pop3_ssl;

            this.textBoxAESKey.Text = Setting.Default.aes_key;

        }

        private void BtnSmtpApply_Click(object sender, EventArgs e)
        {
            Setting.Default.smtp_server = this.textBoxSmtpAddress.Text;
            Setting.Default.smtp_port = Convert.ToInt32(this.textBoxSmtpPort.Text);
            Setting.Default.username = this.textBoxSmtpUsername.Text;
            Setting.Default.password = this.textBoxSmtpPassword.Text;
            Setting.Default.smtp_ssl = this.CheckBoxSmtpSSL.Checked;
            Debug.WriteLine("Checkbox value: " + this.CheckBoxSmtpSSL.Checked);
            Setting.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting.Default.pop3_server = this.textBoxPop3Address.Text;
            Setting.Default.pop3_port = Convert.ToInt32(this.textBoxPop3Port.Text);
            Setting.Default.username = this.textBoxPop3Username.Text;
            Setting.Default.password = this.textBoxPop3Password.Text;
            Setting.Default.pop3_ssl = this.checkBoxPop3SSL.Checked;
            Debug.WriteLine("Checkbox value: " + this.checkBoxPop3SSL.Checked);
            Setting.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setting.Default.aes_key = this.textBoxAESKey.Text;
        }
    }
}
