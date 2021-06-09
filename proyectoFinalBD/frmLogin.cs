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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void logins()
        {
            

            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM usuarios Where usuario='" + txtUsuario.Text + "'AND pass='" + txtPassword.Text + "'",conexion))

                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Login Exitoso");
                            
                            this.Hide();
                            frmMenu menu = new frmMenu();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vuelva a Intentarlo");
                            txtUsuario.Text = "";
                            txtPassword.Text = "";
                            txtUsuario.Focus();
                        }
                       
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
            
    
        private void button1_Click(object sender, EventArgs e)
        {

            logins();

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

    
}
