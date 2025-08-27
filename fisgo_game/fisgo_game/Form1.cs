using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace fisgo_game

{
    public partial class Form1 : Form 
    {

        bool irParaEsquerda, irParaDireita;
        int velocidadeJogador = 18;
        int velocidade2 = 22;
        int velocidadeObstaculo = 25;
        int velocidade3 = 20;
        int pontuacao = 0;
        Random rnd = new Random();
        string direcaoJogador = "esquerda";

        // Player de música

        // Player para a música de fundo (vamos renomear para ficar mais claro)
        WindowsMediaPlayer musicaFundo = new WindowsMediaPlayer();

        // --- NOVO PLAYER APENAS PARA EFEITOS SONOROS ---
        WindowsMediaPlayer sfxPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer sfxWin = new WindowsMediaPlayer();




        public Form1()
        {
            InitializeComponent();
            IniciarMusica();

            // --- CÓDIGO PARA TRANSPARÊNCIA REAL ---

            // 1. Define o PictureBox do fundo como o "pai" do jogador
            bggif.Controls.Add(jogador);
            // 2. Agora que ele tem um pai, a transparência funciona corretamente
            jogador.BackColor = Color.Transparent;

            // Fazemos o mesmo para o obstáculo
            bggif.Controls.Add(obstaculo);
            obstaculo.BackColor = Color.Transparent;

            bggif.Controls.Add(obstaculo2);
            obstaculo2.BackColor = Color.Transparent;

            bggif.Controls.Add(obstaculo3);
            obstaculo3.BackColor = Color.Transparent;


            // E também para o placar!
            bggif.Controls.Add(lblPontuacao);
            lblPontuacao.BackColor = Color.Transparent;


        }

        private void IniciarMusica()
        {
            musicaFundo.URL = "Audio/ost.mp3"; // Caminho do arquivo de música
            musicaFundo.settings.setMode("loop", true); // Define para repetir a música
            musicaFundo.settings.volume = 30; // Define o volume (0 a 100)
            musicaFundo.controls.play(); // Inicia a reprodução
        }

        private void MusicaLoss()
        {
            sfxPlayer.URL = "Audio/loss.mp3"; // Caminho do arquivo de música
            sfxPlayer.settings.setMode("loop", true); // Define para repetir a música
            sfxPlayer.settings.volume = 30; // Define o volume (0 a 100)
            sfxPlayer.controls.play(); // Inicia a reprodução
        }

        private void MusicaWin()
        {
            sfxWin.URL = "Audio/win.mp3"; // Caminho do arquivo de música
            sfxWin.settings.setMode("loop", false); 
            sfxWin.settings.volume = 30; // Define o volume (0 a 100)
            sfxWin.controls.play(); // Inicia a reprodução
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                irParaEsquerda = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                irParaDireita = true;
            }

            // --- LÓGICA DE MOVIMENTO E INVERSÃO ---
            if (e.KeyCode == Keys.Left)
            {
                irParaEsquerda = true;

                // Verifica se o jogador NÃO ESTÁ virado para a esquerda
                if (direcaoJogador != "direita")
                {
                    direcaoJogador = "direita";
                    jogador.Image = Properties.Resources.jogador_esquerda;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                irParaDireita = true;

                // Verifica se o jogador NÃO ESTÁ virado para a direita
                if (direcaoJogador != "esquerda")
                {
                    direcaoJogador = "esquerda";
                    jogador.Image = Properties.Resources.jogador_direita;
                }
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                irParaEsquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                irParaDireita = false;
            }
        }

        private void ReiniciarJogo()
        {
            // --- REINICIA AS VARIÁVEIS DO JOGO ---
            pontuacao = 0;
            irParaEsquerda = false;
            irParaDireita = false;
            velocidadeJogador = 18;
            velocidade2 = 22;
            velocidadeObstaculo = 25;
            velocidade3 = 20;
            jogador.Image = Properties.Resources.jogador_direita;
            musicaFundo.controls.play(); // Reinicia a música de fundo, caso tenha parado
            sfxPlayer.controls.stop(); // Para o som de perda, caso esteja tocando
            sfxWin.controls.stop();



            // --- REPOSICIONA OS ELEMENTOS ---
            // Coloca o jogador no centro inferior da tela

            // Reposiciona o obstáculo no topo em um lugar aleatório
            obstaculo.Top = -50;
            obstaculo.Left = rnd.Next(0, this.ClientSize.Width - obstaculo.Width);
            obstaculo2.Top = -50;
            obstaculo2.Left = rnd.Next(0, this.ClientSize.Width - obstaculo.Width);
            obstaculo3.Top = -50;
            obstaculo3.Left = rnd.Next(0, this.ClientSize.Width - obstaculo.Width);

            // --- ATUALIZA A INTERFACE ---
            lblPontuacao.Text = "Pontuação: 0";
            btnreset.Visible = false; // Esconde o botão de restart novamente

            // --- REATIVA O JOGO ---
            gametimer.Start();
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            // Atualiza o texto da pontuação
            lblPontuacao.Text = "Pontuação: " + pontuacao;

            // Movimentação do jogador
            if (irParaEsquerda == true && jogador.Left > 0)
            {
                jogador.Left -= velocidadeJogador;
            }
            if (irParaDireita == true && jogador.Left < this.ClientSize.Width - jogador.Width)
            {
                jogador.Left += velocidadeJogador;
            }

            // Movimentação do obstáculo
            obstaculo.Top += velocidadeObstaculo;

            // Se o obstáculo sair da tela
            if (obstaculo.Top > this.ClientSize.Height)
            {
                obstaculo.Top = -50; // Reposiciona no topo
                obstaculo.Left = rnd.Next(0, this.ClientSize.Width - obstaculo.Width); // Posição horizontal aleatória
                pontuacao++; // Aumenta a pontuação
            }

            // Verificação de colisão
            if (jogador.Bounds.IntersectsWith(obstaculo.Bounds))
            {
                gametimer.Stop(); // Para o jogo
                jogador.Image = Properties.Resources.losing;
                musicaFundo.controls.stop(); // Para a música de fundo
                MusicaLoss();
                btnreset.Visible = true; // Mostra o botão de reiniciar!
            }

            // Movimentação do obstáculo 2
            obstaculo2.Top += velocidade2;

            // Se o obstáculo sair da tela
            if (obstaculo2.Top > this.ClientSize.Height)
            {
                obstaculo2.Top = -50; // Reposiciona no topo
                obstaculo2.Left = rnd.Next(0, this.ClientSize.Width - obstaculo2.Width); // Posição horizontal aleatória
                pontuacao++; // Aumenta a pontuação
            }

            // Verificação de colisão
            if (jogador.Bounds.IntersectsWith(obstaculo2.Bounds))
            {
                gametimer.Stop(); // Para o jogo
                jogador.Image = Properties.Resources.losing;
                musicaFundo.controls.stop(); // Para a música de fundo
                MusicaLoss();
                btnreset.Visible = true; // Mostra o botão de reiniciar!
            }

            // Movimentação do obstáculo 3
            obstaculo3.Top += velocidade3;

            // Se o obstáculo sair da tela
            if (obstaculo3.Top > this.ClientSize.Height)
            {
                obstaculo3.Top = -50; // Reposiciona no topo
                obstaculo3.Left = rnd.Next(0, this.ClientSize.Width - obstaculo3.Width); // Posição horizontal aleatória
                pontuacao++; // Aumenta a pontuação
            }

            // Verificação de colisão
            if (jogador.Bounds.IntersectsWith(obstaculo3.Bounds))
            {
                gametimer.Stop(); // Para o jogo
                jogador.Image = Properties.Resources.losing;
                musicaFundo.controls.stop(); // Para a música de fundo
                MusicaLoss();
                btnreset.Visible = true; // Mostra o botão de reiniciar!
            }

            if (pontuacao >= 60)
            {
                velocidadeObstaculo = 30;
                velocidade2 = 27;
                velocidade3 = 25;
            }

            if (pontuacao >= 80)
            {
                velocidadeObstaculo = 33;
                velocidade2 = 31;
                velocidade3 = 32;
            }

            if (pontuacao >= 100)
            {
                gametimer.Stop();
                jogador.Image = Properties.Resources.winning2;
                musicaFundo.controls.stop();
                MusicaWin();
                MessageBox.Show("Parabéns! Você alcançou a pontuação máxima e venceu o jogo!", "Vitória");
                ReiniciarJogo();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jogador_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
            bggif.Focus();
        }

        private void bggif_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
