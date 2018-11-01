using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosOS
    {
        public IList<ObraSocial> listarOS() {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<ObraSocial> lista = new List<ObraSocial>();
            ObraSocial OS;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM OBRASOCIAL";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                    OS = new ObraSocial();

                    OS.IdOS = (int)lector["IdOS"];
                    OS.OS = lector.GetString(1);
                    OS.Telefono = (int)lector["Telefono"];
                    OS.Mail = lector.GetString(3);

                   lista.Add(OS);
                }
                
               return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //FUNCION PARA DAR DE ALTA OBRA SOCIAL
        public void AltaOS(ObraSocial nuevo) {
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO OBRASOCIAL(NOMBRE, TELEFONO, MAIL) VALUES (@NOMBRE, @TELEFONO, @MAIL) ");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.OS);
                conexion.Comando.Parameters.AddWithValue("@TELEFONO", nuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@MAIL", nuevo.Mail);
                
                conexion.abrir();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrar();
                }
            }
        }
    }
}
