using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TRUCK.capa_entidades
{
    public class Viajes
    {
        public int Id { get; set; }
        public int CamionId { get; set; }
        public int ChoferId { get; set; }
        public string Inicia { get; set; }
        public string Termina { get; set; }
        public TimeSpan Duracion { get; set; }
        public int Pago { get; set; }
        public string Estado { get; set; }
    }

}
