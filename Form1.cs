using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesYEscaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dado dado = new Dado();
            Jugador j1 = new Jugador(1);
            Jugador j2 = new Jugador(2);
            int a, b;
            do
            {
                a = j1.Avanzar(dado.Lanzar());
                b = j2.Avanzar(dado.Lanzar());
                Resultado.Text = Resultado.Text + "J1: " + a.ToString() + Environment.NewLine;
                Resultado.Text = Resultado.Text + "J2: " + b.ToString() + Environment.NewLine;
                Resultado.Text = "___________________"; 
            } while (a <= 100 && b <= 100);
            if (a >= 100)
            {
              Resultado.Text = "El Jugador N°1 ganó!";
            }
            else if(b >=100)
            {
                Resultado.Text = "El Jugador N°2 ganó!";
            }
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
