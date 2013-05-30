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
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(23, 19);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(23, 13);
            this.ToLbl.TabIndex = 1;
            this.ToLbl.Text = "To:";
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Location = new System.Drawing.Point(23, 48);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(33, 13);
            this.FromLbl.TabIndex = 2;
            this.FromLbl.Text = "From:";
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Location = new System.Drawing.Point(23, 80);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(46, 13);
            this.SubjectLbl.TabIndex = 4;
            this.SubjectLbl.Text = "Subject:";
            // 
            // ToLblText
            // 
            this.ToLblText.AutoSize = true;
            this.ToLblText.Location = new System.Drawing.Point(83, 19);
            this.ToLblText.Name = "ToLblText";
            this.ToLblText.Size = new System.Drawing.Size(0, 13);
            this.ToLblText.TabIndex = 5;
            // 
            // FromLblText
            // 
            this.FromLblText.AutoSize = true;
            this.FromLblText.Location = new System.Drawing.Point(83, 48);
            this.FromLblText.Name = "FromLblText";
            this.FromLblText.Size = new System.Drawing.Size(0, 13);
            this.FromLblText.TabIndex = 6;
            // 
            // SubjectLblText
            // 
            this.SubjectLblText.AutoSize = true;
            this.SubjectLblText.Location = new System.Drawing.Point(83, 80);
            this.SubjectLblText.Name = "SubjectLblText";
            this.SubjectLblText.Size = new System.Drawing.Size(0, 13);
            this.SubjectLblText.TabIndex = 7;
            // 
            // ShowMailTextBox
            // 
            this.ShowMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowMailTextBox.Location = new System.Drawing.Point(26, 115);
            this.ShowMailTextBox.Name = "ShowMailTextBox";
            this.ShowMailTextBox.ReadOnly = true;
            this.ShowMailTextBox.Size = new System.Drawing.Size(710, 474);
            this.ShowMailTextBox.TabIndex = 8;
            this.ShowMailTextBox.Text = "";
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(661, 80);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(75, 23);
            this.Print_button.TabIndex = 9;
            this.Print_button.Text = "Print Email";
            this.Print_button.UseVisualStyleBackColor = true;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // textBoxAESKey
            // 
            this.textBoxAESKey.Location = new System.Drawing.Point(531, 19);
            this.textBoxAESKey.Name = "textBoxAESKey";
            this.textBoxAESKey.Size = new System.Drawing.Size(205, 20);
            this.textBoxAESKey.TabIndex = 10;
            // 
            // LblAESKey
            // 
            this.LblAESKey.AutoSize = true;
            this.LblAESKey.Location = new System.Drawing.Point(473, 22);
            this.LblAESKey.Name = "LblAESKey";
            this.LblAESKey.Size = new System.Drawing.Size(52, 13);
            this.LblAESKey.TabIndex = 11;
            this.LblAESKey.Text = "AES KEY";
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(661, 48);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnDecrypt.TabIndex = 12;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // ShowMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 614);
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
            this.Text = "ShowMail";
            this.Load += new System.EventHandler(this.ShowMail_Load);
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