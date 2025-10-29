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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexion objConexion = new conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
