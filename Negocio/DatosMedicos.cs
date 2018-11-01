using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosMedicos
    {
        //FUNCION LISTAR LOS MEDICOS
        public IList<Medico> ListarMedicos() {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Medico> lista = new List<Medico>();
            Medico medico;

            try
            {
               conexion.ConnectionString= @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT IDMEDICO, NOMBRE, APELLIDO, EDAD, FNAC, NMATRICULA, E.IDESPECIALIDAD, E.DESCRIPCION FROM MEDICOS" +
                    " INNER JOIN ESPECIALIDADES AS E ON MEDICOS.IDESPECIALIDAD = E.IDESPECIALIDAD";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read()) {
                    
                    medico = new Medico();
                   
                    medico.IdMedico = (int)lector["IdMedico"];
                    medico.Nombre = lector.GetString(1);
                    medico.Apellido = lector.GetString(2);
                    medico.Edad = (int)lector["Edad"];
                    medico.Fnac = (DateTime)lector["Fnac"];
                    medico.Nmatricula = (int)lector["Nmatricula"];
                    //medico.especialidad.IdEspecialidad = (int)lector["IdEspecialidad"];
                   // medico.especialidad.DescEspecialidad = (string)lector["Descripcion"];
                    //medico.IdEspecialidad = medico.especialidad.IdEspecialidad;
                    //medico.Profesion = medico.especialidad.DescEspecialidad;
                    
                    lista.Add(medico);
                }
                
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
           
            
        }
        
        //FUNCION PARA DAR DE ALTA LOS MEDICOS
        public void AltaMedico(Medico nuevo) {

            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("insert into MEDICOS(nombre, apellido, edad, fnac, nmatricula, especialidad) values(@nombre, @apellido, @edad, @fnac, @nmatricula, @especialidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@edad", nuevo.Edad);
                conexion.Comando.Parameters.AddWithValue("@fnac", nuevo.Fnac);
                conexion.Comando.Parameters.AddWithValue("@nmatricula", nuevo.Nmatricula);

                conexion.abrir();
                conexion.ejecutarAccion();


                //cargar en la tabla espXmedico
                // recorro la lista de especialidades del objeto nuevo (medico)
                foreach (Especialidad nuevaEspecialidad in nuevo.Especialidades)
                {
                    // para cada especialidad en la lista llamar al metodo altaEspecialidadesXMedico
                    nuevaEspecialidad.AltaEspecialidadXMedico(nuevaEspecialidad);
                }

                //conexion.Comando.Parameters.AddWithValue("@especialidad", nuevo.especialidad.DescEspecialidad);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                if(conexion != null) {
                    conexion.cerrar();
                }
            }
        }

        public void EliminarMedico(int id) {
            AccesoDB conexion;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("Delete from MEDICOS where IdMedico = @Id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Id", id);
                conexion.abrir();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
