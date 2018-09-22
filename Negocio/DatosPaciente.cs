using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosPaciente
    {
        public IList<Paciente> listar() {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();
            Paciente paciente;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM PACIENTE";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    paciente = new Paciente();
                    
                    paciente.IdPaciente = (int) lector["IdPaciente"];
                    paciente.Nombre = lector.GetString(1);
                    paciente.Apellido = lector.GetString(2);
                    paciente.DNI = (int) lector["Documento"];
                    paciente.Edad = (int) lector["Edad"];
                    paciente.Fnac = (DateTime)lector["Fnac"];
                    paciente.IdObSocial = (int)lector["IdObSocial"];
                    paciente.ObSocial = lector.GetString(6);

                    lista.Add(paciente);
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
    }
}
