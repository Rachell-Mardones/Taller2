﻿
namespace Taller2
{
    partial class AgregarCategoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCategoria = new System.Windows.Forms.TextBox();
            this.BotonAgregarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agregar nueva categoria ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 404);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 34);
            this.button7.TabIndex = 20;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.Location = new System.Drawing.Point(275, 165);
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Size = new System.Drawing.Size(241, 22);
            this.NombreCategoria.TabIndex = 22;
            // 
            // BotonAgregarCategoria
            // 
            this.BotonAgregarCategoria.Location = new System.Drawing.Point(347, 257);
            this.BotonAgregarCategoria.Name = "BotonAgregarCategoria";
            this.BotonAgregarCategoria.Size = new System.Drawing.Size(86, 32);
            this.BotonAgregarCategoria.TabIndex = 27;
            this.BotonAgregarCategoria.Text = "Agregar";
            this.BotonAgregarCategoria.UseVisualStyleBackColor = true;
            this.BotonAgregarCategoria.Click += new System.EventHandler(this.BotonAgregarCategoria_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonAgregarCategoria);
            this.Controls.Add(this.NombreCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCategoria;
        private System.Windows.Forms.Button BotonAgregarCategoria;
    }
}