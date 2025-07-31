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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta;
            num1 = double.Parse(txtNum1.Text);

            num2 = double.Parse(txtNum2.Text);

            respuesta = num1 + num2;
            lblRespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
