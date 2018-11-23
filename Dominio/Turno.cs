using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public Paciente P { get; set; }
        public Medico M { get; set; }
        public Especialidad E { get; set; }
        public ObraSocial OS { get; set; }
        public DateTime FechaTurno { get; set; }
        public int Valor { get; set; }

        public string Pnombre { get; set; }
        public string Papellido { get; set; }
        public int Pdni { get; set; }
        public int Pafiliado { get; set; }    

        public string Mnombre { get; set; }
        public string mapellido { get; set; }
        
        public string Especialidad { get; set; }
        public string ObraSocial { get; set; }

    }
}
