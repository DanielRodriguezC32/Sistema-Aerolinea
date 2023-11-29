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
    }
}
