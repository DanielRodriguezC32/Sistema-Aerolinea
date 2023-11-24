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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void mvForm1_Click(object sender, EventArgs e)
        {
            //escondemos
            this.Hide();

            //sesion de la otra pagina
            Form1 form1 = new Form1();
            //la mostramos
            form1.ShowDialog();
            //cuando se cierre la otra abrimos esta nuevamente
            this.Show();
        }
    }
}
