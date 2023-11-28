using System;
using System.Collections.Generic;
using DataAccessLayer;
using Modelo;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public static List<Modelo.Lugar> ListaLugares()
        {
            return DataAccessLayer.Datos.ListaLugares();
        }

        public static bool RegistroUsuario(Usuario nuevoUsuario)
        {
            return DataAccessLayer.Datos.RegistroUsuario(nuevoUsuario);
        }

        public static Modelo.Usuario ValidarUsuario(string solicitudUser, string solicitudPass)
        {
            return DataAccessLayer.Datos.ValidarUsuario(solicitudUser, solicitudPass);
        }

        public static List<TipoPago> ListaTipoPago()
        {
            return DataAccessLayer.Datos.ListaTipoPago();
        }
        public static bool RegistroPago(Modelo.Pago pago)
        {
            return DataAccessLayer.Datos.RegistroPago(pago);
        }
        public static List<Reservacion> ReservacionesPorUsuario(int UsuarioId)
        {
            return DataAccessLayer.Datos.ReservacionesPorUsuario(UsuarioId);
        }
        public static List<TablaVuelos> VuelosFiltrados(int LugarOrigenId, int LugarDestinoId)
        {
            return DataAccessLayer.Datos.VuelosFiltrados(LugarOrigenId, LugarDestinoId);
        }
        public static List<Modelo.Pago> ListaPagoDeUsuario(int UsuarioId)
        {
            return DataAccessLayer.Datos.ListaPagoDeUsuario(UsuarioId);
        }
        
    }
}
