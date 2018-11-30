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

        public IList<Especialidad> ListarXmedico(int ID) {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Especialidad> lista = new List<Especialidad>();
            Especialidad aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT E.DESCRIPCION FROM ESPECIALIDADES AS E " +
                    "INNER JOIN ESPECIALIDADxMEDICO AS EM ON E.IDESPECIALIDAD = EM.IDESP " +
                    "WHERE EM.IDMED =" + ID;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Especialidad();

                    aux.DescEspecialidad = lector.GetString(0);
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

        public int BuscarIDEspecialidad(string Especialidad)
        {
            AccesoDB conexion = new AccesoDB();

            int ID;
            try
            {
                conexion.setearConsulta("SELECT IDESPECIALIDAD FROM ESPECIALIDADES WHERE DESCRIPCION = " + "'" + Especialidad +"'");

                conexion.abrir();

                ID = conexion.ejecutarAccionReturn();

                return ID;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void AltaEspecialidad(Especialidad NuevaEspecialidad)
        {
            AccesoDB conexion = new AccesoDB();

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO ESPECIALIDADES(DESCRIPCION) VALUES (@DESCRIPCION)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESCRIPCION", NuevaEspecialidad.DescEspecialidad);

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

        public void EliminarEspecialidad(int ID)
        {
            AccesoDB conexion = new AccesoDB();

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta(" DELETE FROM ESPECIALIDADES WHERE IDESPECIALIDAD = @ID");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Id", ID);
                conexion.abrir();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarEspecialidad(Especialidad E)
        {
            AccesoDB conexion = new AccesoDB();
            
            try
            {
                conexion.setearConsulta("UPDATE ESPECIALIDADES SET DESCRIPCION = @DESCRIPCION WHERE IDESPECIALIDAD = "+ E.IdEspecialidad);
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESCRIPCION", E.DescEspecialidad);

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
