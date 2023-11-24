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
        public VuelosInf()
        {
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

            vuelosDisplay.DataSource = DataAccessLayer.Datos.ListaLugares();
        }
    }
}
