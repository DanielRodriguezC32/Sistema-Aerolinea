namespace Interfaz
{
    partial class RegistroUsuario
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
            this.btnRegUsrNew = new System.Windows.Forms.Button();
            this.InputNewUsrCred = new System.Windows.Forms.TextBox();
            this.InputNewPassCred = new System.Windows.Forms.TextBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.lblInst1 = new System.Windows.Forms.Label();
            this.InputNewNombreCred = new System.Windows.Forms.TextBox();
            this.InputNewApellidoPCred = new System.Windows.Forms.TextBox();
            this.InputNewApellidoMCred = new System.Windows.Forms.TextBox();
            this.NewPassValid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegUsrNew
            // 
            this.btnRegUsrNew.Location = new System.Drawing.Point(128, 221);
            this.btnRegUsrNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegUsrNew.Name = "btnRegUsrNew";
            this.btnRegUsrNew.Size = new System.Drawing.Size(82, 22);
            this.btnRegUsrNew.TabIndex = 0;
            this.btnRegUsrNew.Text = "Continuar";
            this.btnRegUsrNew.UseVisualStyleBackColor = true;
            this.btnRegUsrNew.Click += new System.EventHandler(this.btnRegUsrNew_Click);
            // 
            // InputNewUsrCred
            // 
            this.InputNewUsrCred.Location = new System.Drawing.Point(49, 146);
            this.InputNewUsrCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewUsrCred.Name = "InputNewUsrCred";
            this.InputNewUsrCred.PlaceholderText = "Nombre de Usuario";
            this.InputNewUsrCred.Size = new System.Drawing.Size(263, 23);
            this.InputNewUsrCred.TabIndex = 1;
            // 
            // InputNewPassCred
            // 
            this.InputNewPassCred.Location = new System.Drawing.Point(49, 171);
            this.InputNewPassCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewPassCred.Name = "InputNewPassCred";
            this.InputNewPassCred.PlaceholderText = "Contrasena";
            this.InputNewPassCred.Size = new System.Drawing.Size(263, 23);
            this.InputNewPassCred.TabIndex = 2;
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(49, 282);
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
            this.lblInst1.Location = new System.Drawing.Point(49, 20);
            this.lblInst1.Name = "lblInst1";
            this.lblInst1.Size = new System.Drawing.Size(168, 15);
            this.lblInst1.TabIndex = 5;
            this.lblInst1.Text = "Registro de Usuario Nuevo ......";
            // 
            // InputNewNombreCred
            // 
            this.InputNewNombreCred.Location = new System.Drawing.Point(49, 44);
            this.InputNewNombreCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewNombreCred.Name = "InputNewNombreCred";
            this.InputNewNombreCred.PlaceholderText = "Nombre";
            this.InputNewNombreCred.Size = new System.Drawing.Size(263, 23);
            this.InputNewNombreCred.TabIndex = 6;
            // 
            // InputNewApellidoPCred
            // 
            this.InputNewApellidoPCred.Location = new System.Drawing.Point(49, 68);
            this.InputNewApellidoPCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewApellidoPCred.Name = "InputNewApellidoPCred";
            this.InputNewApellidoPCred.PlaceholderText = "Apellido Paterno";
            this.InputNewApellidoPCred.Size = new System.Drawing.Size(263, 23);
            this.InputNewApellidoPCred.TabIndex = 7;
            // 
            // InputNewApellidoMCred
            // 
            this.InputNewApellidoMCred.Location = new System.Drawing.Point(49, 93);
            this.InputNewApellidoMCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNewApellidoMCred.Name = "InputNewApellidoMCred";
            this.InputNewApellidoMCred.PlaceholderText = "Apellido Materno";
            this.InputNewApellidoMCred.Size = new System.Drawing.Size(263, 23);
            this.InputNewApellidoMCred.TabIndex = 8;
            // 
            // NewPassValid
            // 
            this.NewPassValid.Location = new System.Drawing.Point(49, 196);
            this.NewPassValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPassValid.Name = "NewPassValid";
            this.NewPassValid.PlaceholderText = "Reintroduzca Contrasena";
            this.NewPassValid.Size = new System.Drawing.Size(263, 23);
            this.NewPassValid.TabIndex = 9;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 338);
            this.Controls.Add(this.NewPassValid);
            this.Controls.Add(this.InputNewApellidoMCred);
            this.Controls.Add(this.InputNewApellidoPCred);
            this.Controls.Add(this.InputNewNombreCred);
            this.Controls.Add(this.lblInst1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.InputNewPassCred);
            this.Controls.Add(this.InputNewUsrCred);
            this.Controls.Add(this.btnRegUsrNew);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroUsuario";
            this.Text = "Registro de usuario nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegUsrNew;
        private System.Windows.Forms.TextBox InputNewUsrCred;
        private System.Windows.Forms.TextBox InputNewPassCred;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label lblInst1;
        private System.Windows.Forms.TextBox InputNewNombreCred;
        private System.Windows.Forms.TextBox InputNewApellidoPCred;
        private System.Windows.Forms.TextBox InputNewApellidoMCred;
        private System.Windows.Forms.TextBox NewPassValid;
    }
}