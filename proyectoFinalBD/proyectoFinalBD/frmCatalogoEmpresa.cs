using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoFinalBD.Resources;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Configuration;




namespace proyectoFinalBD
{
    public partial class frmCatalogoEmpresa : Form
    {
        public frmCatalogoEmpresa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCatalogoEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {


            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("exec  Sp_Ins_InventarioVehiculo  "+ txtId_Vehiculo.Text + "," + txtPlaca.Text + ",'"+ txtMarca.Text + "','" + txtModelo.Text + "','" + txtAno.Text + "','" + txtAno_Compra.Text +"'", conexion))

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
                            txtId_Vehiculo.Text = "";
                            txtPlaca.Text = "";
                            txtMarca.Text = "";
                            txtModelo.Text = "";
                            txtAno.Text = "";
                            txtAno_Compra.Text = "";
                            txtId_Vehiculo.Focus();

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //String respuesta = "";
            //try
            //{
            //    var consultas = new clsConsultas();

            //    respuesta = consultas.inserta_vehiculo(Convert.ToInt32(txtId_Vehiculo.Text), Convert.ToInt32(txtPlaca.Text), txtMarca.Text, txtModelo.Text, txtAno.Text, txtAno_Compra.Text);

            //}catch(Exception ex)
            //{

            //}
        }

        public void insertaCatalogo()
        {
        }
    }
}
