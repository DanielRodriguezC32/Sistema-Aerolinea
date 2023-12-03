namespace Interfaz
{
    partial class Hub
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
            this.panelUsr = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelUsr.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsr
            // 
            this.panelUsr.Controls.Add(this.lblNom);
            this.panelUsr.Controls.Add(this.lblUser);
            this.panelUsr.Location = new System.Drawing.Point(10, 9);
            this.panelUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsr.Name = "panelUsr";
            this.panelUsr.Size = new System.Drawing.Size(228, 56);
            this.panelUsr.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(19, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(57, 15);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(19, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario: ";
            // 
            // PanelInicio
            // 
            this.PanelInicio.Location = new System.Drawing.Point(307, 9);
            this.PanelInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(804, 637);
            this.PanelInicio.TabIndex = 2;
            // 
            // panelNav
            // 
            this.panelNav.ColumnCount = 1;
            this.panelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNav.Controls.Add(this.btnInicio, 0, 0);
            this.panelNav.Controls.Add(this.btnVuelos, 0, 1);
            this.panelNav.Controls.Add(this.btnPagos, 0, 2);
            this.panelNav.Controls.Add(this.btnConfig, 0, 3);
            this.panelNav.Controls.Add(this.btnSalir, 0, 4);
            this.panelNav.Location = new System.Drawing.Point(10, 91);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.RowCount = 5;
            this.panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNav.Size = new System.Drawing.Size(228, 381);
            this.panelNav.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicio.Location = new System.Drawing.Point(3, 2);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(222, 72);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnVuelos
            // 
            this.btnVuelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVuelos.Location = new System.Drawing.Point(3, 78);
            this.btnVuelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(222, 72);
            this.btnVuelos.TabIndex = 1;
            this.btnVuelos.Text = "VUELOS";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagos.Location = new System.Drawing.Point(3, 154);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(222, 72);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "METODOS DE PAGO";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.Location = new System.Drawing.Point(3, 230);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(222, 72);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "CONFIGURACION";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(3, 306);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 73);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 657);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.PanelInicio);
            this.Controls.Add(this.panelUsr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hub";
            this.Text = "Hub";
            this.Click += new System.EventHandler(this.btnInicio_Click);
            this.panelUsr.ResumeLayout(false);
            this.panelUsr.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsr;
        private System.Windows.Forms.Panel PanelInicio;
        private System.Windows.Forms.TableLayoutPanel panelNav;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblUser;
    }
}