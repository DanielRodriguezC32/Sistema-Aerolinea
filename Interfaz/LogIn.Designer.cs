namespace Interfaz
{
    partial class LogIn
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
            this.btnRegistrarUser = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.InputUserCred = new System.Windows.Forms.TextBox();
            this.InputPassCred = new System.Windows.Forms.TextBox();
            this.btnSendCred = new System.Windows.Forms.Button();
            this.lblInstruccion1 = new System.Windows.Forms.Label();
            this.lblInstruccion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarUser
            // 
            this.btnRegistrarUser.Location = new System.Drawing.Point(207, 292);
            this.btnRegistrarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarUser.Name = "btnRegistrarUser";
            this.btnRegistrarUser.Size = new System.Drawing.Size(82, 22);
            this.btnRegistrarUser.TabIndex = 0;
            this.btnRegistrarUser.Text = "Registrarse";
            this.btnRegistrarUser.UseVisualStyleBackColor = true;
            this.btnRegistrarUser.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(100, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "AeroBook";
            // 
            // InputUserCred
            // 
            this.InputUserCred.Location = new System.Drawing.Point(45, 92);
            this.InputUserCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputUserCred.Name = "InputUserCred";
            this.InputUserCred.PlaceholderText = "Usuario";
            this.InputUserCred.Size = new System.Drawing.Size(214, 23);
            this.InputUserCred.TabIndex = 2;
            // 
            // InputPassCred
            // 
            this.InputPassCred.Location = new System.Drawing.Point(45, 124);
            this.InputPassCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputPassCred.Name = "InputPassCred";
            this.InputPassCred.PlaceholderText = "Contrasena";
            this.InputPassCred.Size = new System.Drawing.Size(214, 23);
            this.InputPassCred.TabIndex = 3;
            // 
            // btnSendCred
            // 
            this.btnSendCred.Location = new System.Drawing.Point(112, 148);
            this.btnSendCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCred.Name = "btnSendCred";
            this.btnSendCred.Size = new System.Drawing.Size(82, 22);
            this.btnSendCred.TabIndex = 4;
            this.btnSendCred.Text = "Ingresar";
            this.btnSendCred.UseVisualStyleBackColor = true;
            this.btnSendCred.Click += new System.EventHandler(this.btnSendCred_Click);
            // 
            // lblInstruccion1
            // 
            this.lblInstruccion1.AutoSize = true;
            this.lblInstruccion1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstruccion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstruccion1.Location = new System.Drawing.Point(45, 76);
            this.lblInstruccion1.Name = "lblInstruccion1";
            this.lblInstruccion1.Size = new System.Drawing.Size(176, 13);
            this.lblInstruccion1.TabIndex = 5;
            this.lblInstruccion1.Text = "Ingrese sus datos para continuar";
            // 
            // lblInstruccion2
            // 
            this.lblInstruccion2.AutoSize = true;
            this.lblInstruccion2.Location = new System.Drawing.Point(52, 316);
            this.lblInstruccion2.Name = "lblInstruccion2";
            this.lblInstruccion2.Size = new System.Drawing.Size(217, 15);
            this.lblInstruccion2.TabIndex = 6;
            this.lblInstruccion2.Text = "Aun no tienes cuenta? Registrate aqui!...";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 338);
            this.Controls.Add(this.lblInstruccion2);
            this.Controls.Add(this.lblInstruccion1);
            this.Controls.Add(this.btnSendCred);
            this.Controls.Add(this.InputPassCred);
            this.Controls.Add(this.InputUserCred);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRegistrarUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.Text = "Acceso de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarUser;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox InputUserCred;
        private System.Windows.Forms.TextBox InputPassCred;
        private System.Windows.Forms.Button btnSendCred;
        private System.Windows.Forms.Label lblInstruccion1;
        private System.Windows.Forms.Label lblInstruccion2;
    }
}