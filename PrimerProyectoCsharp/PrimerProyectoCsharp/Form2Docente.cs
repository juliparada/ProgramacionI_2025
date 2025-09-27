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
    public partial class Form2Docente : Form
    {
        public Form2Docente()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["docente"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistroDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }
        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }
        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "Nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] docente = {
                    idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text, txtDireccionDocente.Text,
                    txtTelefonoDocente.Text
                };
                String respuesta = objConexion.administrarDatosDocentes(docente, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    actualizarDs();
                }
            }
        }
        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }
        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text,
                "Eliminando Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosDocentes(
                    new String[] { idDocente.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }
        private void txtBuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
            seleccionarDocente();
        }
        private void seleccionarDocente()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }
        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }
    }
}

