using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //IMPUESTO A LAS ACTIVIDADES
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[][] impuestos = new double[][]
            {
        new double[]{0.01, 500, 1.5, 0},
        new double[]{500.01, 1000, 1.5, 3},
        new double[]{1000.01, 2000, 3, 3},
        new double[]{2000.01, 3000, 6, 3},
        new double[]{3000.01, 6000, 9, 2},
        new double[]{8000.01, 18000, 15, 2},
        new double[]{18000.01, 30000, 39, 2},
        new double[]{30000.01, 60000, 63, 1},
        new double[]{60000.01, 100000, 93, 0.8},
        new double[]{100000.01, 200000, 125, 0.7},
        new double[]{200000.01, 300000, 195, 0.6},
        new double[]{300000.01, 400000, 255, 0.45},
        new double[]{400000.01, 500000, 300, 0.4},
        new double[]{500000.01, 1000000, 340, 0.3},
        new double[]{1000000.01, 9999999, 490, 0.18},
            };

            double monto_total = double.Parse(txtMonto.Text);
            double respuesta = 0;

            foreach (var tramo in impuestos)
            {
                double desde = tramo[0];
                double hasta = tramo[1];
                double precio = tramo[2];
                double adicional = tramo[3];

                if (monto_total >= desde && monto_total <= hasta)
                {
                    respuesta = ((monto_total - desde) / 1000) * adicional + precio;
                    break;
                }
            }

            lblMontoTotal.Text = "Respuesta: " + respuesta.ToString("N2");
        }

        //CONVERSOR DE AREAS (SUPERFICIE)
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double[] valores = new double[] { 0.092903, 0.835464, 0.836127, 1, 437.5, 7000, 10000 };

            double cantidad = double.Parse(txtCantidad.Text);

            int de = cboDeConvertir.SelectedIndex;
            int a = cboAConvertir.SelectedIndex;

            double cantidadEnMetros = cantidad * valores[de];
            double respuesta = cantidadEnMetros / valores[a]; 

            lblRespuesta.Text = "Respuesta: " + respuesta.ToString("N2");
        }
    }
}
