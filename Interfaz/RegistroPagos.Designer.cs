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
            this.btnRegTipoPagoNew = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.lblInst1 = new System.Windows.Forms.Label();
            this.InputNewCorreoTarjeta = new System.Windows.Forms.TextBox();
            this.cbTiposDePago = new System.Windows.Forms.ComboBox();
            this.lblTipoPagoCb = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegTipoPagoNew
            // 
            this.btnRegTipoPagoNew.Location = new System.Drawing.Point(226, 204);
            this.btnRegTipoPagoNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegTipoPagoNew.Name = "btnRegTipoPagoNew";
            this.btnRegTipoPagoNew.Size = new System.Drawing.Size(82, 22);
            this.btnRegTipoPagoNew.TabIndex = 0;
            this.btnRegTipoPagoNew.Text = "Continuar";
            this.btnRegTipoPagoNew.UseVisualStyleBackColor = true;
            this.btnRegTipoPagoNew.Click += new System.EventHandler(this.btnRegTipoPagoNew_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(46, 204);
            this.Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(82, 22);
            this.Regresar.TabIndex = 4;
            this.Regresar.Text = "Cancelar";
            this.Regresar.UseVisualStyleBackColor = true;
            // 
            // lblInst1
            // 
            this.lblInst1.AutoSize = true;
            this.lblInst1.Location = new System.Drawing.Point(22, 27);
            this.lblInst1.Name = "lblInst1";
            this.lblInst1.Size = new System.Drawing.Size(226, 15);
            this.lblInst1.TabIndex = 5;
            this.lblInst1.Text = "Registro de Metodos de Pago Nuevos ......";
            // 
            // InputNewCorreoTarjeta
            // 
            this.InputNewCorreoTarjeta.Location = new System.Drawing.Point(136, 124);
            this.InputNewCorreoTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewCorreoTarjeta.Name = "InputNewCorreoTarjeta";
            this.InputNewCorreoTarjeta.Size = new System.Drawing.Size(226, 23);
            this.InputNewCorreoTarjeta.TabIndex = 7;
            // 
            // cbTiposDePago
            // 
            this.cbTiposDePago.FormattingEnabled = true;
            this.cbTiposDePago.Location = new System.Drawing.Point(136, 74);
            this.cbTiposDePago.Name = "cbTiposDePago";
            this.cbTiposDePago.Size = new System.Drawing.Size(183, 23);
            this.cbTiposDePago.TabIndex = 8;
            // 
            // lblTipoPagoCb
            // 
            this.lblTipoPagoCb.AutoSize = true;
            this.lblTipoPagoCb.Location = new System.Drawing.Point(38, 77);
            this.lblTipoPagoCb.Name = "lblTipoPagoCb";
            this.lblTipoPagoCb.Size = new System.Drawing.Size(76, 15);
            this.lblTipoPagoCb.TabIndex = 9;
            this.lblTipoPagoCb.Text = "Tipo de pago";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 127);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 15);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Tarjeta o Correo";
            // 
            // RegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 283);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTipoPagoCb);
            this.Controls.Add(this.cbTiposDePago);
            this.Controls.Add(this.InputNewCorreoTarjeta);
            this.Controls.Add(this.lblInst1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnRegTipoPagoNew);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroPagos";
            this.Text = "Registro de metodos de pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegTipoPagoNew;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label lblInst1;
        private System.Windows.Forms.TextBox InputNewCorreoTarjeta;
        private System.Windows.Forms.ComboBox cbTiposDePago;
        private System.Windows.Forms.Label lblTipoPagoCb;
        private System.Windows.Forms.Label lbl;
    }
}