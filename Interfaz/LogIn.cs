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
            if (solicitudUser != "admin" && solicitudPass != "password")
            {
                MessageBox.Show("Usuario invalido");
            }
            else
            {
                // encontramos al usuario, en este caso admin e ingresamos a la pagina principal
                this.Hide(); //como ya no usaremos esta pagina la escondemos
                Form1 form1 = new Form1(); //creamos una variable que inicia la pagina
                form1.ShowDialog(); // abrimos la pagina
                this.Close(); //la cerramos despues
            }

        }
    }
}
