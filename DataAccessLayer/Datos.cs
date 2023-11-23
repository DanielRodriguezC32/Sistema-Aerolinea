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
    }
}
