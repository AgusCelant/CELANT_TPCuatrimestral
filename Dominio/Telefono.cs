using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefono : Paciente
    {
        public Paciente paciente = new Paciente();

        public int IdTelefono { get; set; }
        public int Tele { get; set; }
    }
}
