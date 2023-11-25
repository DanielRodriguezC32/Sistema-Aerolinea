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
        //public static List<Modelo.Usuario> ListaUsuarios()
        //{
        //    var listaUsuario = new List<Modelo.Usuario>();
        //    using (var ctx = new AeropuertoEntitiesRodrigo())
        //    {
        //        return ctx.Usuario.Select(usuario => new Modelo.Usuario()
        //        {
        //            UsuarioId = usuario.UsuarioId,
        //            Nombres = usuario.Nombres,
        //            ApellidoPaterno = usuario.ApellidoPaterno,
        //            ApellidoMaterno = usuario.ApellidoMaterno,
        //            Username = usuario.Username,
        //            Contrasena = usuario.Contrasena
        //        }).ToList();
        //    }
        //}
    }
}
