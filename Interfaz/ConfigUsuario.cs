using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Drawing.Text;

namespace Interfaz
{
    public partial class ConfigUsuario : Form
    {
        private Usuario UsuarioActual;
        public ConfigUsuario(Usuario UsuarioActualConstructor)
        {
            InitializeComponent();
            this.UsuarioActual = UsuarioActualConstructor;
            lblUsuario.Text = "Usuario: " + UsuarioActual.Username;
            lblNombre.Text = "Nombre: " + UsuarioActual.Nombres;
            lblMetodo.Text = "Metodo de pago: ";
            lblCorreo.Text = "Correo: ";
            lblContraseña.Text = "Contraseña: " + UsuarioActual.Contrasena;
        }

        private void ConfigUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUserGen_Click(object sender, EventArgs e)
        {
            //verificar que username no exista, cambiar username 
        }

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            //verificar que contraseñas coincidan, cambiar password
        }

        private void btnCorreoGen_Click(object sender, EventArgs e)
        {
            //verificar que correo no exista, cambiar o ingresar correo
        }
    }
}
