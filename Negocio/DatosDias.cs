using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosDias
    {
        public IList<Dia> listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Dia> lista = new List<Dia>();
            Dia aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM DIAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Dia();
                    aux.IdDay = (int)lector["IDDIA"];
                    aux.Day = lector.GetString(1);
                   
                    lista.Add(aux);
                }    
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                lector = null;
                conexion.Close();
            }
        }

        public IList<Dia> ListarXMedico(int ID)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Dia> lista = new List<Dia>();
            Dia aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT D.IDDIA, D.DIA FROM DIAS AS D " +
                    "INNER JOIN DIASxMEDICO AS DM ON D.IDDIA = DM.IDDIA " +
                    "WHERE DM.IDMED =" + ID;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Dia();

                    aux.IdDay = (int)lector["IDDIA"];
                    aux.Day = lector.GetString(1);
                    
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                lector = null;
                conexion.Close();
            }
        }
        
    }
}
