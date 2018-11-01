using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosEspecialidad
    {
        public IList<Especialidad> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Especialidad> lista = new List<Especialidad>();
            Especialidad aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM ESPECIALIDADES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {                            //LUEGO DE LA CONEXION HAY QUE HACER EL WHILE PARA
                                             //IR LEYENDO LOS DATOS DE LA TABLA
                    aux = new Especialidad();
                    aux.DescEspecialidad = lector.GetString(1);
                    aux.IdEspecialidad = (int) lector["IdEspecialidad"];

                lista.Add(aux);                              //POR ULTIMO AGREGAR SIEMPRE EL .ADD(AUX) PARA QUE LO QUE SE LEYO
                }                                                //LO GUARDE EN LA LISTA Y LO MUESTRE POR PANTALLA.

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
    }
}
