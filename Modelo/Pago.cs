using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int UsuarioId { get; set; }
        public int TipoPagoId { get; set; }
        public string NumeroTarjeta { get; set; }
        public string CorreoPaypal { get; set; }
        public string TipoYDatoParaCombo => TipoPagoId == 3 ? "Paypal - " + CorreoPaypal : "Tarjeta - " + NumeroTarjeta;
    }
}
