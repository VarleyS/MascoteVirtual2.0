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
            TelaMenu.TelaInicial(pictureBox3, axWindowsMediaPlayer1);

            //TelaMenu.TelaStart(this, pictureBox3, button7);
            
        }

        private async void EventHandler(object sender, EventArgs e)
        {
            GetPokemon getPokemon = new GetPokemon();
            List<PokemonResults> pokemons = await getPokemon.GetPokemonRepository();
            
            //await GetImage.ArmazenaImagem();



            PictureBox3(sender, e);

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

        //private void PictureBox1(object sender, EventArgs e)
        //{
        //    //configuração inicial do fomulário
        //    this.Text = "Exibir Imagem";
        //    this.Size = new System.Drawing.Size(800, 600);


        //    //inicializa e configura o PictureBox
        //    pictureBox2 = new PictureBox
        //    {
        //        SizeMode = PictureBoxSizeMode.StretchImage,
        //        Dock = DockStyle.Fill
        //    };

        //    //adiciona o PictureBox ao fomuláio
        //    this.Controls.Add(pictureBox2);
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void PictureBox3(object sender, EventArgs e)
        {
            string nomeImagem = "bulbasaur";
            await GetImage.BuscaImagem(nomeImagem, pictureBox3);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
