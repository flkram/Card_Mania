namespace CapStone
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.dEck = new System.Windows.Forms.PictureBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dEck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dEck
            // 
            this.dEck.Image = ((System.Drawing.Image)(resources.GetObject("dEck.Image")));
            this.dEck.Location = new System.Drawing.Point(666, 267);
            this.dEck.Name = "dEck";
            this.dEck.Size = new System.Drawing.Size(87, 127);
            this.dEck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dEck.TabIndex = 10;
            this.dEck.TabStop = false;
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.Maroon;
            this.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCont.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.ForeColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(538, 309);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(122, 43);
            this.btnCont.TabIndex = 11;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Maroon;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(538, 199);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(122, 43);
            this.btnHit.TabIndex = 12;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Maroon;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F);
            this.btnStand.ForeColor = System.Drawing.Color.White;
            this.btnStand.Location = new System.Drawing.Point(538, 423);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(122, 43);
            this.btnStand.TabIndex = 13;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(7, 201);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(525, 265);
            this.lblLabel.TabIndex = 31;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(538, 309);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 43);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "New Round";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(775, 267);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 25);
            this.lblScore.TabIndex = 35;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(822, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 36;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 667);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.dEck);
            this.DoubleBuffered = true;
            this.Name = "BlackJackForm";
            this.Text = "BlackJackForm";
            this.Load += new System.EventHandler(this.BlackJackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dEck;
        public System.Windows.Forms.Button btnCont;
        public System.Windows.Forms.Button btnHit;
        public System.Windows.Forms.Button btnStand;
        public System.Windows.Forms.Label lblLabel;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox btnBack;
    }
}