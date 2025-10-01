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
    public partial class FrmMateria : Form
    {
        public FrmMateria()
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
            objDs.Clear(); // Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };

            grdMateria.DataSource = objDt.DefaultView;
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
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUvMateria.Text = objDt.Rows[posicion]["uv"].ToString();

                lblnRegistroMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblnRegistroMateria.Text = "0 de 0";
            }
        }

        private void FrmMateria_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimaMateria_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = objDt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        private void btnPrimerMateria_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = 0;
                mostrarDatos();
            }
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUvMateria.Text = "";
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (btnAgregarMateria.Text == "Nuevo")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] materias = {
                    idMateria.Text, txtCodigoMateria.Text, txtNombreMateria.Text, txtUvMateria.Text
                };
                String respuesta = objConexion.administrarDatosMaterias(materias, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMateria.Text,
                "Eliminando Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosMaterias(
                    new String[] { idMateria.Text, "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtBuscarMateria_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarMateria.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "Convert(codigo, 'System.String') LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%'";
                grdMateria.DataSource = objDv;
                seleccionarMateria();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void seleccionarMateria()
        {
            try
            {
                if (grdMateria.CurrentRow == null)
                {
                    // No hay filas seleccionadas
                    return;
                }

                // Validar que la columna idMateria existe en el DataGridView
                if (!grdMateria.Columns.Contains("idMateria"))
                {
                    // No hacer nada si la columna no existe
                    return;
                }

                string id = grdMateria.CurrentRow.Cells["idMateria"].Value?.ToString();
                if (string.IsNullOrEmpty(id))
                    return;

                int idx = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                if (idx >= 0)
                {
                    posicion = idx;
                    mostrarDatos();
                }
            }
            catch (Exception e)
            {
                // Puedes comentar o eliminar este MessageBox si no quieres mostrar errores al usuario
                // MessageBox.Show(e.Message);
            }
        }
    }
}
