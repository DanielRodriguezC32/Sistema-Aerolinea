using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

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
            
            var solicitudUser = InputUserCred.Text;
            var solicitudPass = InputPassCred.Text;

            var Username = BusinessLogicLayer.BLL.ValidarUsuario(solicitudUser, solicitudPass);
            if (Username.UsuarioId > 0)
            {
                this.Hide();
                Hub hub = new Hub(Username);
                hub.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username y/o contrseña invalido");
            }

        }
    }
}
