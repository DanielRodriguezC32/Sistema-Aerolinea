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

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.ShowDialog();
            this.Show();
        }

        private void btnSendCred_Click(object sender, EventArgs e)
        {
            //variables para validacion de usuario
            var solicitudUser = InputUserCred.Text;
            var solicitudPass = InputPassCred.Text;

            //Necesito comparar creds con base de datos simulare por mientras
            if (solicitudUser != "admin" && solicitudPass != "admin")
            {
                MessageBox.Show("Usuario invalido");
            }
            else
            {
                // encontramos al usuario, en este caso admin e ingresamos a la pagina principal
                this.Hide(); //como ya no usaremos esta pagina la escondemos
                Hub hub = new Hub(solicitudUser, solicitudPass); //creamos una variable que inicia la pagina
                hub.ShowDialog(); // abrimos la pagina
                this.Close(); //la cerramos despues
            }

        }
    }
}
