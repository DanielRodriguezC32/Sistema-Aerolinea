using System.Collections.Generic;
using DataBase;
using System.Linq;

namespace DataAccessLayer
{
    public class Datos
    {
        public static List<Modelo.Lugar> ListaLugares()
        {
            var lista = new List<Modelo.Lugar>();
            using (var ctx = new AeropuertoEntitiesRodrigo())
            {
                ctx.Lugar.ToList();
            }
            return lista;
        }
    }
}
