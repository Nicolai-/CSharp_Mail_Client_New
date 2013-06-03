namespace EmailClient
{
    partial class ShowMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMail));
            this.ToLbl = new System.Windows.Forms.Label();
            this.FromLbl = new System.Windows.Forms.Label();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.ToLblText = new System.Windows.Forms.Label();
            this.FromLblText = new System.Windows.Forms.Label();
            this.SubjectLblText = new System.Windows.Forms.Label();
            this.ShowMailTextBox = new System.Windows.Forms.RichTextBox();
            this.Print_button = new System.Windows.Forms.Button();
            this.textBoxAESKey = new System.Windows.Forms.TextBox();
            this.LblAESKey = new System.Windows.Forms.Label();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToLbl
            // 
            resources.ApplyResources(this.ToLbl, "ToLbl");
            this.ToLbl.Name = "ToLbl";
            // 
            // FromLbl
            // 
            resources.ApplyResources(this.FromLbl, "FromLbl");
            this.FromLbl.Name = "FromLbl";
            // 
            // SubjectLbl
            // 
            resources.ApplyResources(this.SubjectLbl, "SubjectLbl");
            this.SubjectLbl.Name = "SubjectLbl";
            // 
            // ToLblText
            // 
            resources.ApplyResources(this.ToLblText, "ToLblText");
            this.ToLblText.Name = "ToLblText";
            // 
            // FromLblText
            // 
            resources.ApplyResources(this.FromLblText, "FromLblText");
            this.FromLblText.Name = "FromLblText";
            // 
            // SubjectLblText
            // 
            resources.ApplyResources(this.SubjectLblText, "SubjectLblText");
            this.SubjectLblText.Name = "SubjectLblText";
            // 
            // ShowMailTextBox
            // 
            resources.ApplyResources(this.ShowMailTextBox, "ShowMailTextBox");
            this.ShowMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowMailTextBox.Name = "ShowMailTextBox";
            this.ShowMailTextBox.ReadOnly = true;
            // 
            // Print_button
            // 
            resources.ApplyResources(this.Print_button, "Print_button");
            this.Print_button.Name = "Print_button";
            this.Print_button.UseVisualStyleBackColor = true;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // textBoxAESKey
            // 
            resources.ApplyResources(this.textBoxAESKey, "textBoxAESKey");
            this.textBoxAESKey.Name = "textBoxAESKey";
            // 
            // LblAESKey
            // 
            resources.ApplyResources(this.LblAESKey, "LblAESKey");
            this.LblAESKey.Name = "LblAESKey";
            // 
            // BtnDecrypt
            // 
            resources.ApplyResources(this.BtnDecrypt, "BtnDecrypt");
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // ShowMail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.LblAESKey);
            this.Controls.Add(this.textBoxAESKey);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.ShowMailTextBox);
            this.Controls.Add(this.SubjectLblText);
            this.Controls.Add(this.FromLblText);
            this.Controls.Add(this.ToLblText);
            this.Controls.Add(this.SubjectLbl);
            this.Controls.Add(this.FromLbl);
            this.Controls.Add(this.ToLbl);
            this.Name = "ShowMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.Label SubjectLbl;
        private System.Windows.Forms.Label ToLblText;
        private System.Windows.Forms.Label FromLblText;
        private System.Windows.Forms.Label SubjectLblText;
        private System.Windows.Forms.RichTextBox ShowMailTextBox;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.TextBox textBoxAESKey;
        private System.Windows.Forms.Label LblAESKey;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}