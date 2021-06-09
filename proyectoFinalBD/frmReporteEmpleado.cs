using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace proyectoFinalBD
{
    public partial class frmReporteEmpleado : Form
    {
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //dataGridView1
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();

                    SqlDataAdapter dataadapter = new SqlDataAdapter("EXEC sp_cons_reporte_cliente " + txtConsulta.Text, conexion);
                    dataadapter.Fill(ds, "Authors_table");
                    conexion.Close();
                    DataCliente.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void DataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //dataGridView1
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();

                    SqlDataAdapter dataadapter = new SqlDataAdapter("EXEC sp_cons_reporte_cliente 0" , conexion);
                    dataadapter.Fill(ds, "Authors_table");
                    conexion.Close();
                    DataCliente.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

                    SqlDataAdapter dataadapter = new SqlDataAdapter("EXEC sp_cons_reporte_cliente 0", conexion);
                    dataadapter.Fill(ds, "Authors_table");
                    conexion.Close();
                    DataCliente.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
