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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            vuelosDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            vuelosDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vuelosDisplay.Location = new Point(62, 197);
            vuelosDisplay.Name = "vuelosDisplay";
            vuelosDisplay.RowHeadersWidth = 51;
            vuelosDisplay.RowTemplate.Height = 29;
            vuelosDisplay.Size = new Size(805, 380);
            vuelosDisplay.TabIndex = 0;
            // 
            // cbLugarOrigen
            // 
            cbLugarOrigen.FormattingEnabled = true;
            cbLugarOrigen.Location = new Point(152, 59);
            cbLugarOrigen.Name = "cbLugarOrigen";
            cbLugarOrigen.Size = new Size(217, 28);
            cbLugarOrigen.TabIndex = 1;
            // 
            // cbLugarDestino
            // 
            cbLugarDestino.FormattingEnabled = true;
            cbLugarDestino.Location = new Point(152, 103);
            cbLugarDestino.Name = "cbLugarDestino";
            cbLugarDestino.Size = new Size(217, 28);
            cbLugarDestino.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(66, 66, 66);
            label1.Location = new Point(62, 59);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(66, 66, 66);
            label2.Location = new Point(62, 103);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Destino:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(235, 242, 252);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.ForeColor = Color.FromArgb(66, 66, 66);
            btnFiltrar.Location = new Point(416, 103);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // VuelosInf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 242, 252);
            ClientSize = new Size(928, 647);
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