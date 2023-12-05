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
        Hub padre;
        public ConfigUsuario(Usuario UsuarioActualConstructor, Hub papa)
        {
            InitializeComponent();
            this.padre = papa;
            this.UsuarioActual = UsuarioActualConstructor;
            lblNombre.Text = "Nombre: " + UsuarioActual.Nombres;
            lblApellidoPaterno.Text = "Apellido Paterno: " + UsuarioActual.ApellidoPaterno;
            lblApellidoMaterno.Text = "Apellido Materno: " + UsuarioActual.ApellidoMaterno;
            txtNewName.Text = UsuarioActual.Nombres;
            txtNewLastNameP.Text = UsuarioActual.ApellidoPaterno;
            txtNewLastNameM.Text = UsuarioActual.ApellidoMaterno;

        }

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            if (!txtNewPass.Text.Equals(txtNewPassVal.Text) || txtNewPass.Text == string.Empty)
            {
                MessageBox.Show("Contraseñas distintas o vacías");
            }
            else
            {
                UsuarioActual.Contrasena = txtNewPass.Text;
                BusinessLogicLayer.BLL.ActualizarUsuario(UsuarioActual);

                lblNombre.Text = "Nombre: " + UsuarioActual.Nombres;
                lblApellidoPaterno.Text = "Apellido Paterno: " + UsuarioActual.ApellidoPaterno;
                lblApellidoMaterno.Text = "Apellido Materno: " + UsuarioActual.ApellidoMaterno;
                padre.UsuarioActual = UsuarioActual;
                MessageBox.Show("Datos actualizados");
            }
        }

        private void btnUserGen_Click(object sender, EventArgs e)
        {
            UsuarioActual.Nombres = txtNewName.Text;
            UsuarioActual.ApellidoPaterno = txtNewLastNameP.Text;
            UsuarioActual.ApellidoMaterno = txtNewLastNameM.Text;
            BusinessLogicLayer.BLL.ActualizarUsuario(UsuarioActual);
            lblNombre.Text = "Nombre: " + UsuarioActual.Nombres;
            lblApellidoPaterno.Text = "Apellido Paterno: " + UsuarioActual.ApellidoPaterno;
            lblApellidoMaterno.Text = "Apellido Materno: " + UsuarioActual.ApellidoMaterno;
            padre.lblNom.Text = "Nombre:  " + UsuarioActual.Nombres + " " + UsuarioActual.ApellidoPaterno;
            padre.UsuarioActual = UsuarioActual;
            MessageBox.Show("Datos actualizados");
        }
    }
}
