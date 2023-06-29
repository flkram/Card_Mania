namespace CapStone
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnCrazy8 = new System.Windows.Forms.Button();
            this.btnWar = new System.Windows.Forms.Button();
            this.btnBlackJack = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayImage3 = new System.Windows.Forms.PictureBox();
            this.DisplayImage2 = new System.Windows.Forms.PictureBox();
            this.DisplayImage1 = new System.Windows.Forms.PictureBox();
            this.tmrCardAnimation = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TabPB = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrazy8
            // 
            this.btnCrazy8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrazy8.BackgroundImage")));
            this.btnCrazy8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrazy8.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrazy8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrazy8.Location = new System.Drawing.Point(480, 423);
            this.btnCrazy8.Name = "btnCrazy8";
            this.btnCrazy8.Size = new System.Drawing.Size(173, 48);
            this.btnCrazy8.TabIndex = 29;
            this.btnCrazy8.Text = "Crazy 8";
            this.btnCrazy8.UseVisualStyleBackColor = true;
            this.btnCrazy8.Click += new System.EventHandler(this.btnCrazy8_Click);
            // 
            // btnWar
            // 
            this.btnWar.BackColor = System.Drawing.Color.SeaShell;
            this.btnWar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWar.BackgroundImage")));
            this.btnWar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWar.CausesValidation = false;
            this.btnWar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWar.Location = new System.Drawing.Point(838, 168);
            this.btnWar.Name = "btnWar";
            this.btnWar.Size = new System.Drawing.Size(173, 48);
            this.btnWar.TabIndex = 28;
            this.btnWar.Text = "War";
            this.btnWar.UseVisualStyleBackColor = false;
            this.btnWar.Click += new System.EventHandler(this.btnWar_Click);
            // 
            // btnBlackJack
            // 
            this.btnBlackJack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlackJack.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackJack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBlackJack.Location = new System.Drawing.Point(111, 167);
            this.btnBlackJack.Name = "btnBlackJack";
            this.btnBlackJack.Size = new System.Drawing.Size(173, 48);
            this.btnBlackJack.TabIndex = 26;
            this.btnBlackJack.Text = "Black Jack";
            this.btnBlackJack.UseVisualStyleBackColor = false;
            this.btnBlackJack.Click += new System.EventHandler(this.btnBlackJack_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefund.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRefund.Location = new System.Drawing.Point(982, 47);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(124, 43);
            this.btnRefund.TabIndex = 25;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Visible = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Impact", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExit.Location = new System.Drawing.Point(10, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 42);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Black;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMoney.Location = new System.Drawing.Point(847, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 36);
            this.lblMoney.TabIndex = 23;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Black;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccount.Location = new System.Drawing.Point(10, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(0, 36);
            this.lblAccount.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 117);
            this.label1.TabIndex = 21;
            this.label1.Text = "Card Mania";
            // 
            // DisplayImage3
            // 
            this.DisplayImage3.Location = new System.Drawing.Point(480, 477);
            this.DisplayImage3.Name = "DisplayImage3";
            this.DisplayImage3.Size = new System.Drawing.Size(173, 250);
            this.DisplayImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayImage3.TabIndex = 20;
            this.DisplayImage3.TabStop = false;
            // 
            // DisplayImage2
            // 
            this.DisplayImage2.Location = new System.Drawing.Point(838, 221);
            this.DisplayImage2.Name = "DisplayImage2";
            this.DisplayImage2.Size = new System.Drawing.Size(173, 250);
            this.DisplayImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayImage2.TabIndex = 19;
            this.DisplayImage2.TabStop = false;
            // 
            // DisplayImage1
            // 
            this.DisplayImage1.Location = new System.Drawing.Point(111, 221);
            this.DisplayImage1.Name = "DisplayImage1";
            this.DisplayImage1.Size = new System.Drawing.Size(173, 250);
            this.DisplayImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayImage1.TabIndex = 17;
            this.DisplayImage1.TabStop = false;
            // 
            // tmrCardAnimation
            // 
            this.tmrCardAnimation.Enabled = true;
            this.tmrCardAnimation.Interval = 350;
            this.tmrCardAnimation.Tick += new System.EventHandler(this.tmrCardAnimation_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Impact", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(982, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Check Stats";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // TabPB
            // 
            this.TabPB.BackColor = System.Drawing.Color.Black;
            this.TabPB.Location = new System.Drawing.Point(-3, -2);
            this.TabPB.Name = "TabPB";
            this.TabPB.Size = new System.Drawing.Size(1121, 162);
            this.TabPB.TabIndex = 31;
            this.TabPB.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Black;
            this.btnRandom.Font = new System.Drawing.Font("Impact", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandom.Location = new System.Drawing.Point(12, 814);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(106, 39);
            this.btnRandom.TabIndex = 33;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.Black;
            this.btnOption.Font = new System.Drawing.Font("Impact", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOption.Location = new System.Drawing.Point(1000, 814);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(106, 39);
            this.btnOption.TabIndex = 34;
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1118, 865);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.TabPB);
            this.Controls.Add(this.btnCrazy8);
            this.Controls.Add(this.btnWar);
            this.Controls.Add(this.btnBlackJack);
            this.Controls.Add(this.DisplayImage3);
            this.Controls.Add(this.DisplayImage2);
            this.Controls.Add(this.DisplayImage1);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrazy8;
        private System.Windows.Forms.Button btnWar;
        private System.Windows.Forms.Button btnBlackJack;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DisplayImage3;
        private System.Windows.Forms.PictureBox DisplayImage2;
        private System.Windows.Forms.PictureBox DisplayImage1;
        private System.Windows.Forms.Timer tmrCardAnimation;
        public System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TabPB;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnOption;
    }
}