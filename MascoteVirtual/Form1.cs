using MascoteVirtual.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascoteVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void EventHandler(object sender, EventArgs e)
        {
            GetPokemon getPokemon = new GetPokemon();
            await getPokemon.GetPokemonRepository();
            MessageBox.Show("Funcionou!");
        }
    }
}
