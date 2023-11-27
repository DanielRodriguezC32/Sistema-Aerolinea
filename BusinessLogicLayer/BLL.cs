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
    }
}
