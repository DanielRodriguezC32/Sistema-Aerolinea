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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            panelUsr = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblUser = new System.Windows.Forms.Label();
            PanelInicio = new System.Windows.Forms.Panel();
            panelNav = new System.Windows.Forms.TableLayoutPanel();
            btnConfig = new System.Windows.Forms.Button();
            btnPagos = new System.Windows.Forms.Button();
            btnVuelos = new System.Windows.Forms.Button();
            btnInicio = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            panelUsr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelUsr
            // 
            panelUsr.Controls.Add(pictureBox1);
            panelUsr.Controls.Add(lblUser);
            panelUsr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panelUsr.Location = new System.Drawing.Point(3, 3);
            panelUsr.Name = "panelUsr";
            panelUsr.Size = new System.Drawing.Size(211, 114);
            panelUsr.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(67, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(67, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblUser.Location = new System.Drawing.Point(11, 79);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(70, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario: ";
            // 
            // PanelInicio
            // 
            PanelInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            PanelInicio.AutoScroll = true;
            PanelInicio.Location = new System.Drawing.Point(215, 0);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new System.Drawing.Size(946, 694);
            PanelInicio.TabIndex = 3;
            // 
            // panelNav
            // 
            panelNav.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            panelNav.ColumnCount = 1;
            panelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelNav.Controls.Add(btnConfig, 0, 4);
            panelNav.Controls.Add(panelUsr, 0, 0);
            panelNav.Controls.Add(btnPagos, 0, 3);
            panelNav.Controls.Add(btnVuelos, 0, 2);
            panelNav.Controls.Add(btnInicio, 0, 1);
            panelNav.Controls.Add(btnSalir, 0, 6);
            panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            panelNav.Location = new System.Drawing.Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.RowCount = 7;
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            panelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            panelNav.Size = new System.Drawing.Size(217, 694);
            panelNav.TabIndex = 2;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnConfig.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 39, 92);
            btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfig.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfig.ForeColor = System.Drawing.Color.Transparent;
            btnConfig.Location = new System.Drawing.Point(3, 288);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new System.Drawing.Size(211, 49);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "CONFIGURACIÓN";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click_1;
            // 
            // btnPagos
            // 
            btnPagos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnPagos.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 39, 92);
            btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPagos.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPagos.ForeColor = System.Drawing.Color.Transparent;
            btnPagos.Location = new System.Drawing.Point(3, 233);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new System.Drawing.Size(211, 49);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "MÉTODOS DE PAGO";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnVuelos.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnVuelos.FlatAppearance.BorderSize = 0;
            btnVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 39, 92);
            btnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVuelos.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVuelos.ForeColor = System.Drawing.Color.Transparent;
            btnVuelos.Location = new System.Drawing.Point(3, 178);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new System.Drawing.Size(211, 49);
            btnVuelos.TabIndex = 1;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnInicio.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 39, 92);
            btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInicio.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInicio.ForeColor = System.Drawing.Color.Transparent;
            btnInicio.Location = new System.Drawing.Point(3, 123);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new System.Drawing.Size(211, 49);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSalir.BackColor = System.Drawing.Color.FromArgb(6, 54, 122);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 39, 92);
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.Color.Transparent;
            btnSalir.Location = new System.Drawing.Point(3, 638);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(211, 53);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "CERRAR SESIÓN";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Hub
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 252);
            ClientSize = new System.Drawing.Size(1161, 694);
            Controls.Add(panelNav);
            Controls.Add(PanelInicio);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Hub";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hub";
            Click += btnInicio_Click;
            panelUsr.ResumeLayout(false);
            panelUsr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}