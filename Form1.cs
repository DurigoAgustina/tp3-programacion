using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void perimetro_Click(object sender, EventArgs e)
        {
            while (ladoA.Text.Trim() == "" || ladoB.Text.Trim() == "")
            {
                MessageBox.Show("Ambos campos deben ser completados");
                ladoA.Focus();
                return;
            }

            int ladoAx = Convert.ToInt32(ladoA.Text);
            int ladoBx = Convert.ToInt32(ladoB.Text);
            int resultadox = (ladoAx * 2) + (ladoBx * 2);

            resultado.Text = Convert.ToString(resultadox + " cm");
            
        }

        private void area_Click(object sender, EventArgs e)
        {
            while (ladoA.Text.Trim() == "" || ladoB.Text.Trim() == "")
            {
                MessageBox.Show("Ambos campos deben ser completados");
                ladoA.Focus();
                return;
            }

            int ladoAx = Convert.ToInt32(ladoA.Text);
            int ladoBx = Convert.ToInt32(ladoB.Text);
            int resultadox = ladoAx * ladoBx;

            resultado.Text = Convert.ToString(resultadox + " cm²");
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            ladoA.Clear();
            ladoB.Clear();
            resultado.Text="0";
            ladoA.Focus();
        }
    }
}
