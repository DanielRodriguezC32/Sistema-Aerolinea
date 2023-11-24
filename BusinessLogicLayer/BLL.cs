using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public static List<Modelo.Lugar> ListaLugares()
        {
            return DataAccessLayer.Datos.ListaLugares();
        }
    }
}
