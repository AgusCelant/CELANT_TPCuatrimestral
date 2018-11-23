using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fnac { get; set; }
        public int Nmatricula { get; set; }
        public List<Especialidad> Especialidades;
        public List<ObraSocial> OS;
        public List<Dia> Dia;
        public List<TurnoHorario> TH;
    }
}
