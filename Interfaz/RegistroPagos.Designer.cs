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
            btnRegTipoPagoNew.Location = new System.Drawing.Point(258, 272);
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
            lblInst1.Location = new System.Drawing.Point(25, 36);
            lblInst1.Name = "lblInst1";
            lblInst1.Size = new System.Drawing.Size(281, 20);
            lblInst1.TabIndex = 5;
            lblInst1.Text = "Registro de Metodos de Pago Nuevos ......";
            // 
            // InputNewCorreoTarjeta
            // 
            InputNewCorreoTarjeta.Location = new System.Drawing.Point(155, 165);
            InputNewCorreoTarjeta.Name = "InputNewCorreoTarjeta";
            InputNewCorreoTarjeta.Size = new System.Drawing.Size(258, 27);
            InputNewCorreoTarjeta.TabIndex = 7;
            // 
            // cbTiposDePago
            // 
            cbTiposDePago.FormattingEnabled = true;
            cbTiposDePago.Location = new System.Drawing.Point(155, 99);
            cbTiposDePago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbTiposDePago.Name = "cbTiposDePago";
            cbTiposDePago.Size = new System.Drawing.Size(209, 28);
            cbTiposDePago.TabIndex = 0;
            // 
            // lblTipoPagoCb
            // 
            lblTipoPagoCb.AutoSize = true;
            lblTipoPagoCb.Location = new System.Drawing.Point(43, 103);
            lblTipoPagoCb.Name = "lblTipoPagoCb";
            lblTipoPagoCb.Size = new System.Drawing.Size(99, 20);
            lblTipoPagoCb.TabIndex = 9;
            lblTipoPagoCb.Text = "Tipo de pago";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(43, 169);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(115, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Tarjeta o Correo";
            // 
            // RegistroPagos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 377);
            Controls.Add(lbl);
            Controls.Add(lblTipoPagoCb);
            Controls.Add(cbTiposDePago);
            Controls.Add(InputNewCorreoTarjeta);
            Controls.Add(lblInst1);
            Controls.Add(btnRegTipoPagoNew);
            Name = "RegistroPagos";
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