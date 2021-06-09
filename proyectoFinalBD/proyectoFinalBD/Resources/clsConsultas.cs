using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoFinalBD;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace proyectoFinalBD.Resources
{ 
     class clsConsultas
    {
        public clsConexion ClsCnn = null;
        public StringBuilder strSQL = null;
        public SqlCommand Cmd = null;

        public String inserta_vehiculo(int p_id, int p_placa, String p_marca, String p_modelo, String p_ano, String p_fecha)
        {
            //String respuesta = "";

            try
            {
                ClsCnn = new clsConexion();
                strSQL = new StringBuilder();
                if (ClsCnn.ObtenerConexion())
                {
                    try
                    {
                      
                         SqlCommand Cmd = new SqlCommand();
                        
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "Sp_Ins_InventarioVehiculo";
                        
                        Cmd.Parameters.Add("@ID_VEHICULO", SqlDbType.Int).Value =  p_id;
                        Cmd.Parameters.Add("@PLACA", SqlDbType.Int).Value =  p_placa;
                        Cmd.Parameters.Add("@MARCA", SqlDbType.VarChar).Value =  p_marca;
                        Cmd.Parameters.Add("@MODELO", SqlDbType.VarChar).Value =  p_modelo;
                        Cmd.Parameters.Add("@ANO", SqlDbType.VarChar).Value =  p_ano;
                        Cmd.Parameters.Add("@FECHA_CPMRA", SqlDbType.VarChar).Value = p_fecha;
                        
                        Cmd.ExecuteNonQuery();

                        //SqlCommand Cmd = new SqlCommand();
                        //Cmd.CommandText = "Sp_Ins_InventarioVehiculo";
                        //Cmd.Connection = ClsCnn.cnn;
                        //Cmd.CommandType = CommandType.StoredProcedure;
                        //Cmd.Parameters.Add("@ID_VEHICULO", SqlDbType.Int).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["ID_VEHICULO"].Value = p_id;
                        //Cmd.Parameters.Add("PLACA", SqlDbType.Int).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["PLACA"].Value = p_placa;
                        //Cmd.Parameters.Add("MARCA", SqlDbType.VarChar).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["MARCA"].Value = p_marca;
                        //Cmd.Parameters.Add("MODELO", SqlDbType.VarChar).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["MODELO"].Value = p_modelo;
                        //Cmd.Parameters.Add("ANO", SqlDbType.VarChar).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["ANO"].Value = p_ano;
                        //Cmd.Parameters.Add("FECHA_CPMRA", SqlDbType.VarChar).Direction = ParameterDirection.Input;
                        //Cmd.Parameters["FECHA_CPMRA"].Value = p_fecha;
                        //Cmd.ExecuteNonQuery();



                    }
                    catch (Exception ex)
                    {
                        //clsLibs.EscribeLog("Xml Consulta - ERROR " + ex.Message, clsLibs.tNivel.Alto, clsLibs.tLog.Error);
                    }
                    finally
                    {
                        
                        ClsCnn = null;
                        Cmd = null;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return "ok";
        }


    }
}
