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
            this.vuelosDisplay = new System.Windows.Forms.DataGridView();
            this.cbLugarOrigen = new System.Windows.Forms.ComboBox();
            this.cbLugarDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbAerolinea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // vuelosDisplay
            // 
            this.vuelosDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vuelosDisplay.Location = new System.Drawing.Point(23, 116);
            this.vuelosDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vuelosDisplay.Name = "vuelosDisplay";
            this.vuelosDisplay.RowHeadersWidth = 51;
            this.vuelosDisplay.RowTemplate.Height = 29;
            this.vuelosDisplay.Size = new System.Drawing.Size(657, 285);
            this.vuelosDisplay.TabIndex = 0;
            // 
            // cbLugarOrigen
            // 
            this.cbLugarOrigen.FormattingEnabled = true;
            this.cbLugarOrigen.Location = new System.Drawing.Point(102, 50);
            this.cbLugarOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLugarOrigen.Name = "cbLugarOrigen";
            this.cbLugarOrigen.Size = new System.Drawing.Size(190, 23);
            this.cbLugarOrigen.TabIndex = 1;
            // 
            // cbLugarDestino
            // 
            this.cbLugarDestino.FormattingEnabled = true;
            this.cbLugarDestino.Location = new System.Drawing.Point(102, 83);
            this.cbLugarDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLugarDestino.Name = "cbLugarDestino";
            this.cbLugarDestino.Size = new System.Drawing.Size(190, 23);
            this.cbLugarDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(333, 83);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(82, 22);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbAerolinea
            // 
            this.cbAerolinea.FormattingEnabled = true;
            this.cbAerolinea.Location = new System.Drawing.Point(102, 9);
            this.cbAerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAerolinea.Name = "cbAerolinea";
            this.cbAerolinea.Size = new System.Drawing.Size(190, 23);
            this.cbAerolinea.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aerolinea:";
            // 
            // VuelosInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAerolinea);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLugarDestino);
            this.Controls.Add(this.cbLugarOrigen);
            this.Controls.Add(this.vuelosDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VuelosInf";
            this.Text = "VuelosInf";
            ((System.ComponentModel.ISupportInitialize)(this.vuelosDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView vuelosDisplay;
        private ComboBox cbLugarOrigen;
        private ComboBox cbLugarDestino;
        private Label label1;
        private Label label2;
        private Button btnFiltrar;
        private ComboBox cbAerolinea;
        private Label label3;
    }
}