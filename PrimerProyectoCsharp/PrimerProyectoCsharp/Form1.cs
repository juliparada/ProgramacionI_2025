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
            int n = serie.Length;
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                suma += serie[i];
            }
            return suma / n;
        }
        double tipica(int[] serie, double m)
        {
            double tipica = 0;
            int n = serie.Length;

            for (int i = 0; i < n; i++)
            {
                tipica += Math.Pow(serie[i] - m, 2);
            }
            tipica = Math.Sqrt(tipica / n);
            return tipica;
        }
        double armonica(int[] serie)
        {
            double mediaArmonica = 0;
            int n = serie.Length;
            for (int i = 0; i < n; i++)
            {
                mediaArmonica += 1 / (double)serie[i];
            }
            return n / mediaArmonica;
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
