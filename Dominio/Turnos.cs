using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        public Paciente paciente = new Paciente();
        public Medico mmedico = new Medico();
        
        public int IdTurno { get; set; }
        public DateTime fecha { get; set; }
        public DateTime horario { get; set; }

    }
}
