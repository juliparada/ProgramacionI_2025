using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectodeCalculadora
{
    public partial class form1 : Form
    {
        public form1(){
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e) {
            //MATRIZ UNIDIMENCIONAL
            //Serie de nùmeros que los convertimos usando Split en una matriz
            //Es como decir String[] m = new String[]{"5", "10", "15"}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblSuma.Text = txtSerie.Text;
            string[] serie = txtSerie.Text.Split(','); //toma una cadena y lo divide en una matriz 5,10,15 =>["5", "10", "15"]

            int suma = 0;
            for (int i = 0; i < serie.Length; i++) {
                suma = suma + int.Parse(serie[i]);
            }
            lblSuma.Text = "Suma: " + suma;
            //lblSuma.Text = "Suma: " + serie.Sum();

        }
    }
}
