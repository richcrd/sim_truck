using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TRUCK.capa_entidades
{
    public class Transaccion
    {
        public int Id { get; set; }
        public int ViajeId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Pago { get; set; }
    }

}
