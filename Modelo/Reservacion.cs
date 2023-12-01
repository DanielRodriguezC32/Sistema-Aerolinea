using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Reservacion
    {
        public int ReservacionId { get; set; }
        public int VueloId { get; set; }
        public int TransaccionId { get; set; }

        #region datos informativos
        public string VueloRutaFecha { get; set; }
        #endregion

    }
}
