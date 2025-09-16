using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Matrices
        //Funciones
        //LINQ = Lenguaje de Consulta Integrado

        double media(int[] serie)
        {
            return serie.Average();
        }
        double tipica(int[] serie, double m)
        {
            return Math.Sqrt(serie.Average(n => Math.Pow(n - m, 2)));
        }
        double armonica(int[] serie)
        {
            int n = serie.Length;
            return n / serie.Sum(num => 1.0 / num);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] serie = txtSerie.Text.Split(',').Select(n=>int.Parse(n)).ToArray(); //5,8,1,9 => ["5", "8", "1", "9"]
            //string[] serie = txtSerie.Text.Split(',');

            double mediaAritmetica = media(serie);
            double desviacionTipica = tipica(serie, mediaAritmetica);
            double mediaArmonica = armonica(serie);

            lblMedia.Text = "Media: " + mediaAritmetica.ToString();
            lblTipica.Text = "Tipica: " + desviacionTipica.ToString();
            lblArmonica.Text = "Armonica: " + mediaArmonica.ToString();
        }
    }
}
