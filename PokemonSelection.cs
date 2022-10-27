using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Tracker
{
    public partial class PokemonSelection : Form
    {
        public static bool hideForm = true;
        public PokemonSelection()
        {
            InitializeComponent();
            InitializeVariables();
        }
        public void InitializeVariables()
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.pokemonArray[Form1.lastClickedLabel] = comboBox1.Text;
            this.Hide();
        }
    }
}
