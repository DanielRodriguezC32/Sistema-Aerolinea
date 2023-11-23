using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vuelo
    {
        public int VueloId { get; set; }
        public int LugarOrigenId { get; set; }
        public int LugarDestinoId { get; set; }
        public DateTime FechaSalida { get; set; }
        public int NumeroPasajeros { get; set; }
        public double Precio {  get; set; }
        public bool VisaNecesitada { get; set; }
        public bool Habilitado { get; set; }
    }
}
