namespace Projeto1GroupBox
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpgb = new System.Windows.Forms.Label();
            this.pgbsplash = new System.Windows.Forms.ProgressBar();
            this.tmtsplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblpgb
            // 
            this.lblpgb.AutoSize = true;
            this.lblpgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpgb.Location = new System.Drawing.Point(372, 319);
            this.lblpgb.Name = "lblpgb";
            this.lblpgb.Size = new System.Drawing.Size(24, 25);
            this.lblpgb.TabIndex = 1;
            this.lblpgb.Text = "0";
            this.lblpgb.Click += new System.EventHandler(this.label1_Click);
            // 
            // pgbsplash
            // 
            this.pgbsplash.Location = new System.Drawing.Point(263, 347);
            this.pgbsplash.Name = "pgbsplash";
            this.pgbsplash.Size = new System.Drawing.Size(243, 23);
            this.pgbsplash.TabIndex = 2;
            // 
            // tmtsplash
            // 
            this.tmtsplash.Enabled = true;
            this.tmtsplash.Interval = 5;
            this.tmtsplash.Tick += new System.EventHandler(this.tmtsplash_Tick);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgbsplash);
            this.Controls.Add(this.lblpgb);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpgb;
        private System.Windows.Forms.ProgressBar pgbsplash;
        private System.Windows.Forms.Timer tmtsplash;
    }
}

