﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Interfaz
{
    public partial class Hub : Form
    {
        //para prueba, se crean variables para capturar valores de login
        private Usuario UsuarioActual;
        
        public Hub(Usuario UsuarioActualconstructor)
        {
            InitializeComponent();

            //para prueba, se asignan los valores recibidos a las variables del Hub
            this.UsuarioActual = UsuarioActualconstructor;
            MostrarCredencialesDeLogIn();
            btnInicio_Click(new object(), new EventArgs());
        }

        // Para pruebas
        // Solicita informacion en los valores de Request de usuario en LogIn
        // Se planea utilizar las credenciales de usuario existentes en la base de datos
        private void MostrarCredencialesDeLogIn()
        {
            lblUser.Text = "Usuario: " + UsuarioActual.Username;
            lblNom.Text = "Nombre:  " + UsuarioActual.Nombres+ " "+ UsuarioActual.ApellidoPaterno;
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
