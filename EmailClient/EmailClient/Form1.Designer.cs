namespace EmailClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newMail_btn = new System.Windows.Forms.Button();
            this.inbox_btn = new System.Windows.Forms.Button();
            this.sendReceive_btn = new System.Windows.Forms.Button();
            this.inboxDataGridView = new System.Windows.Forms.DataGridView();
            this.Mail_Groupbox = new System.Windows.Forms.GroupBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Message_Label = new System.Windows.Forms.Label();
            this.Subject_Label = new System.Windows.Forms.Label();
            this.To_Label = new System.Windows.Forms.Label();
            this.Subject_textbox = new System.Windows.Forms.TextBox();
            this.Message_textbox = new System.Windows.Forms.TextBox();
            this.To_textbox = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDataGridView)).BeginInit();
            this.Mail_Groupbox.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMail_btn
            // 
            resources.ApplyResources(this.newMail_btn, "newMail_btn");
            this.newMail_btn.Name = "newMail_btn";
            this.newMail_btn.UseVisualStyleBackColor = true;
            this.newMail_btn.Click += new System.EventHandler(this.newMail_btn_Click);
            // 
            // inbox_btn
            // 
            resources.ApplyResources(this.inbox_btn, "inbox_btn");
            this.inbox_btn.Name = "inbox_btn";
            this.inbox_btn.UseVisualStyleBackColor = true;
            this.inbox_btn.Click += new System.EventHandler(this.inbox_btn_Click);
            // 
            // sendReceive_btn
            // 
            resources.ApplyResources(this.sendReceive_btn, "sendReceive_btn");
            this.sendReceive_btn.Name = "sendReceive_btn";
            this.sendReceive_btn.UseVisualStyleBackColor = true;
            this.sendReceive_btn.Click += new System.EventHandler(this.Retrieve_btn_Click);
            // 
            // inboxDataGridView
            // 
            this.inboxDataGridView.AllowUserToAddRows = false;
            this.inboxDataGridView.AllowUserToDeleteRows = false;
            this.inboxDataGridView.AllowUserToOrderColumns = true;
            this.inboxDataGridView.AllowUserToResizeRows = false;
            this.inboxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inboxDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inboxDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inboxDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.inboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inboxDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.inboxDataGridView, "inboxDataGridView");
            this.inboxDataGridView.MultiSelect = false;
            this.inboxDataGridView.Name = "inboxDataGridView";
            this.inboxDataGridView.ReadOnly = true;
            this.inboxDataGridView.ShowEditingIcon = false;
            this.inboxDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inboxDataGridView_CellContentDoubleClick);
            // 
            // Mail_Groupbox
            // 
            this.Mail_Groupbox.Controls.Add(this.Send_Button);
            this.Mail_Groupbox.Controls.Add(this.Message_Label);
            this.Mail_Groupbox.Controls.Add(this.Subject_Label);
            this.Mail_Groupbox.Controls.Add(this.To_Label);
            this.Mail_Groupbox.Controls.Add(this.Subject_textbox);
            this.Mail_Groupbox.Controls.Add(this.Message_textbox);
            this.Mail_Groupbox.Controls.Add(this.To_textbox);
            resources.ApplyResources(this.Mail_Groupbox, "Mail_Groupbox");
            this.Mail_Groupbox.Name = "Mail_Groupbox";
            this.Mail_Groupbox.TabStop = false;
            // 
            // Send_Button
            // 
            resources.ApplyResources(this.Send_Button, "Send_Button");
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Message_Label
            // 
            resources.ApplyResources(this.Message_Label, "Message_Label");
            this.Message_Label.Name = "Message_Label";
            // 
            // Subject_Label
            // 
            resources.ApplyResources(this.Subject_Label, "Subject_Label");
            this.Subject_Label.Name = "Subject_Label";
            // 
            // To_Label
            // 
            resources.ApplyResources(this.To_Label, "To_Label");
            this.To_Label.Name = "To_Label";
            // 
            // Subject_textbox
            // 
            resources.ApplyResources(this.Subject_textbox, "Subject_textbox");
            this.Subject_textbox.Name = "Subject_textbox";
            this.Subject_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearStatus);
            // 
            // Message_textbox
            // 
            resources.ApplyResources(this.Message_textbox, "Message_textbox");
            this.Message_textbox.Name = "Message_textbox";
            this.Message_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearStatus);
            // 
            // To_textbox
            // 
            resources.ApplyResources(this.To_textbox, "To_textbox");
            this.To_textbox.Name = "To_textbox";
            this.To_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearStatus);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.StripProgressBar,
            this.StripStatusLabel});
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // StripProgressBar
            // 
            this.StripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StripProgressBar.Name = "StripProgressBar";
            resources.ApplyResources(this.StripProgressBar, "StripProgressBar");
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            resources.ApplyResources(this.StripStatusLabel, "StripStatusLabel");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Mail_Groupbox);
            this.Controls.Add(this.inboxDataGridView);
            this.Controls.Add(this.sendReceive_btn);
            this.Controls.Add(this.inbox_btn);
            this.Controls.Add(this.newMail_btn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inboxDataGridView)).EndInit();
            this.Mail_Groupbox.ResumeLayout(false);
            this.Mail_Groupbox.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newMail_btn;
        private System.Windows.Forms.Button inbox_btn;
        private System.Windows.Forms.Button sendReceive_btn;
        private System.Windows.Forms.DataGridView inboxDataGridView;
        private System.Windows.Forms.GroupBox Mail_Groupbox;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.Label Message_Label;
        private System.Windows.Forms.Label Subject_Label;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.TextBox Subject_textbox;
        private System.Windows.Forms.TextBox Message_textbox;
        private System.Windows.Forms.TextBox To_textbox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
    }
}

