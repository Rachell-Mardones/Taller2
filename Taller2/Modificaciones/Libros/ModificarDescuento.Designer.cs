﻿
namespace Taller2
{
    partial class ModificarDescuento
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
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboISBNLibro = new System.Windows.Forms.ComboBox();
            this.verLibros = new System.Windows.Forms.Button();
            this.dato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modificar Porcentaje de Descuento ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 417);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 28);
            this.button7.TabIndex = 20;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(267, 343);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(148, 20);
            this.textStock.TabIndex = 34;
            this.textStock.TextChanged += new System.EventHandler(this.textDinero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nuevo descuento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ISBN del libro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboISBNLibro
            // 
            this.cboISBNLibro.FormattingEnabled = true;
            this.cboISBNLibro.Location = new System.Drawing.Point(267, 292);
            this.cboISBNLibro.Name = "cboISBNLibro";
            this.cboISBNLibro.Size = new System.Drawing.Size(148, 21);
            this.cboISBNLibro.TabIndex = 30;
            this.cboISBNLibro.SelectedIndexChanged += new System.EventHandler(this.cboRutCliente_SelectedIndexChanged);
            // 
            // verLibros
            // 
            this.verLibros.Location = new System.Drawing.Point(517, 250);
            this.verLibros.Name = "verLibros";
            this.verLibros.Size = new System.Drawing.Size(135, 23);
            this.verLibros.TabIndex = 36;
            this.verLibros.Text = "Mostrar Libros";
            this.verLibros.UseVisualStyleBackColor = true;
            this.verLibros.Click += new System.EventHandler(this.verDireccion_Click);
            // 
            // dato
            // 
            this.dato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dato.Location = new System.Drawing.Point(46, 94);
            this.dato.Name = "dato";
            this.dato.Size = new System.Drawing.Size(606, 150);
            this.dato.TabIndex = 35;
            // 
            // ModificarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 456);
            this.Controls.Add(this.verLibros);
            this.Controls.Add(this.dato);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboISBNLibro);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarDescuento";
            this.Text = "ModificarDescuento";
            this.Load += new System.EventHandler(this.ModificarDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboISBNLibro;
        private System.Windows.Forms.Button verLibros;
        private System.Windows.Forms.DataGridView dato;
    }
}