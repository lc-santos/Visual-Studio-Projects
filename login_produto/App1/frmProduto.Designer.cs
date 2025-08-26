namespace App1
{
    partial class frmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblfact = new System.Windows.Forms.Label();
            this.cbbfact = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtvalue);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.cbbfact);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblvalue);
            this.panel1.Controls.Add(this.lblfact);
            this.panel1.Location = new System.Drawing.Point(199, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 289);
            this.panel1.TabIndex = 0;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(197, 137);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(188, 24);
            this.lblprod.TabIndex = 1;
            this.lblprod.Text = "Dados do Produtos";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(35, 63);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 24);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nome";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue.Location = new System.Drawing.Point(39, 117);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(59, 24);
            this.lblvalue.TabIndex = 3;
            this.lblvalue.Text = "Valor";
            this.lblvalue.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfact
            // 
            this.lblfact.AutoSize = true;
            this.lblfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfact.Location = new System.Drawing.Point(39, 176);
            this.lblfact.Name = "lblfact";
            this.lblfact.Size = new System.Drawing.Size(109, 24);
            this.lblfact.TabIndex = 4;
            this.lblfact.Text = "Fabricante";
            this.lblfact.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbbfact
            // 
            this.cbbfact.FormattingEnabled = true;
            this.cbbfact.Items.AddRange(new object[] {
            "Tabajara",
            "Kagohara",
            "Madruga",
            "Los Hermanos",
            "Volin Rabarh",
            ""});
            this.cbbfact.Location = new System.Drawing.Point(174, 176);
            this.cbbfact.Name = "cbbfact";
            this.cbbfact.Size = new System.Drawing.Size(145, 21);
            this.cbbfact.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(174, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(145, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(174, 117);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(145, 20);
            this.txtvalue.TabIndex = 2;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(238, 527);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(147, 55);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(455, 527);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(147, 55);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cbbfact;
        private System.Windows.Forms.Label lblfact;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}