namespace Interfaz
{
    partial class Form2
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
            mvForm1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // mvForm1
            // 
            mvForm1.Location = new System.Drawing.Point(409, 358);
            mvForm1.Name = "mvForm1";
            mvForm1.Size = new System.Drawing.Size(94, 29);
            mvForm1.TabIndex = 0;
            mvForm1.Text = "Regresar";
            mvForm1.UseVisualStyleBackColor = true;
            mvForm1.Click += mvForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1002, 564);
            Controls.Add(mvForm1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button mvForm1;
    }
}