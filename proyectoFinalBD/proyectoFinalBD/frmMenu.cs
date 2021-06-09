using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalBD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catalogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCatalogoEmpresa catalgo = new frmCatalogoEmpresa();
            catalgo.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDetalle detalle = new frmDetalle();
            detalle.Show();
        }

        private void detalleEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporteEmpleado RptEmpleado = new frmReporteEmpleado();
            RptEmpleado.Show();
        }

        private void detalleEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporteEmpresa RptEmpresa = new frmReporteEmpresa();
            RptEmpresa.Show();
        }
    }
}
