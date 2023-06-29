namespace CapStone
{
    partial class Stats
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
            this.lblBJ = new System.Windows.Forms.Label();
            this.lblC8 = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBJ
            // 
            this.lblBJ.AutoSize = true;
            this.lblBJ.Location = new System.Drawing.Point(13, 63);
            this.lblBJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBJ.Name = "lblBJ";
            this.lblBJ.Size = new System.Drawing.Size(14, 84);
            this.lblBJ.TabIndex = 0;
            this.lblBJ.Text = "l\r\nl\r\nl\r\nl";
            // 
            // lblC8
            // 
            this.lblC8.AutoSize = true;
            this.lblC8.Location = new System.Drawing.Point(13, 176);
            this.lblC8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC8.Name = "lblC8";
            this.lblC8.Size = new System.Drawing.Size(14, 84);
            this.lblC8.TabIndex = 1;
            this.lblC8.Text = "l\r\nl\r\nl\r\nl\r\n";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(13, 297);
            this.lblW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(14, 84);
            this.lblW.TabIndex = 3;
            this.lblW.Text = "l\r\nl\r\nl\r\nl\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 4;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblC8);
            this.Controls.Add(this.lblBJ);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBJ;
        private System.Windows.Forms.Label lblC8;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label label1;
    }
}