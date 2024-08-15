using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascoteVirtual.Service
{
    public class TelaMenu
    {

        public static void TelaInicial(Form form, PictureBox pictureBox)
        {
            string imgPath = "D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\ImagemTelaInicial\\TelaInit.png";

            if (pictureBox != null)
            {
                if (File.Exists(imgPath))
                {
                    Image img = Image.FromFile(imgPath);

                    pictureBox.Size = form.ClientSize;

                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox.Image = img;
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("PictureBox é nulo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
