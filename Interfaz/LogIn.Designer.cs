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
            btnRegistrarUser = new System.Windows.Forms.Button();
            lblTitulo = new System.Windows.Forms.Label();
            InputUserCred = new System.Windows.Forms.TextBox();
            InputPassCred = new System.Windows.Forms.TextBox();
            btnSendCred = new System.Windows.Forms.Button();
            lblInstruccion1 = new System.Windows.Forms.Label();
            lblInstruccion2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnRegistrarUser
            // 
            btnRegistrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegistrarUser.Location = new System.Drawing.Point(51, 301);
            btnRegistrarUser.Name = "btnRegistrarUser";
            btnRegistrarUser.Size = new System.Drawing.Size(244, 29);
            btnRegistrarUser.TabIndex = 0;
            btnRegistrarUser.Text = "Registrarse";
            btnRegistrarUser.UseVisualStyleBackColor = true;
            btnRegistrarUser.Click += btnRegistrarse_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(114, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(133, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "AeroBook";
            // 
            // InputUserCred
            // 
            InputUserCred.Location = new System.Drawing.Point(51, 123);
            InputUserCred.Name = "InputUserCred";
            InputUserCred.PlaceholderText = "Usuario";
            InputUserCred.Size = new System.Drawing.Size(244, 27);
            InputUserCred.TabIndex = 2;
            // 
            // InputPassCred
            // 
            InputPassCred.Location = new System.Drawing.Point(51, 165);
            InputPassCred.Name = "InputPassCred";
            InputPassCred.PlaceholderText = "Contraseña";
            InputPassCred.Size = new System.Drawing.Size(244, 27);
            InputPassCred.TabIndex = 3;
            // 
            // btnSendCred
            // 
            btnSendCred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSendCred.ForeColor = System.Drawing.SystemColors.InfoText;
            btnSendCred.Location = new System.Drawing.Point(51, 220);
            btnSendCred.Name = "btnSendCred";
            btnSendCred.Size = new System.Drawing.Size(244, 29);
            btnSendCred.TabIndex = 4;
            btnSendCred.Text = "Ingresar";
            btnSendCred.UseVisualStyleBackColor = true;
            btnSendCred.Click += btnSendCred_Click;
            // 
            // lblInstruccion1
            // 
            lblInstruccion1.AutoSize = true;
            lblInstruccion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInstruccion1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblInstruccion1.Location = new System.Drawing.Point(51, 101);
            lblInstruccion1.Name = "lblInstruccion1";
            lblInstruccion1.Size = new System.Drawing.Size(222, 20);
            lblInstruccion1.TabIndex = 5;
            lblInstruccion1.Text = "Ingrese sus datos para continuar";
            // 
            // lblInstruccion2
            // 
            lblInstruccion2.AutoSize = true;
            lblInstruccion2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblInstruccion2.Location = new System.Drawing.Point(51, 278);
            lblInstruccion2.Name = "lblInstruccion2";
            lblInstruccion2.Size = new System.Drawing.Size(154, 20);
            lblInstruccion2.TabIndex = 6;
            lblInstruccion2.Text = "Aun no tienes cuenta?";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 252);
            ClientSize = new System.Drawing.Size(364, 455);
            Controls.Add(lblInstruccion2);
            Controls.Add(lblInstruccion1);
            Controls.Add(btnSendCred);
            Controls.Add(InputPassCred);
            Controls.Add(InputUserCred);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrarUser);
            Name = "LogIn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Acceso de Usuario";
            ResumeLayout(false);
            PerformLayout();
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