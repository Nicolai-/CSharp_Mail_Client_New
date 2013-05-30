namespace EmailClient
{
    partial class EmailConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAESKey = new System.Windows.Forms.TextBox();
            this.LblAES = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnSmtpApply = new System.Windows.Forms.Button();
            this.textBoxSmtpPassword = new System.Windows.Forms.TextBox();
            this.textBoxSmtpUsername = new System.Windows.Forms.TextBox();
            this.textBoxSmtpPort = new System.Windows.Forms.TextBox();
            this.textBoxSmtpAddress = new System.Windows.Forms.TextBox();
            this.CheckBoxSmtpSSL = new System.Windows.Forms.CheckBox();
            this.LblSmtpPassword = new System.Windows.Forms.Label();
            this.LblSmtpUsername = new System.Windows.Forms.Label();
            this.LblSmtpPort = new System.Windows.Forms.Label();
            this.LblSmtpAddress = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPop3Password = new System.Windows.Forms.TextBox();
            this.textBoxPop3Username = new System.Windows.Forms.TextBox();
            this.textBoxPop3Port = new System.Windows.Forms.TextBox();
            this.textBoxPop3Address = new System.Windows.Forms.TextBox();
            this.checkBoxPop3SSL = new System.Windows.Forms.CheckBox();
            this.LblPop3Password = new System.Windows.Forms.Label();
            this.LblPop3Username = new System.Windows.Forms.Label();
            this.LblPop3Port = new System.Windows.Forms.Label();
            this.LblPop3Address = new System.Windows.Forms.Label();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.textBoxSenderName = new System.Windows.Forms.TextBox();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage3);
            this.TabGeneral.Location = new System.Drawing.Point(3, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(489, 248);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSenderName);
            this.tabPage1.Controls.Add(this.labelSenderName);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBoxAESKey);
            this.tabPage1.Controls.Add(this.LblAES);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnGeneralApply_Click);
            // 
            // textBoxAESKey
            // 
            this.textBoxAESKey.Location = new System.Drawing.Point(90, 10);
            this.textBoxAESKey.Name = "textBoxAESKey";
            this.textBoxAESKey.Size = new System.Drawing.Size(362, 20);
            this.textBoxAESKey.TabIndex = 1;
            // 
            // LblAES
            // 
            this.LblAES.AutoSize = true;
            this.LblAES.Location = new System.Drawing.Point(6, 13);
            this.LblAES.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblAES.Name = "LblAES";
            this.LblAES.Size = new System.Drawing.Size(49, 13);
            this.LblAES.TabIndex = 0;
            this.LblAES.Text = "AES Key";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnSmtpApply);
            this.tabPage2.Controls.Add(this.textBoxSmtpPassword);
            this.tabPage2.Controls.Add(this.textBoxSmtpUsername);
            this.tabPage2.Controls.Add(this.textBoxSmtpPort);
            this.tabPage2.Controls.Add(this.textBoxSmtpAddress);
            this.tabPage2.Controls.Add(this.CheckBoxSmtpSSL);
            this.tabPage2.Controls.Add(this.LblSmtpPassword);
            this.tabPage2.Controls.Add(this.LblSmtpUsername);
            this.tabPage2.Controls.Add(this.LblSmtpPort);
            this.tabPage2.Controls.Add(this.LblSmtpAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMTP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnSmtpApply
            // 
            this.BtnSmtpApply.Location = new System.Drawing.Point(399, 192);
            this.BtnSmtpApply.Name = "BtnSmtpApply";
            this.BtnSmtpApply.Size = new System.Drawing.Size(75, 23);
            this.BtnSmtpApply.TabIndex = 10;
            this.BtnSmtpApply.Text = "Apply";
            this.BtnSmtpApply.UseVisualStyleBackColor = true;
            this.BtnSmtpApply.Click += new System.EventHandler(this.BtnSmtpApply_Click);
            // 
            // textBoxSmtpPassword
            // 
            this.textBoxSmtpPassword.Location = new System.Drawing.Point(91, 109);
            this.textBoxSmtpPassword.Name = "textBoxSmtpPassword";
            this.textBoxSmtpPassword.Size = new System.Drawing.Size(287, 20);
            this.textBoxSmtpPassword.TabIndex = 9;
            this.textBoxSmtpPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSmtpUsername
            // 
            this.textBoxSmtpUsername.Location = new System.Drawing.Point(91, 76);
            this.textBoxSmtpUsername.Name = "textBoxSmtpUsername";
            this.textBoxSmtpUsername.Size = new System.Drawing.Size(287, 20);
            this.textBoxSmtpUsername.TabIndex = 8;
            // 
            // textBoxSmtpPort
            // 
            this.textBoxSmtpPort.Location = new System.Drawing.Point(91, 46);
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            this.textBoxSmtpPort.Size = new System.Drawing.Size(287, 20);
            this.textBoxSmtpPort.TabIndex = 7;
            // 
            // textBoxSmtpAddress
            // 
            this.textBoxSmtpAddress.Location = new System.Drawing.Point(91, 13);
            this.textBoxSmtpAddress.Name = "textBoxSmtpAddress";
            this.textBoxSmtpAddress.Size = new System.Drawing.Size(287, 20);
            this.textBoxSmtpAddress.TabIndex = 6;
            // 
            // CheckBoxSmtpSSL
            // 
            this.CheckBoxSmtpSSL.AutoSize = true;
            this.CheckBoxSmtpSSL.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.CheckBoxSmtpSSL.Location = new System.Drawing.Point(9, 145);
            this.CheckBoxSmtpSSL.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CheckBoxSmtpSSL.Name = "CheckBoxSmtpSSL";
            this.CheckBoxSmtpSSL.Size = new System.Drawing.Size(46, 17);
            this.CheckBoxSmtpSSL.TabIndex = 5;
            this.CheckBoxSmtpSSL.Text = "SSL";
            this.CheckBoxSmtpSSL.UseVisualStyleBackColor = true;
            // 
            // LblSmtpPassword
            // 
            this.LblSmtpPassword.AutoSize = true;
            this.LblSmtpPassword.Location = new System.Drawing.Point(6, 112);
            this.LblSmtpPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblSmtpPassword.Name = "LblSmtpPassword";
            this.LblSmtpPassword.Size = new System.Drawing.Size(53, 13);
            this.LblSmtpPassword.TabIndex = 3;
            this.LblSmtpPassword.Text = "Password";
            // 
            // LblSmtpUsername
            // 
            this.LblSmtpUsername.AutoSize = true;
            this.LblSmtpUsername.Location = new System.Drawing.Point(6, 79);
            this.LblSmtpUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblSmtpUsername.Name = "LblSmtpUsername";
            this.LblSmtpUsername.Size = new System.Drawing.Size(55, 13);
            this.LblSmtpUsername.TabIndex = 2;
            this.LblSmtpUsername.Text = "Username";
            // 
            // LblSmtpPort
            // 
            this.LblSmtpPort.AutoSize = true;
            this.LblSmtpPort.Location = new System.Drawing.Point(6, 46);
            this.LblSmtpPort.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblSmtpPort.Name = "LblSmtpPort";
            this.LblSmtpPort.Size = new System.Drawing.Size(26, 13);
            this.LblSmtpPort.TabIndex = 1;
            this.LblSmtpPort.Text = "Port";
            // 
            // LblSmtpAddress
            // 
            this.LblSmtpAddress.AutoSize = true;
            this.LblSmtpAddress.Location = new System.Drawing.Point(6, 13);
            this.LblSmtpAddress.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblSmtpAddress.Name = "LblSmtpAddress";
            this.LblSmtpAddress.Size = new System.Drawing.Size(79, 13);
            this.LblSmtpAddress.TabIndex = 0;
            this.LblSmtpAddress.Text = "Server Address";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBoxPop3Password);
            this.tabPage3.Controls.Add(this.textBoxPop3Username);
            this.tabPage3.Controls.Add(this.textBoxPop3Port);
            this.tabPage3.Controls.Add(this.textBoxPop3Address);
            this.tabPage3.Controls.Add(this.checkBoxPop3SSL);
            this.tabPage3.Controls.Add(this.LblPop3Password);
            this.tabPage3.Controls.Add(this.LblPop3Username);
            this.tabPage3.Controls.Add(this.LblPop3Port);
            this.tabPage3.Controls.Add(this.LblPop3Address);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "POP3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnPop3Apply_Click);
            // 
            // textBoxPop3Password
            // 
            this.textBoxPop3Password.Location = new System.Drawing.Point(91, 109);
            this.textBoxPop3Password.Name = "textBoxPop3Password";
            this.textBoxPop3Password.Size = new System.Drawing.Size(287, 20);
            this.textBoxPop3Password.TabIndex = 18;
            this.textBoxPop3Password.UseSystemPasswordChar = true;
            // 
            // textBoxPop3Username
            // 
            this.textBoxPop3Username.Location = new System.Drawing.Point(91, 76);
            this.textBoxPop3Username.Name = "textBoxPop3Username";
            this.textBoxPop3Username.Size = new System.Drawing.Size(287, 20);
            this.textBoxPop3Username.TabIndex = 17;
            // 
            // textBoxPop3Port
            // 
            this.textBoxPop3Port.Location = new System.Drawing.Point(91, 46);
            this.textBoxPop3Port.Name = "textBoxPop3Port";
            this.textBoxPop3Port.Size = new System.Drawing.Size(287, 20);
            this.textBoxPop3Port.TabIndex = 16;
            // 
            // textBoxPop3Address
            // 
            this.textBoxPop3Address.Location = new System.Drawing.Point(91, 13);
            this.textBoxPop3Address.Name = "textBoxPop3Address";
            this.textBoxPop3Address.Size = new System.Drawing.Size(287, 20);
            this.textBoxPop3Address.TabIndex = 15;
            // 
            // checkBoxPop3SSL
            // 
            this.checkBoxPop3SSL.AutoSize = true;
            this.checkBoxPop3SSL.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBoxPop3SSL.Location = new System.Drawing.Point(9, 145);
            this.checkBoxPop3SSL.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.checkBoxPop3SSL.Name = "checkBoxPop3SSL";
            this.checkBoxPop3SSL.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPop3SSL.TabIndex = 14;
            this.checkBoxPop3SSL.Text = "SSL";
            this.checkBoxPop3SSL.UseVisualStyleBackColor = true;
            // 
            // LblPop3Password
            // 
            this.LblPop3Password.AutoSize = true;
            this.LblPop3Password.Location = new System.Drawing.Point(6, 112);
            this.LblPop3Password.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblPop3Password.Name = "LblPop3Password";
            this.LblPop3Password.Size = new System.Drawing.Size(53, 13);
            this.LblPop3Password.TabIndex = 13;
            this.LblPop3Password.Text = "Password";
            // 
            // LblPop3Username
            // 
            this.LblPop3Username.AutoSize = true;
            this.LblPop3Username.Location = new System.Drawing.Point(6, 79);
            this.LblPop3Username.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblPop3Username.Name = "LblPop3Username";
            this.LblPop3Username.Size = new System.Drawing.Size(55, 13);
            this.LblPop3Username.TabIndex = 12;
            this.LblPop3Username.Text = "Username";
            // 
            // LblPop3Port
            // 
            this.LblPop3Port.AutoSize = true;
            this.LblPop3Port.Location = new System.Drawing.Point(6, 46);
            this.LblPop3Port.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblPop3Port.Name = "LblPop3Port";
            this.LblPop3Port.Size = new System.Drawing.Size(26, 13);
            this.LblPop3Port.TabIndex = 11;
            this.LblPop3Port.Text = "Port";
            // 
            // LblPop3Address
            // 
            this.LblPop3Address.AutoSize = true;
            this.LblPop3Address.Location = new System.Drawing.Point(6, 13);
            this.LblPop3Address.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblPop3Address.Name = "LblPop3Address";
            this.LblPop3Address.Size = new System.Drawing.Size(79, 13);
            this.LblPop3Address.TabIndex = 10;
            this.LblPop3Address.Text = "Server Address";
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Location = new System.Drawing.Point(6, 46);
            this.labelSenderName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(72, 13);
            this.labelSenderName.TabIndex = 12;
            this.labelSenderName.Text = "Sender Name";
            // 
            // textBoxSenderName
            // 
            this.textBoxSenderName.Location = new System.Drawing.Point(90, 46);
            this.textBoxSenderName.Name = "textBoxSenderName";
            this.textBoxSenderName.Size = new System.Drawing.Size(362, 20);
            this.textBoxSenderName.TabIndex = 13;
            // 
            // EmailConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.TabGeneral);
            this.Name = "EmailConfiguration";
            this.Text = "EmailConfiguration";
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxSmtpPassword;
        private System.Windows.Forms.TextBox textBoxSmtpUsername;
        private System.Windows.Forms.TextBox textBoxSmtpPort;
        private System.Windows.Forms.TextBox textBoxSmtpAddress;
        private System.Windows.Forms.CheckBox CheckBoxSmtpSSL;
        private System.Windows.Forms.Label LblSmtpPassword;
        private System.Windows.Forms.Label LblSmtpUsername;
        private System.Windows.Forms.Label LblSmtpPort;
        private System.Windows.Forms.Label LblSmtpAddress;
        private System.Windows.Forms.Button BtnSmtpApply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPop3Password;
        private System.Windows.Forms.TextBox textBoxPop3Username;
        private System.Windows.Forms.TextBox textBoxPop3Port;
        private System.Windows.Forms.TextBox textBoxPop3Address;
        private System.Windows.Forms.CheckBox checkBoxPop3SSL;
        private System.Windows.Forms.Label LblPop3Password;
        private System.Windows.Forms.Label LblPop3Username;
        private System.Windows.Forms.Label LblPop3Port;
        private System.Windows.Forms.Label LblPop3Address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAESKey;
        private System.Windows.Forms.Label LblAES;
        private System.Windows.Forms.TextBox textBoxSenderName;
        private System.Windows.Forms.Label labelSenderName;
    }
}