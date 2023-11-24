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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.ShowDialog();
            this.Show();

        }

        //para pruebas, estas dos variables son publicas para utilizar la informacion ingresada como usuario
        public string SolicitudUser { get; private set; }
        public string SolicitudPass { get; private set; }

        //Abre la ventana de registro de nuevo usuario
        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.ShowDialog();
            this.Show();
        }

        //Verifica Credenciales
        private void btnSendCred_Click(object sender, EventArgs e)
        {
            //variables para validacion de usuario
            var solicitudUser = InputUserCred.Text;
            var solicitudPass = InputPassCred.Text;

            //Obtener los datos de usuario
            //List<Modelo.Usuario> usuarios = DataAccessLayer.Datos.ListaUsuarios();

            //// Verificar si el usuario y la contraseña coinciden con algún usuario de la lista
            //Modelo.Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.Username == solicitudUser && u.Contrasena == solicitudPass);

            ////Necesito comparar creds con base de datos simulare por mientras
            //if (usuarioEncontrado != null)
            //{
            //    // encontramos al usuario e ingresamos a la pagina principal
            //    this.Hide(); //como ya no usaremos esta pagina la escondemos
            //    Hub hub = new Hub(solicitudUser, solicitudPass); //creamos una variable que inicia la pagina
            //    hub.ShowDialog(); // abrimos la pagina
            //    this.Close(); //la cerramos despues
            //}
            if (solicitudUser == "admin" && solicitudPass == "admin")
            {
                this.Hide();
                Hub hub = new Hub(solicitudUser, solicitudPass);
                hub.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario invalido");
            }

        }
    }
}
