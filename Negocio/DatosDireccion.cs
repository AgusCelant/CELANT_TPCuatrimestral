using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DatosDireccion
    {
        public int agregar(Direccion Direcion) {

            AccesoDB Conexion;

            try
            {
                Conexion = new AccesoDB();
                Conexion.setearConsulta("insert into DIRECCIONES values(@Calle, @Numero, @IdLocalidad)");
                Conexion.Comando.Parameters.Clear();
                Conexion.Comando.Parameters.AddWithValue("@Calle", Direcion.Calle);
                Conexion.Comando.Parameters.AddWithValue("@Numero", Direcion.Numero);
                Conexion.Comando.Parameters.AddWithValue("@IdLocalidad", Direcion.Localidad.IdLocalidad);
                
                Conexion.abrir();
                return Conexion.ejecutarAccionReturn();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
