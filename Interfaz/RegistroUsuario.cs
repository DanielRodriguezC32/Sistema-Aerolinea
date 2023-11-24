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
