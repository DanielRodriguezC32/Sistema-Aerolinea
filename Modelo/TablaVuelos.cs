using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class TablaVuelos
    {
        public string Desde { get; set; }
        public string Hacia { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public int AsientosDisponibles { get; set; }
        public decimal Costo { get; set; }
    }
}
