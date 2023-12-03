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
        Hub padre;
        public VuelosInf(Modelo.Usuario usuario, Hub papa)
        {
            user = usuario;
            padre = papa;
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

            GridViewSetup();
            vuelosDisplay.DataSource = new List<Modelo.TablaVuelos>();
        }

        private void VuelosDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    int vueloId = (int)vuelosDisplay.Rows[e.RowIndex].Tag;
                    this.Hide();
                    var vuelo = BusinessLogicLayer.BLL.ObtenerVueloPorId(vueloId);
                    RealizarTransaccion TransaccionVentana = new RealizarTransaccion(vuelo, padre, user.UsuarioId);
                    TransaccionVentana.ShowDialog();
                }
            }
            catch (Exception)
            {
                this.btnFiltrar_Click(new object(), new EventArgs());
                this.Show();
            }
        }

        

        private void GridViewSetup()
        {

            vuelosDisplay.AutoGenerateColumns = false;

            // Agrega manualmente las columnas que deseas mostrar
            DataGridViewTextBoxColumn columnaDesde = new DataGridViewTextBoxColumn();
            columnaDesde.DataPropertyName = "Desde";
            columnaDesde.HeaderText = "Desde";
            vuelosDisplay.Columns.Add(columnaDesde);

            DataGridViewTextBoxColumn columnaHacia = new DataGridViewTextBoxColumn();
            columnaHacia.DataPropertyName = "Hacia";
            columnaHacia.HeaderText = "Hacia";
            vuelosDisplay.Columns.Add(columnaHacia);

            DataGridViewTextBoxColumn columnaFechaSalida = new DataGridViewTextBoxColumn();
            columnaFechaSalida.DataPropertyName = "FechaDeSalida";
            columnaFechaSalida.HeaderText = "Fecha de Salida";
            vuelosDisplay.Columns.Add(columnaFechaSalida);

            DataGridViewTextBoxColumn columnaAsientosDisponibles = new DataGridViewTextBoxColumn();
            columnaAsientosDisponibles.DataPropertyName = "AsientosDisponibles";
            columnaAsientosDisponibles.HeaderText = "Asientos Disponibles";
            vuelosDisplay.Columns.Add(columnaAsientosDisponibles);

            DataGridViewTextBoxColumn columnaCosto = new DataGridViewTextBoxColumn();
            columnaCosto.DataPropertyName = "Costo";
            columnaCosto.HeaderText = "Costo";
            vuelosDisplay.Columns.Add(columnaCosto);

            // Agregar columna de botones "Reservar Vuelo"
            DataGridViewButtonColumn columnaReservar = new DataGridViewButtonColumn();
            columnaReservar.HeaderText = "Reservar Vuelo";
            columnaReservar.Text = "Reservar Vuelo";
            columnaReservar.UseColumnTextForButtonValue = true;
            vuelosDisplay.Columns.Add(columnaReservar);

            // Configurar el evento CellContentClick para manejar clics en el botón "Reservar Vuelo"
            vuelosDisplay.CellContentClick += VuelosDisplay_CellContentClick;


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var LugarOrigenId = cbLugarOrigen.SelectedValue;
            var LugarDestinoId = cbLugarDestino.SelectedValue;
            vuelosDisplay.DataSource = DataAccessLayer.Datos.VuelosFiltrados(Convert.ToInt32(LugarOrigenId), Convert.ToInt32(LugarDestinoId));
            foreach (DataGridViewRow row in vuelosDisplay.Rows)
            {
                // Obtener el VueloId y almacenarlo en la propiedad Tag de la fila
                int vueloId = ((Modelo.TablaVuelos)row.DataBoundItem).VueloId;
                row.Tag = vueloId;
            }
        }
    }
}
