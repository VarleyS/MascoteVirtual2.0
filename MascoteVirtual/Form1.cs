using MascoteVirtual.Models;
using MascoteVirtual.Service;
using System;
using System.Collections.Generic;
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
            listBoxPokemon = new ListBox
            {
                Location = new System.Drawing.Point(205, 131),
                Size = new System.Drawing.Size(487, 277)
            };

            this.Controls.Add(listBoxPokemon);
        }

        private async void EventHandler(object sender, EventArgs e)
        {
            GetPokemon getPokemon = new GetPokemon();
            List<PokemonResults> pokemons = await getPokemon.GetPokemonRepository();

            listBoxPokemon.Items.Clear();
            foreach (var pokemon in pokemons)
            {
                if (pokemon != null)
                {
                    var ulrsprites = await getPokemon.GetSprites(pokemon.Url);

                    listBoxPokemon.Items.Add($"Name: {pokemon.Name}, IMAGE: {ulrsprites.front_default}");
                }

                
            }
        }
    }
}
