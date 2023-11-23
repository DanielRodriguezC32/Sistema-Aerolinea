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
            try
            {
                var lista = new List<Modelo.Lugar>();
                using (var ctx = new AeropuertoEntitiesRodrigo())
                {
                    ctx.Lugar.ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
