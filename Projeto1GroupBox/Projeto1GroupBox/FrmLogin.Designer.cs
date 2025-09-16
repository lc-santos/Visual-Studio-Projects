namespace Projeto1GroupBox
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lbluser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(310, 176);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(43, 13);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Usuário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(310, 228);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(38, 13);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Senha";
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(313, 270);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 4;
            this.btnenter.Text = "Entrar";
            this.btnenter.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(394, 270);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbluser);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}