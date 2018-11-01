using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DatosLocalidad
    {
        public List<Localidad> listar() {

            AccesoDB conexion = null;
            List<Localidad> lista = new List<Localidad>();
            Localidad aux;

            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("select * from Localidades");
                conexion.abrir();
                conexion.leerAccion();

                while (conexion.Lector.Read()) {
                    aux = new Localidad();
                    aux.IdLocalidad = (int)conexion.Lector["IdLocalidad"];
                    aux.CPostal = (string)conexion.Lector["CPostal"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                if (conexion != null) {
                    conexion.cerrar();
                }
            }
        }

    }
}
