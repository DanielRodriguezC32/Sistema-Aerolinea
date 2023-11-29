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
    public partial class RegistroPagos : Form
    {
        Modelo.Usuario user;
        Hub Padre;
        public RegistroPagos(Modelo.Usuario usuario, Hub papa)
        {
            user = usuario;
            InitializeComponent();

            cbTiposDePago.ValueMember = "TipoPagoId";
            cbTiposDePago.DisplayMember = "Descripcion";
            cbTiposDePago.DataSource = BusinessLogicLayer.BLL.ListaTipoPago();

            Padre = papa;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void btnRegTipoPagoNew_Click(object sender, EventArgs e)
        {
            var newPago = new Modelo.Pago();
            newPago.TipoPagoId = Convert.ToInt32(cbTiposDePago.SelectedValue);
            newPago.NumeroTarjeta = InputNewCorreoTarjeta.Text;
            newPago.CorreoPaypal = InputNewCorreoTarjeta.Text;
            newPago.UsuarioId = user.UsuarioId;
            bool resultado = BusinessLogicLayer.BLL.RegistroPago(newPago);
            if (resultado)
            {
                MessageBox.Show("Se dio de alta el metodo de pago!", " ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hubo un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            Padre.Inicio();
        }
    }
}
