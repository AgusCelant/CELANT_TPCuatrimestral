using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient; 

namespace Negocio
{
    public class DatosUsuario
    {
        public void AltaUsuario(Medico M)
        {
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO USUARIOS(USUARIO, PASS) VALUES (@USUARIO, @PASS) ");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@USUARIO", M.Apellido);
                conexion.Comando.Parameters.AddWithValue("@PASS", M.Nmatricula); 
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


        public bool Validar(Usuarios usuarios)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"select USUARIO, pass from USUARIOS where USUARIO = @USUARIO AND PASS = @PASS";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@USUARIO", usuarios.Descripcion);
                comando.Parameters.AddWithValue("@PASS", usuarios.Pass);
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                
                if(lector.Read())
                {
                    usuarios.Descripcion = (string)lector["USUARIO"];
                    usuarios.Pass = (int)lector["PASS"];
                    
                    return true;
                }
                else
                {
                    return false;
                }
                            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
