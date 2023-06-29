namespace CapStone
{
    partial class Options
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStatClear = new System.Windows.Forms.Button();
            this.btnPasswordChange = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 43);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStatClear
            // 
            this.btnStatClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStatClear.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnStatClear.Location = new System.Drawing.Point(373, 257);
            this.btnStatClear.Name = "btnStatClear";
            this.btnStatClear.Size = new System.Drawing.Size(167, 43);
            this.btnStatClear.TabIndex = 28;
            this.btnStatClear.Text = "Clear Stats";
            this.btnStatClear.UseVisualStyleBackColor = false;
            this.btnStatClear.Click += new System.EventHandler(this.btnStatClear_Click);
            // 
            // btnPasswordChange
            // 
            this.btnPasswordChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPasswordChange.Font = new System.Drawing.Font("Impact", 13.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPasswordChange.Location = new System.Drawing.Point(373, 306);
            this.btnPasswordChange.Name = "btnPasswordChange";
            this.btnPasswordChange.Size = new System.Drawing.Size(167, 43);
            this.btnPasswordChange.TabIndex = 29;
            this.btnPasswordChange.Text = "Change Password";
            this.btnPasswordChange.UseVisualStyleBackColor = false;
            this.btnPasswordChange.Click += new System.EventHandler(this.btnPasswordChange_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHistory.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHistory.Location = new System.Drawing.Point(373, 355);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(167, 43);
            this.btnHistory.TabIndex = 31;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAccountDelete.Font = new System.Drawing.Font("Impact", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAccountDelete.Location = new System.Drawing.Point(373, 453);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(167, 43);
            this.btnAccountDelete.TabIndex = 33;
            this.btnAccountDelete.Text = "Delete Account";
            this.btnAccountDelete.UseVisualStyleBackColor = false;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(263, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 358);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAccount.Location = new System.Drawing.Point(258, 123);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(387, 39);
            this.lblAccount.TabIndex = 35;
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.Font = new System.Drawing.Font("Impact", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogOut.Location = new System.Drawing.Point(373, 404);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 43);
            this.btnLogOut.TabIndex = 36;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(886, 654);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnAccountDelete);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnPasswordChange);
            this.Controls.Add(this.btnStatClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnStatClear;
        public System.Windows.Forms.Button btnPasswordChange;
        public System.Windows.Forms.Button btnHistory;
        public System.Windows.Forms.Button btnAccountDelete;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblAccount;
        public System.Windows.Forms.Button btnLogOut;
    }
}