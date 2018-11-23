using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DatosDiasXMedico
    {
        public void AltaDiaXMedico(Medico nuevoMedico, Dia nuevoDia)
        {
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("insert into DIASXMEDICO(IDMED, IDDIA) values(@IDMED, @IDDIA)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDMED", nuevoMedico.IdMedico);
                conexion.Comando.Parameters.AddWithValue("@IDDIA", nuevoDia.IdDay);

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
    }
}
