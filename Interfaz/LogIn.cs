using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            bool usuarioValidado = BusinessLogicLayer.BLL.ValidarUsuario(solicitudUser, solicitudPass);
            if (usuarioValidado)
            {
                var Usuario = BusinessLogicLayer.BLL.ObtenerUsuarioPorUserName(solicitudUser);
                this.Hide();
                Hub hub = new Hub(Usuario);
                hub.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username y/o contrseña invalido");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
