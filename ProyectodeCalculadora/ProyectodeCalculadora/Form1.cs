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
            //Hacer un ejercicio en C# haciendo uso de matrices, estrucutras de repetición y condicionales
            //que determine el sueldo a pagar a un empleado descontando las deducciones correspondientes de ley
            //ISS, AFP, ISR.
        }

        private double[][] tablaIsr ={
                new Double[] { 0.01, 550, 0, 0 },
                new Double[] {550.01, 895.24, 0.10, 17.67},
                new Double[] {895.25, 2038.10, 0.20, 60},
                new Double[] { 2038.11, double.MaxValue, 0.30, 288.57} //.MaxValue es como decir "de 2038.11 en adelante"
        };
                
        private double calcularDeducciones(double sueldo, double porcentaje){
            return sueldo * porcentaje;
        }

        private double calcularIsr(double sueldo){
            double isr = 0;
            for (int i = 0; i< tablaIsr.Length; i++) {
                if(sueldo >= tablaIsr[i][0] && sueldo <= tablaIsr[i][1]){
                    isr = (sueldo - tablaIsr[i][0]) * tablaIsr[i][2] + tablaIsr[i][3];
                }
            }
            return isr;
        }

         private void button1_Click(object sender, EventArgs e){
            double sueldo = 0, isss = 0, afp = 0, isr = 0, sueldoNeto = 0;
            sueldo = double.Parse(txtSueldo.Text);

            isss = calcularDeducciones(sueldo, 0.03); //3% de ISSS (->)dividido 3/100=0.03
            afp = calcularDeducciones(sueldo, 0.0725); //7.25% de AFP  (->)dividido 7.25/100=0.0725
            isr = calcularIsr(sueldo - isss - afp); //calcular ISR

            sueldoNeto = sueldo - isss - afp - isr; // Calcular sueldo neto

            System.Globalization.CultureInfo usCulture = new System.Globalization.CultureInfo("en-US");

            lblIsss.Text = "ISSS: " + isss.ToString("C2", usCulture);
            lblAfp.Text = "AFP: " + afp.ToString("C2", usCulture);
            lblIsr.Text = "ISR: " + isr.ToString("C2", usCulture);
            lblDeducciones.Text = "Total deducciones: " + (isss + afp + isr).ToString("C2", usCulture);
            lblSueldoNeto.Text = "Sueldo Neto: " + sueldoNeto.ToString("C2", usCulture);
        }
    }
}
