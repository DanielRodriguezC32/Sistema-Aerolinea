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
    public partial class VuelosInf : Form
    {
        Modelo.Usuario user;
        public VuelosInf(Modelo.Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
            InicializacionDeComponentesManual();
        }

        private void InicializacionDeComponentesManual()
        {
            cbLugarOrigen.DisplayMember = "Descripcion";
            cbLugarOrigen.ValueMember = "LugarId";
            cbLugarOrigen.DataSource = DataAccessLayer.Datos.ListaLugares();

            cbLugarDestino.DisplayMember = "Descripcion";
            cbLugarDestino.ValueMember = "LugarId";
            cbLugarDestino.DataSource = DataAccessLayer.Datos.ListaLugares();

            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var LugarOrigenId = cbLugarOrigen.SelectedValue;
            var LugarDestinoId = cbLugarDestino.SelectedValue;
            vuelosDisplay.DataSource = DataAccessLayer.Datos.VuelosFiltrados(Convert.ToInt32(LugarOrigenId), Convert.ToInt32(LugarDestinoId));            
        }
    }
}
