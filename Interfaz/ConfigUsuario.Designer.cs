namespace Interfaz
{
    partial class ConfigUsuario
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
            panel1 = new System.Windows.Forms.Panel();
            lblApellidoMaterno = new System.Windows.Forms.Label();
            lblApellidoPaterno = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            contextUsuario = new System.Windows.Forms.Label();
            guiPass = new System.Windows.Forms.Label();
            guiPassVal = new System.Windows.Forms.Label();
            guiUsuario = new System.Windows.Forms.Label();
            txtNewPass = new System.Windows.Forms.TextBox();
            txtNewPassVal = new System.Windows.Forms.TextBox();
            txtNewName = new System.Windows.Forms.TextBox();
            btnUserGen = new System.Windows.Forms.Button();
            btnPassGen = new System.Windows.Forms.Button();
            contextPass = new System.Windows.Forms.Label();
            txtNewLastNameP = new System.Windows.Forms.TextBox();
            guiApellidoPaterno = new System.Windows.Forms.Label();
            txtNewLastNameM = new System.Windows.Forms.TextBox();
            guiApellidoMaterno = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblApellidoMaterno);
            panel1.Controls.Add(lblApellidoPaterno);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new System.Drawing.Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(874, 125);
            panel1.TabIndex = 8;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Location = new System.Drawing.Point(32, 83);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new System.Drawing.Size(129, 20);
            lblApellidoMaterno.TabIndex = 8;
            lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Location = new System.Drawing.Point(37, 51);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new System.Drawing.Size(123, 20);
            lblApellidoPaterno.TabIndex = 8;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(87, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // contextUsuario
            // 
            contextUsuario.AutoSize = true;
            contextUsuario.Location = new System.Drawing.Point(70, 161);
            contextUsuario.Name = "contextUsuario";
            contextUsuario.Size = new System.Drawing.Size(182, 20);
            contextUsuario.TabIndex = 9;
            contextUsuario.Text = "Configuración de Nombre";
            // 
            // guiPass
            // 
            guiPass.AutoSize = true;
            guiPass.Location = new System.Drawing.Point(136, 373);
            guiPass.Name = "guiPass";
            guiPass.Size = new System.Drawing.Size(132, 20);
            guiPass.TabIndex = 9;
            guiPass.Text = "Contraseña Nueva:";
            // 
            // guiPassVal
            // 
            guiPassVal.AutoSize = true;
            guiPassVal.Location = new System.Drawing.Point(93, 409);
            guiPassVal.Name = "guiPassVal";
            guiPassVal.Size = new System.Drawing.Size(177, 20);
            guiPassVal.TabIndex = 9;
            guiPassVal.Text = "Reintroduzca Contraseña:";
            // 
            // guiUsuario
            // 
            guiUsuario.AutoSize = true;
            guiUsuario.Location = new System.Drawing.Point(193, 203);
            guiUsuario.Name = "guiUsuario";
            guiUsuario.Size = new System.Drawing.Size(67, 20);
            guiUsuario.TabIndex = 9;
            guiUsuario.Text = "Nombre:";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new System.Drawing.Point(266, 369);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new System.Drawing.Size(238, 27);
            txtNewPass.TabIndex = 5;
            // 
            // txtNewPassVal
            // 
            txtNewPassVal.Location = new System.Drawing.Point(266, 405);
            txtNewPassVal.Name = "txtNewPassVal";
            txtNewPassVal.Size = new System.Drawing.Size(238, 27);
            txtNewPassVal.TabIndex = 6;
            // 
            // txtNewName
            // 
            txtNewName.Location = new System.Drawing.Point(266, 203);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new System.Drawing.Size(238, 27);
            txtNewName.TabIndex = 1;
            // 
            // btnUserGen
            // 
            btnUserGen.Location = new System.Drawing.Point(539, 273);
            btnUserGen.Name = "btnUserGen";
            btnUserGen.Size = new System.Drawing.Size(141, 29);
            btnUserGen.TabIndex = 4;
            btnUserGen.Text = "Actualizar";
            btnUserGen.UseVisualStyleBackColor = true;
            btnUserGen.Click += btnUserGen_Click;
            // 
            // btnPassGen
            // 
            btnPassGen.Location = new System.Drawing.Point(539, 404);
            btnPassGen.Name = "btnPassGen";
            btnPassGen.Size = new System.Drawing.Size(141, 29);
            btnPassGen.TabIndex = 7;
            btnPassGen.Text = "Actualizar";
            btnPassGen.UseVisualStyleBackColor = true;
            btnPassGen.Click += btnPassGen_Click;
            // 
            // contextPass
            // 
            contextPass.AutoSize = true;
            contextPass.Location = new System.Drawing.Point(48, 331);
            contextPass.Name = "contextPass";
            contextPass.Size = new System.Drawing.Size(201, 20);
            contextPass.TabIndex = 9;
            contextPass.Text = "Configuración de Contraseña";
            // 
            // txtNewLastNameP
            // 
            txtNewLastNameP.Location = new System.Drawing.Point(266, 239);
            txtNewLastNameP.Name = "txtNewLastNameP";
            txtNewLastNameP.Size = new System.Drawing.Size(238, 27);
            txtNewLastNameP.TabIndex = 2;
            // 
            // guiApellidoPaterno
            // 
            guiApellidoPaterno.AutoSize = true;
            guiApellidoPaterno.Location = new System.Drawing.Point(143, 243);
            guiApellidoPaterno.Name = "guiApellidoPaterno";
            guiApellidoPaterno.Size = new System.Drawing.Size(123, 20);
            guiApellidoPaterno.TabIndex = 9;
            guiApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // txtNewLastNameM
            // 
            txtNewLastNameM.Location = new System.Drawing.Point(266, 275);
            txtNewLastNameM.Name = "txtNewLastNameM";
            txtNewLastNameM.Size = new System.Drawing.Size(238, 27);
            txtNewLastNameM.TabIndex = 3;
            // 
            // guiApellidoMaterno
            // 
            guiApellidoMaterno.AutoSize = true;
            guiApellidoMaterno.Location = new System.Drawing.Point(139, 279);
            guiApellidoMaterno.Name = "guiApellidoMaterno";
            guiApellidoMaterno.Size = new System.Drawing.Size(129, 20);
            guiApellidoMaterno.TabIndex = 9;
            guiApellidoMaterno.Text = "Apellido Materno:";
            // 
            // ConfigUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(898, 592);
            Controls.Add(txtNewLastNameM);
            Controls.Add(guiApellidoMaterno);
            Controls.Add(txtNewLastNameP);
            Controls.Add(guiApellidoPaterno);
            Controls.Add(btnPassGen);
            Controls.Add(btnUserGen);
            Controls.Add(txtNewName);
            Controls.Add(txtNewPassVal);
            Controls.Add(txtNewPass);
            Controls.Add(guiUsuario);
            Controls.Add(guiPassVal);
            Controls.Add(guiPass);
            Controls.Add(contextPass);
            Controls.Add(contextUsuario);
            Controls.Add(panel1);
            Name = "ConfigUsuario";
            Text = "ConfigUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label contextUsuario;
        private System.Windows.Forms.Label guiPass;
        private System.Windows.Forms.Label guiPassVal;
        private System.Windows.Forms.Label guiUsuario;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPassVal;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnUserGen;
        private System.Windows.Forms.Button btnPassGen;
        private System.Windows.Forms.Label contextPass;
        private System.Windows.Forms.TextBox txtNewLastNameP;
        private System.Windows.Forms.Label guiApellidoPaterno;
        private System.Windows.Forms.TextBox txtNewLastNameM;
        private System.Windows.Forms.Label guiApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
    }
}