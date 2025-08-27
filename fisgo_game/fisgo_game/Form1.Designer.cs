namespace fisgo_game
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jogador = new System.Windows.Forms.PictureBox();
            this.obstaculo = new System.Windows.Forms.PictureBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.obstaculo2 = new System.Windows.Forms.PictureBox();
            this.bggif = new System.Windows.Forms.PictureBox();
            this.obstaculo3 = new System.Windows.Forms.PictureBox();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bggif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo3)).BeginInit();
            this.SuspendLayout();
            // 
            // jogador
            // 
            this.jogador.BackColor = System.Drawing.Color.Transparent;
            this.jogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jogador.Image = ((System.Drawing.Image)(resources.GetObject("jogador.Image")));
            this.jogador.InitialImage = null;
            this.jogador.Location = new System.Drawing.Point(476, 575);
            this.jogador.Margin = new System.Windows.Forms.Padding(2);
            this.jogador.Name = "jogador";
            this.jogador.Size = new System.Drawing.Size(145, 145);
            this.jogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jogador.TabIndex = 0;
            this.jogador.TabStop = false;
            this.jogador.Click += new System.EventHandler(this.jogador_Click);
            // 
            // obstaculo
            // 
            this.obstaculo.BackColor = System.Drawing.Color.Transparent;
            this.obstaculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstaculo.BackgroundImage")));
            this.obstaculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obstaculo.Location = new System.Drawing.Point(256, 28);
            this.obstaculo.Name = "obstaculo";
            this.obstaculo.Size = new System.Drawing.Size(36, 131);
            this.obstaculo.TabIndex = 1;
            this.obstaculo.TabStop = false;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPontuacao.Location = new System.Drawing.Point(27, 28);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(173, 25);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "Pontuação: 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // obstaculo2
            // 
            this.obstaculo2.BackColor = System.Drawing.Color.Transparent;
            this.obstaculo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstaculo2.BackgroundImage")));
            this.obstaculo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obstaculo2.Location = new System.Drawing.Point(464, 28);
            this.obstaculo2.Name = "obstaculo2";
            this.obstaculo2.Size = new System.Drawing.Size(34, 142);
            this.obstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstaculo2.TabIndex = 3;
            this.obstaculo2.TabStop = false;
            this.obstaculo2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bggif
            // 
            this.bggif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bggif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bggif.Image = ((System.Drawing.Image)(resources.GetObject("bggif.Image")));
            this.bggif.Location = new System.Drawing.Point(0, 0);
            this.bggif.Name = "bggif";
            this.bggif.Size = new System.Drawing.Size(984, 761);
            this.bggif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bggif.TabIndex = 5;
            this.bggif.TabStop = false;
            this.bggif.Click += new System.EventHandler(this.bggif_Click);
            // 
            // obstaculo3
            // 
            this.obstaculo3.BackColor = System.Drawing.Color.Transparent;
            this.obstaculo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstaculo3.BackgroundImage")));
            this.obstaculo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obstaculo3.Location = new System.Drawing.Point(737, 12);
            this.obstaculo3.Name = "obstaculo3";
            this.obstaculo3.Size = new System.Drawing.Size(34, 142);
            this.obstaculo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstaculo3.TabIndex = 4;
            this.obstaculo3.TabStop = false;
            this.obstaculo3.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(409, 348);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(201, 49);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "Tentar novamente?";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Visible = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.obstaculo3);
            this.Controls.Add(this.obstaculo2);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.obstaculo);
            this.Controls.Add(this.jogador);
            this.Controls.Add(this.bggif);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisgo Caves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.jogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bggif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jogador;
        private System.Windows.Forms.PictureBox obstaculo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox obstaculo2;
        private System.Windows.Forms.PictureBox bggif;
        private System.Windows.Forms.PictureBox obstaculo3;
        private System.Windows.Forms.Button btnreset;
    }
}

