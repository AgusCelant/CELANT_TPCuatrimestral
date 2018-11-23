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
                comando.CommandText = "SELECT * FROM PACIENTE INNER JOIN OBRASOCIAL ON PACIENTE.IDOBSOCIAL = OBRASOCIAL.IDOS " +
                    "INNER JOIN DIRECCIONES ON PACIENTE.IDDIRECCION = DIRECCIONES.IDDIRECCION " +
                    "INNER JOIN LOCALIDADES ON DIRECCIONES.IDLOCALIDAD = LOCALIDADES.IDLOCALIDAD";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    paciente = new Paciente();
                    paciente.OS = new ObraSocial();
                    paciente.direccion = new Direccion();
                    paciente.direccion.Localidad = new Localidad();
                    
                    paciente.IdPaciente = (int) lector["IdPaciente"];
                    paciente.Nombre = lector.GetString(1);
                    paciente.Apellido = lector.GetString(2);
                    paciente.DNI = (int) lector["Documento"];
                    paciente.Fnac = (DateTime)lector["Fnac"];
                    paciente.OS.OS = lector.GetString(9);
                    paciente.Nafiliado = (int)lector["Nroafiliado"];
                    paciente.direccion.Calle = (string)lector["Calle"];
                    paciente.direccion.Numero = (int)lector["Numero"];
                    paciente.direccion.Localidad.Descripcion = (string)lector["Descripcion"];
                    paciente.direccion.Localidad.CPostal = (string)lector["CPostal"];
                    paciente.OBS = paciente.OS.OS;
                    paciente.Calle = paciente.direccion.Calle;
                    paciente.Numero = paciente.direccion.Numero;
                    paciente.Descripcion = paciente.direccion.Localidad.Descripcion;
                    paciente.CPostal = paciente.direccion.Localidad.CPostal;

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

        public void AltaPaciente(Paciente nuevo) {
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO DIRECCIONES (CALLE, NUMERO, IDLOCALIDAD) output inserted.IDDIRECCION VALUES(@Calle, @Numero, @IdLocalidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Calle", nuevo.direccion.Calle);
                conexion.Comando.Parameters.AddWithValue("@Numero", nuevo.direccion.Numero);
                conexion.Comando.Parameters.AddWithValue("@IdLocalidad", nuevo.direccion.Localidad.IdLocalidad);
                conexion.abrir();
                nuevo.direccion.Id = conexion.ejecutarAccionReturn();
                
                int IdDireccion = nuevo.direccion.Id;

                conexion.setearConsulta("INSERT INTO PACIENTE(NOMBRE, APELLIDO, DOCUMENTO, FNAC, IDOBSOCIAL, NROAFILIADO, IDDIRECCION) VALUES" +
                    "(@Nombre, @Apellido, @Documento, @Fnac, @IdObSocial, @NroAfiliado, @IdDireccion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@Documento", nuevo.DNI);
                conexion.Comando.Parameters.AddWithValue("@Fnac", nuevo.Fnac);
                conexion.Comando.Parameters.AddWithValue("@IdObSocial", nuevo.OS.IdOS);
                conexion.Comando.Parameters.AddWithValue("@NroAfiliado", nuevo.Nafiliado);
                conexion.Comando.Parameters.AddWithValue("@IdDireccion", IdDireccion);

                conexion.ejecutarAccion();

               
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void EliminarPaciente(int id) {
            AccesoDB conexion;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("DELETE FROM PACIENTE WHERE IDPACIENTE = @Id");
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


        public int BuscarIDPaciente(int DNI)
        {
            AccesoDB conexion = new AccesoDB();

            int ID;
            try
            {

                conexion.setearConsulta("SELECT IDPACIENTE FROM PACIENTE WHERE DOCUMENTO = " + DNI);
                
                conexion.abrir();

                ID = conexion.ejecutarAccionReturn();

                return ID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
