using BusinessLogicLayer;
using System.Security.Principal;

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
            gvTabla = new System.Windows.Forms.DataGridView();
            cbLugarOrigen = new System.Windows.Forms.ComboBox();
            cbLugarDestino = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            BuscarVuelos = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            mvForm2 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cbAerolinea = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)gvTabla).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gvTabla
            // 
            gvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTabla.Location = new System.Drawing.Point(16, 138);
            gvTabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gvTabla.Name = "gvTabla";
            gvTabla.RowHeadersWidth = 51;
            gvTabla.RowTemplate.Height = 25;
            gvTabla.Size = new System.Drawing.Size(717, 485);
            gvTabla.TabIndex = 0;
            // 
            // cbLugarOrigen
            // 
            cbLugarOrigen.FormattingEnabled = true;
            cbLugarOrigen.Location = new System.Drawing.Point(105, 16);
            cbLugarOrigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbLugarOrigen.Name = "cbLugarOrigen";
            cbLugarOrigen.Size = new System.Drawing.Size(138, 28);
            cbLugarOrigen.TabIndex = 1;
            // 
            // cbLugarDestino
            // 
            cbLugarDestino.FormattingEnabled = true;
            cbLugarDestino.Location = new System.Drawing.Point(105, 55);
            cbLugarDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbLugarDestino.Name = "cbLugarDestino";
            cbLugarDestino.Size = new System.Drawing.Size(138, 28);
            cbLugarDestino.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Destino";
            // 
            // BuscarVuelos
            // 
            BuscarVuelos.Location = new System.Drawing.Point(279, 47);
            BuscarVuelos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BuscarVuelos.Name = "BuscarVuelos";
            BuscarVuelos.Size = new System.Drawing.Size(130, 43);
            BuscarVuelos.TabIndex = 5;
            BuscarVuelos.Text = "Buscar";
            BuscarVuelos.UseVisualStyleBackColor = true;
            BuscarVuelos.Click += BuscarVuelos_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(mvForm2, 0, 7);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 0, 6);
            tableLayoutPanel1.Location = new System.Drawing.Point(24, 162);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(258, 334);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // mvForm2
            // 
            mvForm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            mvForm2.Location = new System.Drawing.Point(82, 198);
            mvForm2.Name = "mvForm2";
            mvForm2.Size = new System.Drawing.Size(94, 27);
            mvForm2.TabIndex = 9;
            mvForm2.Text = "Ir";
            mvForm2.UseVisualStyleBackColor = true;
            mvForm2.Click += mvForm2_Click;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            button4.Location = new System.Drawing.Point(45, 121);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(168, 31);
            button4.TabIndex = 3;
            button4.Text = "Editar formas de pago";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            button3.Location = new System.Drawing.Point(30, 82);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(198, 31);
            button3.TabIndex = 2;
            button3.Text = "Editar informacion de usuario";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            button2.Location = new System.Drawing.Point(50, 43);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(158, 31);
            button2.TabIndex = 1;
            button2.Text = "No se que ponerle jeje";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.Location = new System.Drawing.Point(74, 4);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 31);
            button1.TabIndex = 0;
            button1.Text = "RERERE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            button5.Location = new System.Drawing.Point(74, 160);
            button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(110, 31);
            button5.TabIndex = 4;
            button5.Text = "Servicios extras";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(113, 68);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(58, 67);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // cbAerolinea
            // 
            cbAerolinea.FormattingEnabled = true;
            cbAerolinea.Location = new System.Drawing.Point(105, 93);
            cbAerolinea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbAerolinea.Name = "cbAerolinea";
            cbAerolinea.Size = new System.Drawing.Size(138, 28);
            cbAerolinea.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Aerolinea";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbAerolinea);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(gvTabla);
            panel1.Controls.Add(cbLugarOrigen);
            panel1.Controls.Add(cbLugarDestino);
            panel1.Controls.Add(BuscarVuelos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(288, 3);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(750, 668);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1334, 881);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvTabla).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView gvTabla;
        private System.Windows.Forms.ComboBox cbLugarOrigen;
        private System.Windows.Forms.ComboBox cbLugarDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarVuelos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbAerolinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mvForm2;
    }
}

