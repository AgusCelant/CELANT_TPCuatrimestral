using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DatosHorasXDias
    {
        public void AltaHorasXDias(TurnoHorario TH, Medico med)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO HORASxDIAS(IDHORAINICIO,IDHORAFIN,IDDIA,IDMED) VALUES(@IDHI, @IDHF, @IDDIA, @IDMED)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDHI", TH.Horainit);
                conexion.Comando.Parameters.AddWithValue("@IDHF", TH.HoraFin);
                conexion.Comando.Parameters.AddWithValue("@IDDIA", TH.IdDia);
                conexion.Comando.Parameters.AddWithValue("@IDMED", med.IdMedico);

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

        public IList<TurnoHorario> ListarXHoraXdiaXmed(int IDM, int IDD)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<TurnoHorario> lista = new List<TurnoHorario>();
            TurnoHorario aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT HI.HORAINICIO, HE.HORAFIN FROM HORASINIT AS HI " +
                    "INNER JOIN HORASxDIAS AS HD ON HI.IDHORAINICIO = HD.IDHORAINICIO " +
                    "INNER JOIN HORASEND AS HE ON HD.IDHORAFIN = HE.IDHORAFIN " +
                    "INNER JOIN DIAS AS D ON HD.IDDIA = " + IDD +
                    "INNER JOIN MEDICOS AS M ON HD.IDMED = " + IDM;

                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new TurnoHorario();

                    aux.Horainit = (int)lector["HORAINICIO"];
                    aux.HoraFin = (int)lector["HORAFIN"];
                   
                    lista.Add(aux);
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
