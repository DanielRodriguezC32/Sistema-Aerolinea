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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegUsrNew_Click(object sender, EventArgs e)
        {
            if (NewPassValid.Text == InputNewPassCred.Text)
            {
                //Aqui tomaremos los datos ingresados del usuario para meterlos a la base de datos.
                var NewUser = InputNewUsrCred.Text;
                var NewPass = InputNewPassCred.Text;
                var NewNombre = InputNewNombreCred.Text;
                var NewApellidoP = InputNewApellidoPCred.Text;
                var NewApellidoM = InputNewApellidoMCred.Text;

                var nuevoUsuario = new Modelo.Usuario
                {
                    Username = NewUser,
                    Contrasena = NewPass,
                    Nombres = NewNombre,
                    ApellidoPaterno = NewApellidoP,
                    ApellidoMaterno = NewApellidoM
                };

                bool UsuarioCreado = BusinessLogicLayer.BLL.RegistroUsuario(nuevoUsuario);

                if (UsuarioCreado)
                {
                    MessageBox.Show("Quedaste registrado!", " ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hubo un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }
            else
            {
                NewPassValid.Text = "Contraseñas diferntes";
            }


        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
