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
            //Aqui tomaremos los datos ingresados del usuario para meterlos a la base de datos.
            var NewUser = InputNewUsrCred.Text;
            var NewPass = InputNewPassCred.Text;
            var NewNombre = InputNewNombreCred.Text;
            var NewApellidoP = InputNewApellidoPCred.Text;
            var NewApellidoM = InputNewApellidoMCred.Text;


            //Obtenemos la lista de usuarios
            //List<Modelo.Usuario> usuarios = DataAccessLayer.Datos.ListaUsuarios();

            //// Verificamos si la persona ya se registro
            //bool usuarioExistente = usuarios.Any(u => u.Nombres == NewNombre && u.ApellidoPaterno == NewApellidoP && u.ApellidoMaterno == NewApellidoM);

            //// Verificar si ya existe un usuario con el mismo nombre de usuario
            //bool nombreUsuarioExistente = usuarios.Any(u => u.Username == NewUser);

            //if (usuarioExistente)
            //{
            //    MessageBox.Show("Ya tienes una cuenta registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (nombreUsuarioExistente)
            //{
            //    MessageBox.Show("El nombre de usuario no esta disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    // Crear un nuevo objeto de usuario
            //    var nuevoUsuario = new Modelo.Usuario
            //    {
            //        Username = NewUser,
            //        Contrasena = NewPass,
            //        Nombres = NewNombre,
            //        ApellidoPaterno = NewApellidoP,
            //        ApellidoMaterno = NewApellidoM
            //    };

            //    MessageBox.Show("Quedaste registrado!", " ", MessageBoxButtons.OK);
            //    this.Close();
            //}
            MessageBox.Show("Quedaste registrado!", " ", MessageBoxButtons.OK);
            this.Close();


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
