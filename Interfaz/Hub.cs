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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        // Para pruebas
        // Solicita informacion en los valores de Request de usuario en LogIn
        // Se planea utilizar las credenciales de usuario existentes en la base de datos
        private void MostrarCredencialesDeLogIn()
        {
            LogIn loginForm = new LogIn(); // Crear una instancia del formulario LogIn

            // Acceder a las propiedades públicas para obtener las credenciales
            string usuario = loginForm.SolicitudUser;
            string password = loginForm.SolicitudPass;

            // Mostrar la información en el panelUsr
            Label labelUsuario = new Label();
            labelUsuario.Text = "Usuario: " + usuario;
            labelUsuario.Location = new Point(10, 10); // Establece la posición en el panel
            panelUsr.Controls.Add(labelUsuario);

            Label labelPassword = new Label();
            labelPassword.Text = "Contraseña: " + password;
            labelPassword.Location = new Point(10, 30); // Establece la posición en el panel
            panelUsr.Controls.Add(labelPassword);
        }
        // Final de codigo para pruebas

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Este foreach se usa para eliminar el panel visible actual
            foreach (Control control in PanelInicio.Controls)
            {
                if (control is Form form)
                {
                    form.Hide();
                }
            }

            UsrInicio usrInicio = new UsrInicio() { TopLevel = false, TopMost = true };
            usrInicio.FormBorderStyle = FormBorderStyle.None;
            PanelInicio.Controls.Add(usrInicio);
            usrInicio.Show();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            //Este foreach se usa para eliminar el panel visible actual
            foreach (Control control in PanelInicio.Controls)
            {
                if (control is Form form)
                {
                    form.Hide();
                }
            }
            VuelosInf vuelosInf = new VuelosInf() { TopLevel = false, TopMost = true };
            vuelosInf.FormBorderStyle = FormBorderStyle.None;
            PanelInicio.Controls.Add(vuelosInf);
            vuelosInf.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
