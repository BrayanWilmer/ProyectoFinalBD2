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
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void txt_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("exec  sp_Ins_Contrato  " + txt_Contrato.Text + "," + txt_Sesiones.Text + ",'" + txt_FechaInicio.Text + "','" + txt_FechaFin.Text + "','" + txt_Costo.Text + "','" + txt_Estado.Text + "','" + txt_Instructor.Text + "','" + txt_Vehiculo.Text + "'", conexion))
                            
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Registro No Exitoso");

                            this.Hide();
                            frmMenu menu = new frmMenu();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Registro Exitoso");
                            txt_Contrato.Text = "";
                            txt_Vehiculo.Text = "";
                            txt_Sesiones.Text = "";
                            txt_FechaInicio.Text = "";
                            txt_FechaFin.Text = "";
                            txt_Costo.Text = "";
                            txt_Estado.Text = "";
                            txt_Instructor.Text = "";
                            txt_Vehiculo.Text = "";
                            txt_Contrato.Focus();
                        }



                        }

                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
