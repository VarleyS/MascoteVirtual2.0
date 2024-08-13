using MascoteVirtual.Models;
using MascoteVirtual.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MascoteVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializaCustomCompoments();
        }

        private void InitializaCustomCompoments()
        {
            //listBoxPokemon = new ListBox
            //{
            //    Location = new System.Drawing.Point(205, 131),
            //    Size = new System.Drawing.Size(487, 277)
            //};

            //this.Controls.Add(listBoxPokemon);
        }

        private async void EventHandler(object sender, EventArgs e)
        {
            GetPokemon getPokemon = new GetPokemon();
            List<PokemonResults> pokemons = await getPokemon.GetPokemonRepository();

            await GetImage.BuscaImagem("bulbasaur");
            
            //await GetImage.ArmazenaImagem();



            PictureBox1(sender, e);

            //listBoxPokemon.Items.Clear();
            //foreach (var pokemon in pokemons)
            //{
            //    if (pokemon != null)
            //    {
            //        var ulrsprites = await getPokemon.GetSprites(pokemon.Url);

            //        listBoxPokemon.Items.Add($"Name: {pokemon.Name}, IMAGE: {ulrsprites.front_default}");
            //    }
            //}
        }

        private void PictureBox1(object sender, EventArgs e)
        {
            //configuração inicial do fomulário
            this.Text = "Exibir Imagem";
            this.Size = new System.Drawing.Size(800, 600);


            //inicializa e configura o PictureBox
            pictureBox2 = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill
            };

            //adiciona o PictureBox ao fomuláio
            this.Controls.Add(pictureBox2);

            //carrega e exibe a imagem
            LoadAndDisplayImage("D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\bulbasaur.jpg");
        }

        private void LoadAndDisplayImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox2.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
