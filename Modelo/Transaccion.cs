using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Transaccion
    {
        public int TransaccionId { get; set; }
        public int PagoId { get; set; }
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
