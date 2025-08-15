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
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);

            num2 = double.Parse(txtNum2.Text);

            //Suma
            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }
            //Resta
            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }
            //Multiplicación
            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }
            //División
            if (optDivision.Checked)
            {
                respuesta = num1 / num2;
            }
            //Exponenciación
            if (optExponenciacion.Checked)
            {
                respuesta = Math.Pow(num1, num2);  //se usa la biblioteca ya que no se puede realizar la ecuación
            }
            //Porcentaje
            if (optPorcentaje.Checked)
            {
                respuesta = (num1 * num2) / 100;
            }
            //Factorial
            if (optFactorial.Checked){
                int factorial = (int)num1;
                for (int i=(int)num1 - 1; i>1; i--){
                    factorial *= i;
                }
                respuesta = factorial;
            }
            lblRespuesta.Text = "Respuesta: " + respuesta;

            //Primo
            if (optPrimo.Checked){
                int i = 1, acum = 0;
                while (i <= num1 && acum <3){
                    if (num1 % i == 0){
                        acum++; //acum++ = acum +1
                    }
                    i++;
                }
                if (acum <= 2){
                    lblRespuesta.Text = "Respuesta: " + num1 + " es primo";
                }else{
                    lblRespuesta.Text = "Respuesta: " + num1 + " no es primo.";
                }
            }


        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            double num1,num2, respuesta=0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text); //ctrl+D para duplicar línea

            //switch evalúa la condición y devuelve el indice del elemento seleccionado
            switch (cboOpciones.SelectedIndex){
                case 0:
                    respuesta = num1 + num2; //Suma
                    break;

                case 1:
                    respuesta = num1 - num2; //Resta
                    break;

                case 2:
                    respuesta = num1 * num2; //Multiplicación
                    break;

                case 3:
                    respuesta = num1 / num2; //División
                    break;

                case 4:
                    respuesta = Math.Pow(num1, num2); //Exponenciación
                    break;

                case 5:
                    respuesta = (num1 * num2) / 100; //Porcentaje
                    break;

                case 6://Factorial
                    {
                        int factorial = (int)num1;
                        for (int i = (int)num1 - 1; i > 1; i--)
                        {
                            factorial *= i;
                        }
                        respuesta = factorial;

                        lblRespuesta.Text = "Respuesta: " + factorial;
                        break;
                    }

                case 7:
                    int b = 1, acum = 0;
                    while (b <= num1 && acum < 3)
                    {
                        if (num1 % b == 0)
                        {
                            acum++;
                        }
                        b++;
                    }
                    respuesta = (acum <= 2) ? 1 : 0; // 1 = primo, 0 = no primo
                    break;
            }

            // Mostrar resultado
            if (cboOpciones.SelectedIndex == 7)
            {
                lblRespuesta.Text = "Respuesta: " + num1 + ((respuesta == 1) ? " es primo." : " no es primo.");
            }
            else if (cboOpciones.SelectedIndex != 6) // Evita duplicar el texto del factorial
            {
                lblRespuesta.Text = "Respuesta: " + respuesta;
            }

        }

    }
}
