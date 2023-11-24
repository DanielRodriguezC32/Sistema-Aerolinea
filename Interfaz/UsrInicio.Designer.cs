namespace Interfaz
{
    partial class UsrInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbInicioUsuario = new System.Windows.Forms.GroupBox();
            gbInicioNotif = new System.Windows.Forms.GroupBox();
            gbInicioReservaciones = new System.Windows.Forms.GroupBox();
            SuspendLayout();
            // 
            // gbInicioUsuario
            // 
            gbInicioUsuario.Location = new System.Drawing.Point(12, 14);
            gbInicioUsuario.Name = "gbInicioUsuario";
            gbInicioUsuario.Size = new System.Drawing.Size(776, 160);
            gbInicioUsuario.TabIndex = 0;
            gbInicioUsuario.TabStop = false;
            gbInicioUsuario.Text = "Usuario";
            // 
            // gbInicioNotif
            // 
            gbInicioNotif.Location = new System.Drawing.Point(12, 180);
            gbInicioNotif.Name = "gbInicioNotif";
            gbInicioNotif.Size = new System.Drawing.Size(776, 82);
            gbInicioNotif.TabIndex = 1;
            gbInicioNotif.TabStop = false;
            gbInicioNotif.Text = "Notificaciones";
            // 
            // gbInicioReservaciones
            // 
            gbInicioReservaciones.Location = new System.Drawing.Point(12, 278);
            gbInicioReservaciones.Name = "gbInicioReservaciones";
            gbInicioReservaciones.Size = new System.Drawing.Size(776, 271);
            gbInicioReservaciones.TabIndex = 2;
            gbInicioReservaciones.TabStop = false;
            gbInicioReservaciones.Text = "Reservaciones";
            // 
            // UsrInicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 561);
            Controls.Add(gbInicioReservaciones);
            Controls.Add(gbInicioNotif);
            Controls.Add(gbInicioUsuario);
            Name = "UsrInicio";
            Text = "UsrInicio";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicioUsuario;
        private System.Windows.Forms.GroupBox gbInicioNotif;
        private System.Windows.Forms.GroupBox gbInicioReservaciones;
    }
}