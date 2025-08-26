namespace App1
{
    partial class frmLogin
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(424, 252);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(103, 29);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Usuário";
            this.lbluser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(424, 380);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(87, 29);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Senha";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(657, 252);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(177, 22);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(657, 380);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(177, 22);
            this.txtpass.TabIndex = 4;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(429, 512);
            this.btnenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(164, 50);
            this.btnenter.TabIndex = 5;
            this.btnenter.Text = "Entrar";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(672, 512);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(164, 50);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1312, 937);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnclear;
    }
}