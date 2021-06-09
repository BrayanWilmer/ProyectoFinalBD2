using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyectoFinalBD
{
    class clsConexion
    {
        public SqlConnection cnn;
        public Boolean  ObtenerConexion()
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Data source=DESKTOP-07LF0H8; Initial Catalog= db_ProyectoClasesManejo; User Id= sa; password=123456789");
                cnn.Open();
            }
            catch (Exception ex)
            {

            }

            return true;
            
        }


    }
}
