using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_II
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        conexion objConexion = new conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };

            grbUsuarios.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                lblUsuariosId.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuarioUsuarios.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtClaveUsuarios.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuarios.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionUsuarios.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuarios.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosUsuarios.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }


        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_parcialIIDataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_parcialIIDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.db_parcialIIDataSet.usuario);

        }

        private void estadoControles(Boolean estado)
        {
            grbUsuarios.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }
        private void limpiarControles()
        {
            lblUsuariosId.Text = "0";
            txtUsuarioUsuarios.Text = "";
            txtClaveUsuarios.Text = "";
            txtNombreUsuarios.Text = "";
            txtDireccionUsuarios.Text = "";
            txtTelefonoUsuarios.Text = "";
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (btnAgregarUsuario.Text == "Nuevo")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] usuario = {
                    lblUsuariosId.Text, txtUsuarioUsuarios.Text, txtClaveUsuarios.Text, txtNombreUsuarios.Text, txtDireccionUsuarios.Text, txtTelefonoUsuarios.Text, txtTelefonoUsuarios.Text
                };
                String respuesta = objConexion.administrarDatosUsuarios(usuario, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    actualizarDs();
                }
            }
        }
        




    }
}
