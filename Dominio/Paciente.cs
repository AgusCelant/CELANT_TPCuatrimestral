using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime Fnac{ get; set; }
        public int Nafiliado { get; set; }
        public ObraSocial OS;
        public Direccion direccion { get; set; }
        public string OBS { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string CPostal { get; set; }
        public string Descripcion { get; set; }

        public Paciente() {
            this.direccion = new Direccion();
            this.OS = new ObraSocial();
        }
    }
}
