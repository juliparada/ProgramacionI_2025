using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        Conexion objConexion = new Conexion(); 
        DataSet objDs = new DataSet(); 
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs() {
            objDs.Clear(); //Limpio el DataSet
            objDs = objConexion.obtenerDatos(); //Obtengo los datos de la BD
            objDt = objDs.Tables["alumnos"]; //Me posiciono en la tabla alumnos del DataSet
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };//Defino la clave primaria de la tabla

            mostrarDatos();
        }

        private void mostrarDatos() {
            if (objDt.Rows.Count > 0) {
                idAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistroAlumnos.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e){
            actualizarDs();
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e){
            if (posicion < objDt.Rows.Count - 1) {
                posicion++; //posicion = posicion + 1
                mostrarDatos();
            }else{
                MessageBox.Show("Estas en el último registro", "Navegación de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e){
            if (posicion > 0){
                posicion--; //posicion = posicion - 1
                mostrarDatos();
            }else{
                MessageBox.Show("Estas en el primer registro", "Navegación de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e){
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e){
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado){
            grbDatosAlumnos.Enabled = estado;//Pasa de estar activo a inactivo cuando se presiona el botón nuevo
            grbNavegacionAlumnos.Enabled = !estado;//Pasa de estar inactivo a activo cuando se presiona el botón nuevo
            btnEliminarAlumno.Enabled = !estado;
        }
         
        private void limpiarControles(){
            idAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e){
            if (btnAgregarAlumno.Text == "Nuevo"){
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }else{//Guardar
                String[] Alumnos ={
                    idAlumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text
                };
                String respuesta = objConexion.administrarDatosAlumnos(Alumnos, accion);
                if (respuesta != "1"){
                    MessageBox.Show(respuesta, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else {//si no hay error que se guarde
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e){
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }else{//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e){
            if (MessageBox.Show("Usted esta seguro de eliminar " + txtNombreAlumno.Text, "Eliminando Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes){
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] {idAlumno.Text, "", "", "", ""}, "eliminar"
                    );
                if (respuesta != "1"){
                    MessageBox.Show(respuesta, "Error al eliminar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else{ //si no hay error que se elimine
                    posicion = 0;
                    actualizarDs();
                }
            }
        }


    }
}
