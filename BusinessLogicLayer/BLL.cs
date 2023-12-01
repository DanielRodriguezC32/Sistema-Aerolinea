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

        public static bool ValidarUsuario(string solicitudUser, string solicitudPass)
        {
            return DataAccessLayer.Datos.ValidarUsuario(solicitudUser, solicitudPass);
        }

        public static Usuario ObtenerUsuarioPorUserName(string solicitudUser)
        {
            return DataAccessLayer.Datos.ObtenerUsuarioPorUserName(solicitudUser);
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

        public static Modelo.Vuelo ObtenerVueloPorId(int vueloId)
        {
            return DataAccessLayer.Datos.ObtenerVueloPorId(vueloId);
        }

        public static List<Modelo.Pago> ListaPagoDeUsuario(int UsuarioId)
        {
            return DataAccessLayer.Datos.ListaPagoDeUsuario(UsuarioId);
        }
        public static bool CrearReservacion(int VueloId, int PagoId, decimal Cantidad)
        {
            int TransaccionId = DataAccessLayer.Datos.CrearTransaccion(PagoId, Cantidad);
            return DataAccessLayer.Datos.CrearReservacion(VueloId, TransaccionId);
        }
        
    }
}
