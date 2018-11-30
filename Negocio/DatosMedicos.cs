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
                comando.CommandText = "SELECT M.IDMEDICO, M.NOMBRE, M.APELLIDO, M.EDAD, M.FNAC, M.NMATRICULA FROM MEDICOS AS M";
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
        public void AltaMedico(ref Medico nuevo) {

            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("insert into MEDICOS(nombre, apellido, edad, fnac, nmatricula) output inserted.IDMEDICO values(@nombre, @apellido, @edad, @fnac, @nmatricula)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@edad", nuevo.Edad);
                conexion.Comando.Parameters.AddWithValue("@fnac", nuevo.Fnac);
                conexion.Comando.Parameters.AddWithValue("@nmatricula", nuevo.Nmatricula);

                conexion.abrir();
                nuevo.IdMedico = conexion.ejecutarAccionReturn() ;

                // Creo un objeto EspecialidadXMedico para llamar el metodo AltaEspecialidadXMedico
                DatosEspecialidadXMedico especialidadXMedico = new DatosEspecialidadXMedico();

                // Creo un objeto OSxMedico para llamar el metodo AltaOsXMedico
                DatosOSxMedico oSxMedico = new DatosOSxMedico();

                // Creo un objeto DiaXMedico para llamar el metodo AltaDiaXMedico
                DatosDiasXMedico diaXMedico = new DatosDiasXMedico();

                DatosHorasXDias horasXDias = new DatosHorasXDias();
                
                //cargar en la tabla espXmedico
                // recorro la lista de especialidades del objeto nuevo (medico)
                foreach (Especialidad nuevaEspecialidad in nuevo.Especialidades)
                {
                    // para cada especialidad en la lista llamar al metodo altaEspecialidadesXMedico
                    especialidadXMedico.AltaEspecialidadXMedico(nuevo, nuevaEspecialidad);
                }
                foreach (ObraSocial nuevaOS in nuevo.OS)
                {
                    // para cada especialidad en la lista llamar al metodo AltaOsXMedico
                    oSxMedico.AltaOSxMedico(nuevo, nuevaOS);

                }
                foreach (Dia nuevosDias in nuevo.Dia)
                {
                    diaXMedico.AltaDiaXMedico(nuevo, nuevosDias);
                }

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
                conexion.setearConsulta(@"DELETE FROM ESPECIALIDADxMEDICO WHERE IDMED IN(SELECT IDMED FROM MEDICOS WHERE IDMED = @Id)
                                          DELETE FROM OSxMEDICO WHERE IDMED IN(SELECT IDMED FROM MEDICOS WHERE IDMED = @Id)
                                          DELETE FROM DIASxMEDICO WHERE IDMED IN(SELECT IDMED FROM MEDICOS WHERE IDMED = @Id)
                                          DELETE FROM HORASxDIAS WHERE IDMED IN(SELECT IDMED FROM MEDICOS WHERE IDMED = @Id)
                                          DELETE FROM MEDICOS WHERE IDMEDICO = @Id");
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

        public int BuscarIDMedico(string Nmatricula)
        {
            AccesoDB conexion = new AccesoDB();

            int ID;
            try
            {
                conexion.setearConsulta("SELECT IDMEDICO FROM MEDICOS WHERE NMATRICULA = " + Nmatricula);

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
