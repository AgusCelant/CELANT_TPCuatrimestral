using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Negocio
{
    public class AccesoDB
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        public SqlDataReader Lector {
            get { return lector; }
        }

        public SqlCommand Comando {
            get { return comando; }
        }

        public AccesoDB() {
            conexion = new SqlConnection("initial catalog = CLINICA; data source = DESKTOP-2IGJU5O\\SQLEXPRESS; integrated security = sspi"); 
        }
       
        //setear la consulta
        public void setearConsulta(string consulta) {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta; 
        }

        //abrir conexion
        public void abrir() {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //cerrar conexion
        public void cerrar() {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //ejecutar accion
        public void ejecutarAccion() {
            try
            {
                comando.Connection = conexion;
                comando.ExecuteNonQuery();     //--> Ejecuta una consulta y/o Accion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Leer consulta
        public void leerAccion() {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //ejecuta una accion con un return
        public int ejecutarAccionReturn()
        {
            try
            {
                comando.Connection = conexion;
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ejecutarAccionReturnSTRING()
        {
            try
            {
                comando.Connection = conexion;
                return (string)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
