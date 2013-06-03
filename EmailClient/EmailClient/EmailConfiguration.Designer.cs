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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailConfiguration));
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSenderName = new System.Windows.Forms.TextBox();
            this.labelSenderName = new System.Windows.Forms.Label();
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
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            resources.ApplyResources(this.TabGeneral, "TabGeneral");
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage3);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.textBoxSenderName);
            this.tabPage1.Controls.Add(this.labelSenderName);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBoxAESKey);
            this.tabPage1.Controls.Add(this.LblAES);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSenderName
            // 
            resources.ApplyResources(this.textBoxSenderName, "textBoxSenderName");
            this.textBoxSenderName.Name = "textBoxSenderName";
            // 
            // labelSenderName
            // 
            resources.ApplyResources(this.labelSenderName, "labelSenderName");
            this.labelSenderName.Name = "labelSenderName";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnGeneralApply_Click);
            // 
            // textBoxAESKey
            // 
            resources.ApplyResources(this.textBoxAESKey, "textBoxAESKey");
            this.textBoxAESKey.Name = "textBoxAESKey";
            // 
            // LblAES
            // 
            resources.ApplyResources(this.LblAES, "LblAES");
            this.LblAES.Name = "LblAES";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
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
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnSmtpApply
            // 
            resources.ApplyResources(this.BtnSmtpApply, "BtnSmtpApply");
            this.BtnSmtpApply.Name = "BtnSmtpApply";
            this.BtnSmtpApply.UseVisualStyleBackColor = true;
            this.BtnSmtpApply.Click += new System.EventHandler(this.BtnSmtpApply_Click);
            // 
            // textBoxSmtpPassword
            // 
            resources.ApplyResources(this.textBoxSmtpPassword, "textBoxSmtpPassword");
            this.textBoxSmtpPassword.Name = "textBoxSmtpPassword";
            this.textBoxSmtpPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSmtpUsername
            // 
            resources.ApplyResources(this.textBoxSmtpUsername, "textBoxSmtpUsername");
            this.textBoxSmtpUsername.Name = "textBoxSmtpUsername";
            // 
            // textBoxSmtpPort
            // 
            resources.ApplyResources(this.textBoxSmtpPort, "textBoxSmtpPort");
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            // 
            // textBoxSmtpAddress
            // 
            resources.ApplyResources(this.textBoxSmtpAddress, "textBoxSmtpAddress");
            this.textBoxSmtpAddress.Name = "textBoxSmtpAddress";
            // 
            // CheckBoxSmtpSSL
            // 
            resources.ApplyResources(this.CheckBoxSmtpSSL, "CheckBoxSmtpSSL");
            this.CheckBoxSmtpSSL.Name = "CheckBoxSmtpSSL";
            this.CheckBoxSmtpSSL.UseVisualStyleBackColor = true;
            // 
            // LblSmtpPassword
            // 
            resources.ApplyResources(this.LblSmtpPassword, "LblSmtpPassword");
            this.LblSmtpPassword.Name = "LblSmtpPassword";
            // 
            // LblSmtpUsername
            // 
            resources.ApplyResources(this.LblSmtpUsername, "LblSmtpUsername");
            this.LblSmtpUsername.Name = "LblSmtpUsername";
            // 
            // LblSmtpPort
            // 
            resources.ApplyResources(this.LblSmtpPort, "LblSmtpPort");
            this.LblSmtpPort.Name = "LblSmtpPort";
            // 
            // LblSmtpAddress
            // 
            resources.ApplyResources(this.LblSmtpAddress, "LblSmtpAddress");
            this.LblSmtpAddress.Name = "LblSmtpAddress";
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
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
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnPop3Apply_Click);
            // 
            // textBoxPop3Password
            // 
            resources.ApplyResources(this.textBoxPop3Password, "textBoxPop3Password");
            this.textBoxPop3Password.Name = "textBoxPop3Password";
            this.textBoxPop3Password.UseSystemPasswordChar = true;
            // 
            // textBoxPop3Username
            // 
            resources.ApplyResources(this.textBoxPop3Username, "textBoxPop3Username");
            this.textBoxPop3Username.Name = "textBoxPop3Username";
            // 
            // textBoxPop3Port
            // 
            resources.ApplyResources(this.textBoxPop3Port, "textBoxPop3Port");
            this.textBoxPop3Port.Name = "textBoxPop3Port";
            // 
            // textBoxPop3Address
            // 
            resources.ApplyResources(this.textBoxPop3Address, "textBoxPop3Address");
            this.textBoxPop3Address.Name = "textBoxPop3Address";
            // 
            // checkBoxPop3SSL
            // 
            resources.ApplyResources(this.checkBoxPop3SSL, "checkBoxPop3SSL");
            this.checkBoxPop3SSL.Name = "checkBoxPop3SSL";
            this.checkBoxPop3SSL.UseVisualStyleBackColor = true;
            // 
            // LblPop3Password
            // 
            resources.ApplyResources(this.LblPop3Password, "LblPop3Password");
            this.LblPop3Password.Name = "LblPop3Password";
            // 
            // LblPop3Username
            // 
            resources.ApplyResources(this.LblPop3Username, "LblPop3Username");
            this.LblPop3Username.Name = "LblPop3Username";
            // 
            // LblPop3Port
            // 
            resources.ApplyResources(this.LblPop3Port, "LblPop3Port");
            this.LblPop3Port.Name = "LblPop3Port";
            // 
            // LblPop3Address
            // 
            resources.ApplyResources(this.LblPop3Address, "LblPop3Address");
            this.LblPop3Address.Name = "LblPop3Address";
            // 
            // EmailConfiguration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabGeneral);
            this.Name = "EmailConfiguration";
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