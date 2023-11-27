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
                return ctx.Lugar.Select(lugar => new Modelo.Lugar() {
                    LugarId = lugar.LugarId,
                    Clave = lugar.Clave,
                    Descripcion = lugar.Descripcion
                }).ToList();
            }
        }

        public static Modelo.Usuario ValidarUsuario(string solicitudUser, string solicitudPass)
        {
            var UsuarioSalida = new Modelo.Usuario();
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var user = ctx.Usuario.FirstOrDefault(z => z.Username == solicitudUser && z.Contrasena == solicitudPass);
                    if(user != null)
                    {
                        UsuarioSalida.ApellidoMaterno = user.ApellidoMaterno;
                        UsuarioSalida.ApellidoPaterno = user.ApellidoPaterno;
                        UsuarioSalida.Contrasena = user.Contrasena;
                        UsuarioSalida.Nombres = user.Nombres;
                        UsuarioSalida.Username = user.Username;
                        UsuarioSalida.UsuarioId = user.UsuarioId;
                    }
                }
                return UsuarioSalida;
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public static bool RegistroUsuario(Modelo.Usuario nuevoUsuario)
        {
            try
            {
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    var usuarios = ctx.Usuario.ToList();
                    if (usuarios.Any(z => z.Username == nuevoUsuario.Username)){
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
            }catch(Exception)
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
                        //Llenar Datos con lo que se necesite, se modifica el POCO Reservacion para toda la info extra
                        //var vuelo = reservacion.Vuelo;
                        //vuelo.LugarOrigenId;
                        //vuelo.LugarDestinoId;
                        //vuelo.FechaSalida;                        
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
                    

                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
