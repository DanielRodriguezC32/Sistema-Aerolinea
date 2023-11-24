using BusinessLogicLayer;
namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvTabla = new System.Windows.Forms.DataGridView();
            this.cbLugarOrigen = new System.Windows.Forms.ComboBox();
            this.cbLugarDestino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTabla
            // 
            this.gvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTabla.Location = new System.Drawing.Point(131, 84);
            this.gvTabla.Name = "gvTabla";
            this.gvTabla.RowTemplate.Height = 25;
            this.gvTabla.Size = new System.Drawing.Size(518, 236);
            this.gvTabla.TabIndex = 0;
            // 
            // cbLugarOrigen
            // 
            this.cbLugarOrigen.FormattingEnabled = true;
            this.cbLugarOrigen.Location = new System.Drawing.Point(120, 39);
            this.cbLugarOrigen.Name = "cbLugarOrigen";
            this.cbLugarOrigen.Size = new System.Drawing.Size(121, 23);
            this.cbLugarOrigen.TabIndex = 1;
            // 
            // cbLugarDestino
            // 
            this.cbLugarDestino.FormattingEnabled = true;
            this.cbLugarDestino.Location = new System.Drawing.Point(339, 39);
            this.cbLugarDestino.Name = "cbLugarDestino";
            this.cbLugarDestino.Size = new System.Drawing.Size(121, 23);
            this.cbLugarDestino.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLugarDestino);
            this.Controls.Add(this.cbLugarOrigen);
            this.Controls.Add(this.gvTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTabla;
        private System.Windows.Forms.ComboBox cbLugarOrigen;
        private System.Windows.Forms.ComboBox cbLugarDestino;
    }
}

