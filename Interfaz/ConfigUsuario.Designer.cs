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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextUsuario = new System.Windows.Forms.Label();
            this.guiPass = new System.Windows.Forms.Label();
            this.guiPassVal = new System.Windows.Forms.Label();
            this.guiUsuario = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPassVal = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnUserGen = new System.Windows.Forms.Button();
            this.btnPassGen = new System.Windows.Forms.Button();
            this.contextPass = new System.Windows.Forms.Label();
            this.txtNewLastNameP = new System.Windows.Forms.TextBox();
            this.guiApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNewLastNameM = new System.Windows.Forms.TextBox();
            this.guiApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblApellidoMaterno);
            this.panel1.Controls.Add(this.lblApellidoPaterno);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 94);
            this.panel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // contextUsuario
            // 
            this.contextUsuario.AutoSize = true;
            this.contextUsuario.Location = new System.Drawing.Point(61, 121);
            this.contextUsuario.Name = "contextUsuario";
            this.contextUsuario.Size = new System.Drawing.Size(146, 15);
            this.contextUsuario.TabIndex = 1;
            this.contextUsuario.Text = "Configuración de Nombre";
            // 
            // guiPass
            // 
            this.guiPass.AutoSize = true;
            this.guiPass.Location = new System.Drawing.Point(119, 280);
            this.guiPass.Name = "guiPass";
            this.guiPass.Size = new System.Drawing.Size(107, 15);
            this.guiPass.TabIndex = 4;
            this.guiPass.Text = "Contraseña Nueva:";
            // 
            // guiPassVal
            // 
            this.guiPassVal.AutoSize = true;
            this.guiPassVal.Location = new System.Drawing.Point(81, 307);
            this.guiPassVal.Name = "guiPassVal";
            this.guiPassVal.Size = new System.Drawing.Size(142, 15);
            this.guiPassVal.TabIndex = 5;
            this.guiPassVal.Text = "Reintroduzca Contraseña:";
            // 
            // guiUsuario
            // 
            this.guiUsuario.AutoSize = true;
            this.guiUsuario.Location = new System.Drawing.Point(169, 152);
            this.guiUsuario.Name = "guiUsuario";
            this.guiUsuario.Size = new System.Drawing.Size(54, 15);
            this.guiUsuario.TabIndex = 7;
            this.guiUsuario.Text = "Nombre:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(233, 277);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(209, 23);
            this.txtNewPass.TabIndex = 8;
            // 
            // txtNewPassVal
            // 
            this.txtNewPassVal.Location = new System.Drawing.Point(233, 304);
            this.txtNewPassVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassVal.Name = "txtNewPassVal";
            this.txtNewPassVal.Size = new System.Drawing.Size(209, 23);
            this.txtNewPassVal.TabIndex = 9;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(233, 152);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(209, 23);
            this.txtNewName.TabIndex = 10;
            // 
            // btnUserGen
            // 
            this.btnUserGen.Location = new System.Drawing.Point(472, 205);
            this.btnUserGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserGen.Name = "btnUserGen";
            this.btnUserGen.Size = new System.Drawing.Size(123, 22);
            this.btnUserGen.TabIndex = 12;
            this.btnUserGen.Text = "Reasignar Nombre";
            this.btnUserGen.UseVisualStyleBackColor = true;
            this.btnUserGen.Click += new System.EventHandler(this.btnUserGen_Click);
            // 
            // btnPassGen
            // 
            this.btnPassGen.Location = new System.Drawing.Point(472, 303);
            this.btnPassGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassGen.Name = "btnPassGen";
            this.btnPassGen.Size = new System.Drawing.Size(123, 22);
            this.btnPassGen.TabIndex = 13;
            this.btnPassGen.Text = "Cambiar Contraseña";
            this.btnPassGen.UseVisualStyleBackColor = true;
            this.btnPassGen.Click += new System.EventHandler(this.btnPassGen_Click);
            // 
            // contextPass
            // 
            this.contextPass.AutoSize = true;
            this.contextPass.Location = new System.Drawing.Point(42, 248);
            this.contextPass.Name = "contextPass";
            this.contextPass.Size = new System.Drawing.Size(162, 15);
            this.contextPass.TabIndex = 3;
            this.contextPass.Text = "Configuración de Contraseña";
            // 
            // txtNewLastNameP
            // 
            this.txtNewLastNameP.Location = new System.Drawing.Point(233, 179);
            this.txtNewLastNameP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewLastNameP.Name = "txtNewLastNameP";
            this.txtNewLastNameP.Size = new System.Drawing.Size(209, 23);
            this.txtNewLastNameP.TabIndex = 17;
            // 
            // guiApellidoPaterno
            // 
            this.guiApellidoPaterno.AutoSize = true;
            this.guiApellidoPaterno.Location = new System.Drawing.Point(125, 182);
            this.guiApellidoPaterno.Name = "guiApellidoPaterno";
            this.guiApellidoPaterno.Size = new System.Drawing.Size(98, 15);
            this.guiApellidoPaterno.TabIndex = 16;
            this.guiApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // txtNewLastNameM
            // 
            this.txtNewLastNameM.Location = new System.Drawing.Point(233, 206);
            this.txtNewLastNameM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewLastNameM.Name = "txtNewLastNameM";
            this.txtNewLastNameM.Size = new System.Drawing.Size(209, 23);
            this.txtNewLastNameM.TabIndex = 19;
            // 
            // guiApellidoMaterno
            // 
            this.guiApellidoMaterno.AutoSize = true;
            this.guiApellidoMaterno.Location = new System.Drawing.Point(122, 209);
            this.guiApellidoMaterno.Name = "guiApellidoMaterno";
            this.guiApellidoMaterno.Size = new System.Drawing.Size(102, 15);
            this.guiApellidoMaterno.TabIndex = 18;
            this.guiApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(32, 38);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(98, 15);
            this.lblApellidoPaterno.TabIndex = 17;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(28, 62);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(102, 15);
            this.lblApellidoMaterno.TabIndex = 19;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // ConfigUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.txtNewLastNameM);
            this.Controls.Add(this.guiApellidoMaterno);
            this.Controls.Add(this.txtNewLastNameP);
            this.Controls.Add(this.guiApellidoPaterno);
            this.Controls.Add(this.btnPassGen);
            this.Controls.Add(this.btnUserGen);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewPassVal);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.guiUsuario);
            this.Controls.Add(this.guiPassVal);
            this.Controls.Add(this.guiPass);
            this.Controls.Add(this.contextPass);
            this.Controls.Add(this.contextUsuario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConfigUsuario";
            this.Text = "ConfigUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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