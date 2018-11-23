using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DatosOSxMedico
    {
        public void AltaOSxMedico(Medico NuevoMedico, ObraSocial NuevaOS)
        {
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO OSxMEDICO(IDOBS, IDMED) VALUES(@IDOBS, @IDMED)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IDOBS", NuevaOS.IdOS);
                conexion.Comando.Parameters.AddWithValue("@IDMED", NuevoMedico.IdMedico);

                conexion.abrir();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                if (conexion != null)
                {
                    conexion.cerrar();
                }
            }
        }
    }
}
