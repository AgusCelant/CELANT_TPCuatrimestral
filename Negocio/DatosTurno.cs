using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosTurno
    {
        public void AltaTurno(Turno T)
        {
            AccesoDB conexion = new AccesoDB();

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO TURNOS(IDPACIENTE, IDMEDICO, IDESPECIALIDAD, IDOBS, FECHA, VALOR) VALUES (@IDPACIENTE, " +
                    "@IDMEDICO, @IDESPECIALIDAD, @IDOBS, @FECHA, @VALOR)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDPACIENTE", T.P.IdPaciente);
                conexion.Comando.Parameters.AddWithValue("@IDMEDICO", T.M.IdMedico);
                conexion.Comando.Parameters.AddWithValue("@IDESPECIALIDAD", T.E.IdEspecialidad);
                conexion.Comando.Parameters.AddWithValue("@IDOBS", T.OS.IdOS);
                conexion.Comando.Parameters.AddWithValue("@FECHA", T.FechaTurno);
                conexion.Comando.Parameters.AddWithValue("@VALOR", T.Valor);

                conexion.abrir();
                conexion.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public IList<Turno> ListarTurnos()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Turno> lista = new List<Turno>();
            
            
            try
            {
                
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"SELECT T.IDTURNO, T.FECHA, P.NOMBRE, P.APELLIDO, P.DOCUMENTO, P.NROAFILIADO, M.APELLIDO AS 'A.MEDICO', M.NOMBRE AS 'N.MEDICO',
E.DESCRIPCION AS 'ESPECIALIDAD', OS.NOMBRE AS 'OBRA SOCIAL', T.VALOR FROM TURNOS AS T
INNER JOIN PACIENTE AS P ON T.IDPACIENTE = P.IDPACIENTE
INNER JOIN MEDICOS AS M ON T.IDMEDICO = M.IDMEDICO
INNER JOIN ESPECIALIDADES AS E ON E.IDESPECIALIDAD = T.IDESPECIALIDAD
INNER JOIN OBRASOCIAL AS OS ON OS.IDOS = T.IDOBS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                

                while (lector.Read()) {
                    Turno Aux = new Turno();

                    Aux.P = new Paciente();
                    Aux.M = new Medico();
                    Aux.E = new Especialidad();
                    Aux.OS = new ObraSocial();

                    Aux.IdTurno = (int)lector["IDTURNO"];
                    Aux.FechaTurno = (DateTime)lector["FECHA"];
                    Aux.P.Nombre = lector.GetString(2);
                    Aux.P.Apellido = lector.GetString(3);
                    Aux.P.DNI = (int)lector["DOCUMENTO"];
                    Aux.P.Nafiliado = (int)lector["NROAFILIADO"];

                    Aux.M.Apellido = lector.GetString(6);
                    Aux.M.Nombre = lector.GetString(7);
                    Aux.E.DescEspecialidad = lector.GetString(8);
                    Aux.OS.OS = lector.GetString(9);
                    Aux.Valor = (int)lector["VALOR"];
                    
                    Aux.Pnombre = Aux.P.Nombre;
                    Aux.Papellido = Aux.P.Apellido;
                    Aux.Pdni = Aux.P.DNI;
                    Aux.Pafiliado = Aux.P.Nafiliado;
                    Aux.Mnombre = Aux.M.Nombre;
                    Aux.mapellido = Aux.M.Apellido;
                    Aux.Especialidad = Aux.E.DescEspecialidad;
                    Aux.ObraSocial = Aux.OS.OS;

                    lista.Add(Aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }

}

   
