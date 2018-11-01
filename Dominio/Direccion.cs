using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Localidad Localidad;

        public Direccion()
        {
            this.Localidad = new Localidad();
        }
      
        public override string ToString()
        {
            if (Localidad.IdLocalidad > -1)
                return Calle + " " + Numero + ", " + Localidad.Descripcion + " (" + Localidad.CPostal.ToString() + ")";
            else
                return "";
        }

   
    }
}
