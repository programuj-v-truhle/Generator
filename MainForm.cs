using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pole s abecedou a specialnimi znaky
            string[] abeceda = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] specialni = { "@", "!", "#", "$", "%", "^", "&", "*", "?" };

            // Vytvori instanci generatoru pseudonahodnych cisel
            Random rnd = new Random();

            // Generuj heslo...
            string Heslo = "";
            for (int i = 0; i < int.Parse(text_Delka.Text); i++)
            {
                int mod = rnd.Next()%4;
                if (mod == 0)
                    Heslo += rnd.Next(0, 9).ToString();
                else if (mod == 1)
                    Heslo += specialni[rnd.Next(0, specialni.Length)];
                else Heslo += abeceda[rnd.Next(0, abeceda.Length)];   
            }

            // Vypis vygenerovane heslo
            label_Vysledek.Text = String.Format("Generované heslo: {0}", Heslo);
        }
    }
}
