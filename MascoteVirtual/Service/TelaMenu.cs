using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascoteVirtual.Service
{
    public class TelaMenu
    {
        private static SoundPlayer soundPlayer;

        public static void TelaInicial(PictureBox pictureBox, AxWindowsMediaPlayer mediaPlayer)
        {
            string videoPath = "D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\ImagemTelaInicial\\introducao.mp4";
            int ex = 1;

            if (mediaPlayer != null)
            {
                if (File.Exists(videoPath))
                {
                    //define o tamanho do mediaPlayer para o tamanho do formulário
                    mediaPlayer.Size = pictureBox.ClientSize;

                    //configura o caminho do vídeo
                    mediaPlayer.URL = videoPath;

                    //Inicia a reprodução automática
                    mediaPlayer.Ctlcontrols.play();


                    //Associa o evento PlayStateChange para verificar o final do vídeo
                    mediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
                }
                else
                {
                    MessageBox.Show("Vídeo não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Media Player é nulo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void MediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            //verifica se o status do stopped (vídeo concluído)
            if(e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                // ação após o vídeo terminar
                MessageBox.Show("Vídeo concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void TelaStart(Form1 form,PictureBox pictureBox, Button startButton)
        {
            string gifPath = "D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\ImagemTelaInicial\\Gif\\gif into.gif";

            string audioPath = "D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\ImagemTelaInicial\\audios\\TitleScreen.wav";


            if(pictureBox != null && File.Exists(gifPath) && File.Exists(audioPath)) 
            {
                //configuração do pictureBox para exibir gif em loop
                pictureBox.Image = Image.FromFile(gifPath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;

                //configuração de audio
                soundPlayer = new SoundPlayer(audioPath);
                soundPlayer.Play();

                //configuração de botão start para interromper o audio
                startButton.Click += (sender, e) =>
                {
                    soundPlayer.Stop();
                    pictureBox.Image = null; //interrompe a exibição do gif
                };

            }
            else{
                MessageBox.Show("Gif ou aúdio não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
