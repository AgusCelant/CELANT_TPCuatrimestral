using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TurnoHorario
    {
        public int Horainit { get; set; }
        public int HoraFin { get; set; }
        public int IdDia { get; set; }

        public int DescHoraInicio { get; set; }
        public int DescHoraFin { get; set; }
        public string DescDia { get; set; }

        public override string ToString()
        {
            string cadena = null;

            switch (IdDia)
            {
                case 1:
                   cadena = "LUNES" + "-" + Horainit + "/" + HoraFin; 
                    break;

                case 2:
                    cadena = "MARTES" + "-" + Horainit + "/" + HoraFin;
                    break;

                case 3:
                    cadena = "MIERCOLES" + "-" + Horainit + "/" + HoraFin;
                    break;

                case 4:
                    cadena = "JUEVES" + "-" + Horainit + "/" + HoraFin;
                    break;

                case 5:
                    cadena = "VIERNES" + "-" + Horainit + "/" + HoraFin;
                    break;

                case 6:
                    cadena = "SABADO" + "-" + Horainit + "/" + HoraFin;
                    break;

                case 7:
                    cadena = "DOMINGO" + "-" + Horainit + "/" + HoraFin;
                    break;
            }
            return cadena; 

        }
    }
}
