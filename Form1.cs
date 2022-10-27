using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Tracker
{
    public partial class Form1 : Form
    {
        public static string[] pokemonArray = new string[4000];
        public static int lastClickedLabel = 0;
        PokemonSelection _pokemonSelection = null;
        public Form1()
        {
            InitializeVariables();
            InitializeComponent();
            InitializeComponentVariables();
        }
        public void InitializeVariables()
        {
            for (int i = 0; i < pokemonArray.Length; i++)
            {
                pokemonArray[i] = "???";
            }
        }
        public void InitializeComponentVariables()
        {
            comboBox1.SelectedIndex = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!comboBox1.DroppedDown)
            {
                label3.Text = pokemonArray[(comboBox1.SelectedIndex * 36)];
                label4.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 1];
                label5.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 2];
                label6.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 3];
                label7.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 4];
                label8.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 5];
                label14.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 6];
                label13.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 7];
                label12.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 8];
                label11.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 9];
                label10.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 10];
                label9.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 11];
                label43.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 12];
                label44.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 13];
                label45.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 14];
                label46.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 15];
                label47.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 16];
                label48.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 17];
                label22.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 18];
                label23.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 19];
                label26.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 20];
                label24.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 21];
                label25.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 22];
                label27.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 23];
                label28.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 24];
                label29.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 25];
                label30.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 26];
                label32.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 27];
                label33.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 28];
                label34.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 29];
                label31.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 30];
                label35.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 31];
                label38.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 32];
                label39.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 33];
                label37.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 34];
                label36.Text = pokemonArray[(comboBox1.SelectedIndex * 36) + 35];
            }
        }
        private void Pokemon_Label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            int.TryParse(lbl.Tag.ToString(), out lastClickedLabel);
            lastClickedLabel = lastClickedLabel + (36 * comboBox1.SelectedIndex);
            _pokemonSelection = new PokemonSelection();
            _pokemonSelection.Show();
        }
        private void Route_Area_Changed_Index(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1 || comboBox1.SelectedIndex > 103)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + textBox1.Text, pokemonArray);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pokemonArray = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + textBox1.Text);
        }
    }
}
