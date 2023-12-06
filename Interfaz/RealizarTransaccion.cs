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
    public partial class RealizarTransaccion : Form
    {
        Modelo.Vuelo vuelo;
        Hub padre;
        public RealizarTransaccion(Modelo.Vuelo Vuelo, Hub Base, int UsuarioId)
        {
            vuelo = Vuelo;
            padre = Base;
            InitializeComponent();
            cbPago.DisplayMember = "TipoYDatoParaCombo";
            cbPago.ValueMember = "PagoId";
            cbPago.DataSource = BusinessLogicLayer.BLL.ListaPagoDeUsuario(UsuarioId);
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //LogIn logIn = new LogIn();
            //logIn.ShowDialog();
            this.Close();
        }

        private void btnCrearTransaccion_Click(object sender, EventArgs e)
        {
            bool resultado = BusinessLogicLayer.BLL.CrearReservacion(vuelo.VueloId, Convert.ToInt32(cbPago.SelectedValue), vuelo.Precio);

            if (resultado)
            {
                MessageBox.Show("Se ha creado la reservacion", " ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hubo un error, contáctese con el administrador del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            padre.Inicio();
            this.Close();
        }

        private void cbPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrecio.Text = vuelo.Precio.ToString("C2");
        }

    }
}
