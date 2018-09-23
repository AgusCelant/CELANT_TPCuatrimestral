using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefonos : Paciente
    {
        public Paciente paciente = new Paciente();

        public int IdTelefono { get; set; }
        public int Telefono { get; set; }
    }
}
