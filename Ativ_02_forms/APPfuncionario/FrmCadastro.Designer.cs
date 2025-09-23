namespace APPfuncionario
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.gpbdados = new System.Windows.Forms.GroupBox();
            this.gpbaddress = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblestate = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.cbbestado = new System.Windows.Forms.ComboBox();
            this.cbbuf = new System.Windows.Forms.ComboBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.gpbdados.SuspendLayout();
            this.gpbaddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbdados
            // 
            this.gpbdados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbdados.Controls.Add(this.txtrg);
            this.gpbdados.Controls.Add(this.txtcpf);
            this.gpbdados.Controls.Add(this.pictureBox1);
            this.gpbdados.Controls.Add(this.txtname);
            this.gpbdados.Controls.Add(this.lblrg);
            this.gpbdados.Controls.Add(this.lblcpf);
            this.gpbdados.Controls.Add(this.lblname);
            this.gpbdados.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbdados.Location = new System.Drawing.Point(51, 47);
            this.gpbdados.Name = "gpbdados";
            this.gpbdados.Size = new System.Drawing.Size(695, 157);
            this.gpbdados.TabIndex = 0;
            this.gpbdados.TabStop = false;
            this.gpbdados.Text = "Dados Pessoais";
            // 
            // gpbaddress
            // 
            this.gpbaddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbaddress.Controls.Add(this.cbbuf);
            this.gpbaddress.Controls.Add(this.cbbestado);
            this.gpbaddress.Controls.Add(this.txtbairro);
            this.gpbaddress.Controls.Add(this.txtcomp);
            this.gpbaddress.Controls.Add(this.txtcity);
            this.gpbaddress.Controls.Add(this.txtnumber);
            this.gpbaddress.Controls.Add(this.txtlog);
            this.gpbaddress.Controls.Add(this.txtcep);
            this.gpbaddress.Controls.Add(this.lblbairro);
            this.gpbaddress.Controls.Add(this.lblcomp);
            this.gpbaddress.Controls.Add(this.lbluf);
            this.gpbaddress.Controls.Add(this.lblestate);
            this.gpbaddress.Controls.Add(this.lblcity);
            this.gpbaddress.Controls.Add(this.lblnumber);
            this.gpbaddress.Controls.Add(this.lbllog);
            this.gpbaddress.Controls.Add(this.lblcep);
            this.gpbaddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbaddress.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbaddress.Location = new System.Drawing.Point(51, 210);
            this.gpbaddress.Name = "gpbaddress";
            this.gpbaddress.Size = new System.Drawing.Size(695, 175);
            this.gpbaddress.TabIndex = 1;
            this.gpbaddress.TabStop = false;
            this.gpbaddress.Text = "Endereço";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(47, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(47, 69);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(43, 20);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "CPF";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(47, 99);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(36, 20);
            this.lblrg.TabIndex = 2;
            this.lblrg.Text = "RG";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(115, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(46, 40);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(37, 21);
            this.lblcep.TabIndex = 0;
            this.lblcep.Text = "CEP";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Location = new System.Drawing.Point(195, 40);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(100, 21);
            this.lbllog.TabIndex = 1;
            this.lbllog.Text = "Logradouro";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(417, 40);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(64, 21);
            this.lblnumber.TabIndex = 2;
            this.lblnumber.Text = "Número";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(47, 90);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(64, 21);
            this.lblcity.TabIndex = 3;
            this.lblcity.Text = "Cidade";
            // 
            // lblestate
            // 
            this.lblestate.AutoSize = true;
            this.lblestate.Location = new System.Drawing.Point(221, 90);
            this.lblestate.Name = "lblestate";
            this.lblestate.Size = new System.Drawing.Size(64, 21);
            this.lblestate.TabIndex = 4;
            this.lblestate.Text = "Estado";
            this.lblestate.Click += new System.EventHandler(this.lblestate_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(435, 90);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(28, 21);
            this.lbluf.TabIndex = 5;
            this.lbluf.Text = "UF";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(46, 137);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(109, 21);
            this.lblcomp.TabIndex = 6;
            this.lblcomp.Text = "Complemento";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(293, 137);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(64, 21);
            this.lblbairro.TabIndex = 7;
            this.lblbairro.Text = "Bairro";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(89, 40);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(100, 26);
            this.txtcep.TabIndex = 8;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(297, 40);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(100, 26);
            this.txtlog.TabIndex = 9;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(485, 40);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 26);
            this.txtnumber.TabIndex = 10;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(115, 84);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 26);
            this.txtcity.TabIndex = 11;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(161, 134);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 26);
            this.txtcomp.TabIndex = 12;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(363, 134);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 26);
            this.txtbairro.TabIndex = 13;
            // 
            // cbbestado
            // 
            this.cbbestado.FormattingEnabled = true;
            this.cbbestado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbbestado.Location = new System.Drawing.Point(297, 82);
            this.cbbestado.Name = "cbbestado";
            this.cbbestado.Size = new System.Drawing.Size(121, 29);
            this.cbbestado.TabIndex = 14;
            this.cbbestado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbuf
            // 
            this.cbbuf.FormattingEnabled = true;
            this.cbbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbuf.Location = new System.Drawing.Point(485, 84);
            this.cbbuf.Name = "cbbuf";
            this.cbbuf.Size = new System.Drawing.Size(121, 29);
            this.cbbuf.TabIndex = 15;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(115, 69);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 22);
            this.txtcpf.TabIndex = 17;
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(115, 99);
            this.txtrg.Mask = "00.000.000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 22);
            this.txtrg.TabIndex = 18;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(123, 391);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(134, 40);
            this.btnnew.TabIndex = 19;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(335, 391);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 40);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(544, 391);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 40);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Voltar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.gpbaddress);
            this.Controls.Add(this.gpbdados);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.gpbdados.ResumeLayout(false);
            this.gpbdados.PerformLayout();
            this.gpbaddress.ResumeLayout(false);
            this.gpbaddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbdados;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox gpbaddress;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblestate;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.ComboBox cbbuf;
        private System.Windows.Forms.ComboBox cbbestado;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
    }
}