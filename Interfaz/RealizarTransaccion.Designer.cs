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
            btnCrearTransaccion = new System.Windows.Forms.Button();
            Regresar = new System.Windows.Forms.Button();
            lblTituloTransaccion = new System.Windows.Forms.Label();
            cbPago = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCrearTransaccion
            // 
            btnCrearTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCrearTransaccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCrearTransaccion.Location = new System.Drawing.Point(245, 185);
            btnCrearTransaccion.Name = "btnCrearTransaccion";
            btnCrearTransaccion.Size = new System.Drawing.Size(94, 29);
            btnCrearTransaccion.TabIndex = 0;
            btnCrearTransaccion.Text = "Aceptar";
            btnCrearTransaccion.UseVisualStyleBackColor = true;
            btnCrearTransaccion.Click += btnCrearTransaccion_Click;
            // 
            // Regresar
            // 
            Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Regresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Regresar.Location = new System.Drawing.Point(86, 185);
            Regresar.Name = "Regresar";
            Regresar.Size = new System.Drawing.Size(94, 29);
            Regresar.TabIndex = 4;
            Regresar.Text = "Cancelar";
            Regresar.UseVisualStyleBackColor = true;
            Regresar.Click += Regresar_Click;
            // 
            // lblTituloTransaccion
            // 
            lblTituloTransaccion.AutoSize = true;
            lblTituloTransaccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloTransaccion.Location = new System.Drawing.Point(86, 57);
            lblTituloTransaccion.Name = "lblTituloTransaccion";
            lblTituloTransaccion.Size = new System.Drawing.Size(175, 20);
            lblTituloTransaccion.TabIndex = 5;
            lblTituloTransaccion.Text = "Realizar Transacción ......";
            // 
            // cbPago
            // 
            cbPago.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbPago.FormattingEnabled = true;
            cbPago.Location = new System.Drawing.Point(148, 97);
            cbPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbPago.Name = "cbPago";
            cbPago.Size = new System.Drawing.Size(190, 28);
            cbPago.TabIndex = 6;
            cbPago.SelectedIndexChanged += cbPago_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(50, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "Elegir Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(65, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecio.Location = new System.Drawing.Point(148, 146);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(0, 20);
            lblPrecio.TabIndex = 9;
            // 
            // RealizarTransaccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 252);
            ClientSize = new System.Drawing.Size(404, 297);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPago);
            Controls.Add(lblTituloTransaccion);
            Controls.Add(Regresar);
            Controls.Add(btnCrearTransaccion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "RealizarTransaccion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Registro de usuario nuevo";
            ResumeLayout(false);
            PerformLayout();
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