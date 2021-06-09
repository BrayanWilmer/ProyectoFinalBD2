using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace proyectoFinalBD
{
    public partial class frmReporteEmpresa : Form
    {
        public frmReporteEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //dataGridView1
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();

                        SqlDataAdapter dataadapter = new SqlDataAdapter("exec  sp_cons_reporte_contrato ", conexion);
                    
                    dataadapter.Fill(ds, "Authors_table");
                    
                    dataGridView1.DataSource = ds.Tables[0];
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
