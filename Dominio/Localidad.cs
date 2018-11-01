using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string CPostal { get; set; }
        public string Descripcion { get; set; }

        public Localidad()
        {
            IdLocalidad = -1;
            CPostal = "";
            Descripcion = "";
        }

        public override string ToString()
        {
            return Descripcion + " (" + CPostal.ToString() + ")";
        }
    }
}
