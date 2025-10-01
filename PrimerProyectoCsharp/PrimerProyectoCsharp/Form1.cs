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

        Conexion objCOnexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };

            grdAlumnos.DataSource = objDt.DefaultView;
            if (objDt.Rows.Count > 0)
            {
                if (posicion >= objDt.Rows.Count) posicion = objDt.Rows.Count - 1;
                if (posicion < 0) posicion = 0;
            }
            else
            {
                posicion = 0;
            }
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0 && posicion >= 0 && posicion < objDt.Rows.Count)
            {
                idAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistroAlumnos.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblnRegistroAlumnos.Text = "0 de 0";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = objDt.Rows.Count - 1;
                mostrarDatos();
            }
        }
        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = 0;
                mostrarDatos();
            }
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosAlumnos.Enabled = estado;
            grbNavegacionAlumnos.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] alumnos = {
                    idAlumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text,
                    txtTelefonoAlumno.Text
                };
                String respuesta = objCOnexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }
        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumno.Text,
                "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objCOnexion.administrarDatosAlumnos(
                    new String[] { idAlumno.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (posicion >= objDt.Rows.Count - 1)
                        posicion = objDt.Rows.Count - 2;
                    if (posicion < 0) posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatosAlumnos(txtBuscarAlumno.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatosAlumnos(string valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "Convert(codigo, 'System.String') LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%'";
                grdAlumnos.DataSource = objDv;

                // Busca la primera fila realmente visible y válida
                DataGridViewRow firstVisibleRow = null;
                foreach (DataGridViewRow row in grdAlumnos.Rows)
                {
                    if (!row.IsNewRow && row.Visible)
                    {
                        firstVisibleRow = row;
                        break;
                    }
                }

                if (firstVisibleRow != null)
                {
                    grdAlumnos.CurrentCell = firstVisibleRow.Cells[0];
                    seleccionarAlumno();
                }
                else
                {
                    limpiarControles();
                    lblnRegistroAlumnos.Text = "0 de 0";
                }
            }
            catch (Exception e)
            {
                // Opcional: puedes comentar este MessageBox para evitar spam de errores
                // MessageBox.Show(e.Message);
            }
        }
        private void seleccionarAlumno()
        {
            try
            {
                if (grdAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdAlumnos.CurrentRow.Cells["idAlumno"].Value.ToString();
                int idx = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                if (idx >= 0)
                {
                    posicion = idx;
                    mostrarDatos();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
