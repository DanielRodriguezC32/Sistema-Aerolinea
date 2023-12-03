using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class UsrInicio : Form
    {
        Modelo.Usuario UsuarioActual;
        List<Modelo.Reservacion> reservaciones;

        public UsrInicio(Modelo.Usuario user)
        {
            UsuarioActual = user;
            InitializeComponent();
            lblNombreUsrInicio.Text = user.Nombres;
            lblApellidoPUsrInicio.Text = user.ApellidoPaterno;
            lblApellidoMUsrInicio.Text = user.ApellidoMaterno;
        }
        public void ActualizarNotificaciones(string notas)
        {
            this.lblNotificacionUsuario.Text = notas;
        }

        public void ActualizarReservaciones()
        {
            reservaciones = BusinessLogicLayer.BLL.ReservacionesPorUsuario(UsuarioActual.UsuarioId);
            GenerarBoletoQR1.Visible = GenerarBoletoQR2.Visible = GenerarBoletoQR3.Visible = GenerarBoletoQR4.Visible
             = GenerarBoletoQR5.Visible = GenerarBoletoQR6.Visible = false;
            if (reservaciones.Count <= 6) {
                switch (reservaciones.Count)
                {
                    case 6: lblReservacionesListaUsrInicio6.Text = reservaciones[5].VueloRutaFecha; GenerarBoletoQR6.Visible = true; goto case 5;
                    case 5: lblReservacionesListaUsrInicio5.Text = reservaciones[4].VueloRutaFecha; GenerarBoletoQR5.Visible = true; goto case 4;
                    case 4: lblReservacionesListaUsrInicio4.Text = reservaciones[3].VueloRutaFecha; GenerarBoletoQR4.Visible = true; goto case 3;
                    case 3: lblReservacionesListaUsrInicio3.Text = reservaciones[2].VueloRutaFecha; GenerarBoletoQR3.Visible = true; goto case 2;
                    case 2: lblReservacionesListaUsrInicio2.Text = reservaciones[1].VueloRutaFecha; GenerarBoletoQR2.Visible = true; goto case 1;
                    case 1: lblReservacionesListaUsrInicio1.Text = reservaciones[0].VueloRutaFecha; GenerarBoletoQR1.Visible = true; goto case 0;
                    case 0: break;                        
                }
                lblMasReservaciones.Visible = false;
            }
            else
            {
                switch (6)
                {
                    case 6: lblReservacionesListaUsrInicio6.Text = reservaciones[5].VueloRutaFecha; GenerarBoletoQR6.Visible = true; goto case 5;
                    case 5: lblReservacionesListaUsrInicio5.Text = reservaciones[4].VueloRutaFecha; GenerarBoletoQR5.Visible = true; goto case 4;
                    case 4: lblReservacionesListaUsrInicio4.Text = reservaciones[3].VueloRutaFecha; GenerarBoletoQR4.Visible = true; goto case 3;
                    case 3: lblReservacionesListaUsrInicio3.Text = reservaciones[2].VueloRutaFecha; GenerarBoletoQR3.Visible = true; goto case 2;
                    case 2: lblReservacionesListaUsrInicio2.Text = reservaciones[1].VueloRutaFecha; GenerarBoletoQR2.Visible = true; goto case 1;
                    case 1: lblReservacionesListaUsrInicio1.Text = reservaciones[0].VueloRutaFecha; GenerarBoletoQR1.Visible = true; goto case 0;
                    case 0: break;
                }
                lblMasReservaciones.Visible = true;
            }
        }

        private void GenerarBoletoQR1_Click(object sender, EventArgs e)
        {
            generarRQ(0);
        }

        private void GenerarBoletoQR2_Click(object sender, EventArgs e)
        {
            generarRQ(1);
        }

        private void GenerarBoletoQR3_Click(object sender, EventArgs e)
        {
            generarRQ(2);
        }

        private void GenerarBoletoQR4_Click(object sender, EventArgs e)
        {
            generarRQ(3);
        }
        private void GenerarBoletoQR5_Click(object sender, EventArgs e)
        {
            generarRQ(4);
        }

        private void GenerarBoletoQR6_Click(object sender, EventArgs e)
        {
            generarRQ(5);
        }

        private void generarRQ(int index)
        {
            
            lblMensajeBoletoSeleccionado.Visible = DescargarQR.Visible = true;
            string textoQR = "Entrada" + reservaciones[index].VueloId.ToString();
            lblQRInfo.Text = reservaciones[index].VueloRutaFecha;            

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            qrCodeImage = ResizeImage(qrCodeImage, pbQR.Width, pbQR.Height);
            pbQR.Image = qrCodeImage;            
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

        private void DescargarQR_Click(object sender, EventArgs e)
        {            
            Bitmap qrCodeImage = (Bitmap)pbQR.Image;
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Boleto.png");
            qrCodeImage.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
