namespace Theater.Client
{
    partial class ChangeMail
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
            tbxEmail = new TextBox();
            btnApply = new Button();
            SuspendLayout();
            // 
            // tbxEmail
            // 
            tbxEmail.Dock = DockStyle.Top;
            tbxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.Location = new Point(10, 10);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(257, 27);
            tbxEmail.TabIndex = 0;
            tbxEmail.KeyDown += tbxEmail_KeyDown;
            // 
            // btnApply
            // 
            btnApply.AutoSize = true;
            btnApply.Dock = DockStyle.Top;
            btnApply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(10, 37);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(257, 31);
            btnApply.TabIndex = 1;
            btnApply.Text = "Xác nhận";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // ChangeMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 72);
            Controls.Add(btnApply);
            Controls.Add(tbxEmail);
            KeyPreview = true;
            Name = "ChangeMail";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Xác nhận lại email";
            Load += ChangeMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxEmail;
        private Button btnApply;
    }
}