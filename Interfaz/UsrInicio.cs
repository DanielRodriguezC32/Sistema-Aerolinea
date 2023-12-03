using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class UsrInicio : Form
    {
        Modelo.Usuario UsuarioActual;

        public UsrInicio(Modelo.Usuario user)
        {
            UsuarioActual = user;
            InitializeComponent();
            lblNombreUsrInicio.Text = user.Nombres;
            lblApellidoPUsrInicio.Text = user.ApellidoPaterno;
            lblApellidoMUsrInicio.Text = user.ApellidoMaterno;                  
        }
        public void ActualizarNotificaciones(string notas)
        {
            this.lblNotificacionUsuario.Text = notas;
        }

        public void ActualizarReservaciones()
        {
            var reservaciones = BusinessLogicLayer.BLL.ReservacionesPorUsuario(UsuarioActual.UsuarioId);
            switch (reservaciones.Count)
            {
                case 6: lblReservacionesListaUsrInicio6.Text = reservaciones[5].VueloRutaFecha; goto case 5;
                case 5: lblReservacionesListaUsrInicio5.Text = reservaciones[4].VueloRutaFecha; goto case 4;
                case 4: lblReservacionesListaUsrInicio4.Text = reservaciones[3].VueloRutaFecha; goto case 3; 
                case 3: lblReservacionesListaUsrInicio3.Text = reservaciones[2].VueloRutaFecha; goto case 2;
                case 2: lblReservacionesListaUsrInicio2.Text = reservaciones[1].VueloRutaFecha; goto case 1;
                case 1: lblReservacionesListaUsrInicio1.Text = reservaciones[0].VueloRutaFecha; goto case 0;
                case 0:break;


            }
        }
    }
}
