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
            panelUsr = new System.Windows.Forms.Panel();
            PanelInicio = new System.Windows.Forms.Panel();
            panelNav = new System.Windows.Forms.TableLayoutPanel();
            btnInicio = new System.Windows.Forms.Button();
            btnVuelos = new System.Windows.Forms.Button();
            btnPagos = new System.Windows.Forms.Button();
            btnConfig = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelUsr
            // 
            panelUsr.Location = new System.Drawing.Point(12, 12);
            panelUsr.Name = "panelUsr";
            panelUsr.Size = new System.Drawing.Size(261, 75);
            panelUsr.TabIndex = 0;
            // 
            // PanelInicio
            // 
            PanelInicio.Location = new System.Drawing.Point(351, 12);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new System.Drawing.Size(919, 639);
            PanelInicio.TabIndex = 2;
            // 
            // panelNav
            // 
            panelNav.ColumnCount = 1;
            panelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelNav.Controls.Add(btnInicio, 0, 0);
            panelNav.Controls.Add(btnVuelos, 0, 1);
            panelNav.Controls.Add(btnPagos, 0, 2);
            panelNav.Controls.Add(btnConfig, 0, 3);
            panelNav.Controls.Add(btnSalir, 0, 4);
            panelNav.Location = new System.Drawing.Point(12, 121);
            panelNav.Name = "panelNav";
            panelNav.RowCount = 5;
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelNav.Size = new System.Drawing.Size(261, 508);
            panelNav.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnInicio.Location = new System.Drawing.Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new System.Drawing.Size(255, 95);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnVuelos.Location = new System.Drawing.Point(3, 104);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new System.Drawing.Size(255, 95);
            btnVuelos.TabIndex = 1;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = true;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnPagos
            // 
            btnPagos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnPagos.Location = new System.Drawing.Point(3, 205);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new System.Drawing.Size(255, 95);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "METODOS DE PAGO";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnConfig.Location = new System.Drawing.Point(3, 306);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new System.Drawing.Size(255, 95);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "CONFIGURACION";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSalir.Location = new System.Drawing.Point(3, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(255, 98);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Hub
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1309, 663);
            Controls.Add(panelNav);
            Controls.Add(PanelInicio);
            Controls.Add(panelUsr);
            Name = "Hub";
            Text = "Nombre de Usuario";
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}