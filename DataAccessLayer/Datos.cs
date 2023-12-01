using System.Collections.Generic;
using DataBase;
using System.Linq;
using System;

namespace DataAccessLayer
{
    public class Datos
    {
        public static List<Modelo.Lugar> ListaLugares()
        {
            var lista = new List<Modelo.Lugar>();
            using (var ctx = new AeropuertoEntitiesRodrigo())
            {
                return ctx.Lugar.Select(lugar => new Modelo.Lugar()
                {
                    LugarId = lugar.LugarId,
                    Clave = lugar.Clave,
                    Descripcion = lugar.Descripcion
                }).ToList();
            }
        }

        public static bool ValidarUsuario(string solicitudUser, string solicitudPass)
        {
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var user = ctx.Usuario.FirstOrDefault(z => z.Username == solicitudUser && z.Contrasena == solicitudPass);
                    if (user != null)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Modelo.Usuario ObtenerUsuarioPorUserName(string solicitudUser)
        {
            var UsuarioSalida = new Modelo.Usuario();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var user = ctx.Usuario.FirstOrDefault(z => z.Username == solicitudUser);
                    UsuarioSalida.ApellidoMaterno = user.ApellidoMaterno;
                    UsuarioSalida.ApellidoPaterno = user.ApellidoPaterno;
                    UsuarioSalida.Contrasena = user.Contrasena;
                    UsuarioSalida.Nombres = user.Nombres;
                    UsuarioSalida.Username = user.Username;
                    UsuarioSalida.UsuarioId = user.UsuarioId;
                    UsuarioSalida.CantidadDePagosConfigurados = ctx.Pago.Where(z => z.UsuarioId == user.UsuarioId).Count();
                }
                return UsuarioSalida;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Modelo.Vuelo ObtenerVueloPorId(int vueloId)
        {
            var VueloSalida = new Modelo.Vuelo();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var v = ctx.Vuelo.FirstOrDefault(z => z.VueloId == vueloId);
                    VueloSalida.VueloId = v.VueloId;
                    VueloSalida.Precio = v.Precio;
                }
                return VueloSalida;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public static bool ReservarVuelo(Modelo.Reservacion reservacion)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool RegistroUsuario(Modelo.Usuario nuevoUsuario)
        {
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var usuarios = ctx.Usuario.ToList();
                    if (usuarios.Any(z => z.Username == nuevoUsuario.Username))
                    {
                        return false;
                    }
                    else
                    {
                        ctx.Usuario.Add(new Usuario()
                        {
                            Username = nuevoUsuario.Username,
                            Contrasena = nuevoUsuario.Contrasena,
                            ApellidoPaterno = nuevoUsuario.ApellidoPaterno,
                            ApellidoMaterno = nuevoUsuario.ApellidoMaterno,
                            Nombres = nuevoUsuario.Nombres
                        });
                        ctx.SaveChanges();
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<Modelo.TablaVuelos> VuelosFiltrados(int LugarOrigenId, int LugarDestinoId)
        {
            var salida = new List<Modelo.TablaVuelos>();
            using (var ctx = new AeropuertoEntitiesRodrigo())
            {
                var vuelos = ctx.Vuelo.Where(z => z.LugarOrigenId == LugarOrigenId && z.LugarDestinoId == LugarDestinoId).OrderBy(z => z.FechaSalida).ToList();
                vuelos.ForEach(z =>
                {
                    salida.Add(new Modelo.TablaVuelos()
                    {
                        VueloId = z.VueloId,
                        Desde = z.Lugar1.Descripcion,
                        Hacia = z.Lugar.Descripcion,
                        FechaDeSalida = z.FechaSalida,
                        AsientosDisponibles = z.NumeroPasajeros - z.Reservacion.Count,
                        Costo = z.Precio
                    });
                });
            }
            return salida;
        }

        public static List<Modelo.Reservacion> ReservacionesPorUsuario(int UsuarioId)
        {
            var reservaciones = new List<Modelo.Reservacion>();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {

                    var datos = ctx.Pago.Where(z => z.UsuarioId == UsuarioId)
                        .SelectMany(z => z.Transaccion)
                            .SelectMany(z => z.Reservacion)
                                .Where(z => z.Vuelo.FechaSalida > DateTime.Now).ToList();
                    foreach (var reservacion in datos)
                    {
                        var Registro = new Modelo.Reservacion();
                        Registro.ReservacionId = reservacion.ReservacionId;
                        Registro.TransaccionId = reservacion.TransaccionId;
                        Registro.VueloId = reservacion.VueloId;
                        Registro.VueloRutaFecha = "Reservado de " + reservacion.Vuelo.Lugar1.Descripcion + " a " +
                                                    reservacion.Vuelo.Lugar.Descripcion + " a " + reservacion.Vuelo.FechaSalida;
                        reservaciones.Add(Registro);
                    }

                }
            }
            catch (Exception)
            {
            }
            return reservaciones;
        }

        public static bool RegistroPago(Modelo.Pago nuevoPago)
        {
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var pag = new Pago();

                    pag.PagoId = nuevoPago.PagoId;
                    pag.UsuarioId = nuevoPago.UsuarioId;
                    pag.TipoPagoId = nuevoPago.TipoPagoId;
                    pag.NumeroTarjeta = nuevoPago.NumeroTarjeta;
                    pag.CorreoPaypal = nuevoPago.CorreoPaypal;
                    ctx.Pago.Add(pag);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<Modelo.TipoPago> ListaTipoPago()
        {
            List<Modelo.TipoPago> salida = new List<Modelo.TipoPago>();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    salida = ctx.TipoPago.Select(z => new Modelo.TipoPago()
                    {
                        Descripcion = z.Descripcion,
                        TipoPagoId = z.TipoPagoId
                    }).ToList();
                }
            }
            catch (Exception)
            {
            }
            return salida;
        }

        public static List<Modelo.Pago> ListaPagoDeUsuario(int UsuarioId)
        {
            List<Modelo.Pago> salida = new List<Modelo.Pago>();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    salida = ctx.Pago.Where(z => z.UsuarioId == UsuarioId).Select(z => new Modelo.Pago()
                    {
                        PagoId = z.PagoId,
                        CorreoPaypal = z.CorreoPaypal,
                        NumeroTarjeta = z.NumeroTarjeta,
                        TipoPagoId = z.TipoPagoId,
                        UsuarioId = z.UsuarioId
                    }).ToList();
                }
            }
            catch (Exception)
            {
            }
            return salida;
        }

        public static bool CrearReservacion(int VueloId, int TransaccionId)
        {
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var NewReservacion = new Reservacion();
                    NewReservacion.VueloId = VueloId;
                    NewReservacion.TransaccionId = TransaccionId;
                    ctx.Reservacion.Add(NewReservacion);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            return true;
        }

        public static int CrearTransaccion(int PagoId, decimal Cantidad)
        {
            int NuevoIdTransaccion = 0;
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var NewTransaccion = new Transaccion();
                    NewTransaccion.PagoId = PagoId;
                    NewTransaccion.Cantidad = Cantidad;
                    NewTransaccion.Fecha = DateTime.Now;
                    ctx.Transaccion.Add(NewTransaccion);
                    ctx.SaveChanges();
                    var ultimoTransaccion = ctx.Transaccion.OrderBy(t => t.TransaccionId).First();
                    return ultimoTransaccion.TransaccionId;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


    }
}
