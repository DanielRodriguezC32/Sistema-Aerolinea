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
    public partial class Form1 : Form
    {
        public Form1()
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

            gvTabla.DataSource = DataAccessLayer.Datos.ListaLugares();
        }

        private void BuscarVuelos_Click(object sender, EventArgs e)
        {

        }

        private void mvForm2_Click(object sender, EventArgs e)
        {
            //esconder la ventana actual
            this.Hide();
            //Crear una sesion de la otra pagina
            Form2 form2 = new Form2();
            //Mostramos la pagina cargada
            form2.ShowDialog();
            //Cuando se cierre la otra pagina, que se vuelva a abrir esta
            this.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
