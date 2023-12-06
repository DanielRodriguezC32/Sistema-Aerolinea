namespace Interfaz
{
    partial class RegistroPagos
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
            btnRegTipoPagoNew = new System.Windows.Forms.Button();
            lblInst1 = new System.Windows.Forms.Label();
            InputNewCorreoTarjeta = new System.Windows.Forms.TextBox();
            cbTiposDePago = new System.Windows.Forms.ComboBox();
            lblTipoPagoCb = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnRegTipoPagoNew
            // 
            btnRegTipoPagoNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegTipoPagoNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegTipoPagoNew.Location = new System.Drawing.Point(430, 347);
            btnRegTipoPagoNew.Name = "btnRegTipoPagoNew";
            btnRegTipoPagoNew.Size = new System.Drawing.Size(94, 29);
            btnRegTipoPagoNew.TabIndex = 8;
            btnRegTipoPagoNew.Text = "Registrar";
            btnRegTipoPagoNew.UseVisualStyleBackColor = true;
            btnRegTipoPagoNew.Click += btnRegTipoPagoNew_Click;
            // 
            // lblInst1
            // 
            lblInst1.AutoSize = true;
            lblInst1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInst1.Location = new System.Drawing.Point(331, 140);
            lblInst1.Name = "lblInst1";
            lblInst1.Size = new System.Drawing.Size(294, 20);
            lblInst1.TabIndex = 5;
            lblInst1.Text = "Registro de Metodos de Pago Nuevos ......";
            // 
            // InputNewCorreoTarjeta
            // 
            InputNewCorreoTarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            InputNewCorreoTarjeta.Location = new System.Drawing.Point(350, 271);
            InputNewCorreoTarjeta.Name = "InputNewCorreoTarjeta";
            InputNewCorreoTarjeta.Size = new System.Drawing.Size(249, 27);
            InputNewCorreoTarjeta.TabIndex = 7;
            // 
            // cbTiposDePago
            // 
            cbTiposDePago.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbTiposDePago.FormattingEnabled = true;
            cbTiposDePago.Location = new System.Drawing.Point(350, 206);
            cbTiposDePago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbTiposDePago.Name = "cbTiposDePago";
            cbTiposDePago.Size = new System.Drawing.Size(249, 28);
            cbTiposDePago.TabIndex = 0;
            // 
            // lblTipoPagoCb
            // 
            lblTipoPagoCb.AutoSize = true;
            lblTipoPagoCb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTipoPagoCb.Location = new System.Drawing.Point(241, 209);
            lblTipoPagoCb.Name = "lblTipoPagoCb";
            lblTipoPagoCb.Size = new System.Drawing.Size(103, 20);
            lblTipoPagoCb.TabIndex = 9;
            lblTipoPagoCb.Text = "Tipo de pago:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(221, 274);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(123, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Tarjeta o Correo:";
            // 
            // RegistroPagos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 252);
            ClientSize = new System.Drawing.Size(928, 647);
            Controls.Add(lbl);
            Controls.Add(lblTipoPagoCb);
            Controls.Add(cbTiposDePago);
            Controls.Add(InputNewCorreoTarjeta);
            Controls.Add(lblInst1);
            Controls.Add(btnRegTipoPagoNew);
            Name = "RegistroPagos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Registro de metodos de pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegTipoPagoNew;
        private System.Windows.Forms.Label lblInst1;
        private System.Windows.Forms.TextBox InputNewCorreoTarjeta;
        private System.Windows.Forms.ComboBox cbTiposDePago;
        private System.Windows.Forms.Label lblTipoPagoCb;
        private System.Windows.Forms.Label lbl;
    }
}