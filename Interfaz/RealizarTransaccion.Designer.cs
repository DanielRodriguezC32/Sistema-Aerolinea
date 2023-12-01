namespace Interfaz
{
    partial class RealizarTransaccion
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
            this.btnCrearTransaccion = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.lblTituloTransaccion = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearTransaccion
            // 
            this.btnCrearTransaccion.Location = new System.Drawing.Point(188, 116);
            this.btnCrearTransaccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearTransaccion.Name = "btnCrearTransaccion";
            this.btnCrearTransaccion.Size = new System.Drawing.Size(82, 22);
            this.btnCrearTransaccion.TabIndex = 0;
            this.btnCrearTransaccion.Text = "Aceptar";
            this.btnCrearTransaccion.UseVisualStyleBackColor = true;
            this.btnCrearTransaccion.Click += new System.EventHandler(this.btnCrearTransaccion_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(49, 116);
            this.Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(82, 22);
            this.Regresar.TabIndex = 4;
            this.Regresar.Text = "Cancelar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // lblTituloTransaccion
            // 
            this.lblTituloTransaccion.AutoSize = true;
            this.lblTituloTransaccion.Location = new System.Drawing.Point(49, 20);
            this.lblTituloTransaccion.Name = "lblTituloTransaccion";
            this.lblTituloTransaccion.Size = new System.Drawing.Size(133, 15);
            this.lblTituloTransaccion.TabIndex = 5;
            this.lblTituloTransaccion.Text = "Realiazr Transacción ......";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Location = new System.Drawing.Point(103, 50);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(167, 23);
            this.cbPago.TabIndex = 6;
            this.cbPago.SelectedIndexChanged += new System.EventHandler(this.cbPago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elegir Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(103, 87);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 15);
            this.lblPrecio.TabIndex = 9;
            // 
            // RealizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPago);
            this.Controls.Add(this.lblTituloTransaccion);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnCrearTransaccion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RealizarTransaccion";
            this.Text = "Registro de usuario nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTransaccion;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label lblTituloTransaccion;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
    }
}