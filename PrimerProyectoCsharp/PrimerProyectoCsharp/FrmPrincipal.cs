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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();  
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Docente objDocentes = new Form2Docente();
            objDocentes.MdiParent = this;
            objDocentes.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateria objMateria = new FrmMateria();
            objMateria.MdiParent = this;
            objMateria.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos objPeriodo = new FrmPeriodos();
            objPeriodo.MdiParent = this;
            objPeriodo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotas objNota = new FrmNotas();
            objNota.MdiParent = this;
            objNota.Show();
        }

        private void detallesDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
