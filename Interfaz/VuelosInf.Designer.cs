using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    partial class VuelosInf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            vuelosDisplay = new DataGridView();
            cbLugarOrigen = new ComboBox();
            cbLugarDestino = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnFiltrar = new Button();
            ((ISupportInitialize)vuelosDisplay).BeginInit();
            SuspendLayout();
            // 
            // vuelosDisplay
            // 
            vuelosDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vuelosDisplay.Location = new Point(25, 107);
            vuelosDisplay.Name = "vuelosDisplay";
            vuelosDisplay.RowHeadersWidth = 51;
            vuelosDisplay.RowTemplate.Height = 29;
            vuelosDisplay.Size = new Size(805, 380);
            vuelosDisplay.TabIndex = 0;
            // 
            // cbLugarOrigen
            // 
            cbLugarOrigen.FormattingEnabled = true;
            cbLugarOrigen.Location = new Point(115, 19);
            cbLugarOrigen.Name = "cbLugarOrigen";
            cbLugarOrigen.Size = new Size(217, 28);
            cbLugarOrigen.TabIndex = 1;
            // 
            // cbLugarDestino
            // 
            cbLugarDestino.FormattingEnabled = true;
            cbLugarDestino.Location = new Point(115, 63);
            cbLugarDestino.Name = "cbLugarDestino";
            cbLugarDestino.Size = new Size(217, 28);
            cbLugarDestino.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Destino:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(379, 63);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // VuelosInf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 511);
            Controls.Add(btnFiltrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbLugarDestino);
            Controls.Add(cbLugarOrigen);
            Controls.Add(vuelosDisplay);
            Name = "VuelosInf";
            Text = "VuelosInf";
            ((ISupportInitialize)vuelosDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView vuelosDisplay;
        private ComboBox cbLugarOrigen;
        private ComboBox cbLugarDestino;
        private Label label1;
        private Label label2;
        private Button btnFiltrar;
    }
}