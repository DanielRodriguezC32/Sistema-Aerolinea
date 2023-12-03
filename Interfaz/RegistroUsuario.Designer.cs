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
            btnRegUsrNew = new System.Windows.Forms.Button();
            InputNewUsrCred = new System.Windows.Forms.TextBox();
            InputNewPassCred = new System.Windows.Forms.TextBox();
            Regresar = new System.Windows.Forms.Button();
            lblInst1 = new System.Windows.Forms.Label();
            InputNewNombreCred = new System.Windows.Forms.TextBox();
            InputNewApellidoPCred = new System.Windows.Forms.TextBox();
            InputNewApellidoMCred = new System.Windows.Forms.TextBox();
            NewPassValid = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnRegUsrNew
            // 
            btnRegUsrNew.Location = new System.Drawing.Point(146, 295);
            btnRegUsrNew.Name = "btnRegUsrNew";
            btnRegUsrNew.Size = new System.Drawing.Size(94, 29);
            btnRegUsrNew.TabIndex = 7;
            btnRegUsrNew.Text = "Continuar";
            btnRegUsrNew.UseVisualStyleBackColor = true;
            btnRegUsrNew.Click += btnRegUsrNew_Click;
            // 
            // InputNewUsrCred
            // 
            InputNewUsrCred.Location = new System.Drawing.Point(56, 195);
            InputNewUsrCred.Name = "InputNewUsrCred";
            InputNewUsrCred.PlaceholderText = "Nombre de Usuario";
            InputNewUsrCred.Size = new System.Drawing.Size(300, 27);
            InputNewUsrCred.TabIndex = 4;
            // 
            // InputNewPassCred
            // 
            InputNewPassCred.Location = new System.Drawing.Point(56, 228);
            InputNewPassCred.Name = "InputNewPassCred";
            InputNewPassCred.PlaceholderText = "Contrasena";
            InputNewPassCred.Size = new System.Drawing.Size(300, 27);
            InputNewPassCred.TabIndex = 5;
            // 
            // Regresar
            // 
            Regresar.Location = new System.Drawing.Point(56, 376);
            Regresar.Name = "Regresar";
            Regresar.Size = new System.Drawing.Size(94, 29);
            Regresar.TabIndex = 8;
            Regresar.Text = "Cancelar";
            Regresar.UseVisualStyleBackColor = true;
            Regresar.Click += Regresar_Click;
            // 
            // lblInst1
            // 
            lblInst1.AutoSize = true;
            lblInst1.Location = new System.Drawing.Point(56, 27);
            lblInst1.Name = "lblInst1";
            lblInst1.Size = new System.Drawing.Size(208, 20);
            lblInst1.TabIndex = 0;
            lblInst1.Text = "Registro de Usuario Nuevo ......";
            // 
            // InputNewNombreCred
            // 
            InputNewNombreCred.Location = new System.Drawing.Point(56, 59);
            InputNewNombreCred.Name = "InputNewNombreCred";
            InputNewNombreCred.PlaceholderText = "Nombre";
            InputNewNombreCred.Size = new System.Drawing.Size(300, 27);
            InputNewNombreCred.TabIndex = 1;
            // 
            // InputNewApellidoPCred
            // 
            InputNewApellidoPCred.Location = new System.Drawing.Point(56, 91);
            InputNewApellidoPCred.Name = "InputNewApellidoPCred";
            InputNewApellidoPCred.PlaceholderText = "Apellido Paterno";
            InputNewApellidoPCred.Size = new System.Drawing.Size(300, 27);
            InputNewApellidoPCred.TabIndex = 2;
            // 
            // InputNewApellidoMCred
            // 
            InputNewApellidoMCred.Location = new System.Drawing.Point(56, 124);
            InputNewApellidoMCred.Name = "InputNewApellidoMCred";
            InputNewApellidoMCred.PlaceholderText = "Apellido Materno";
            InputNewApellidoMCred.Size = new System.Drawing.Size(300, 27);
            InputNewApellidoMCred.TabIndex = 3;
            // 
            // NewPassValid
            // 
            NewPassValid.Location = new System.Drawing.Point(56, 261);
            NewPassValid.Name = "NewPassValid";
            NewPassValid.PlaceholderText = "Reintroduzca Contrasena";
            NewPassValid.Size = new System.Drawing.Size(300, 27);
            NewPassValid.TabIndex = 6;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 451);
            Controls.Add(NewPassValid);
            Controls.Add(InputNewApellidoMCred);
            Controls.Add(InputNewApellidoPCred);
            Controls.Add(InputNewNombreCred);
            Controls.Add(lblInst1);
            Controls.Add(Regresar);
            Controls.Add(InputNewPassCred);
            Controls.Add(InputNewUsrCred);
            Controls.Add(btnRegUsrNew);
            Name = "RegistroUsuario";
            Text = "Registro de usuario nuevo";
            ResumeLayout(false);
            PerformLayout();
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