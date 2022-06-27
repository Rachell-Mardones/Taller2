
namespace Taller2
{
    partial class CambiarSalario
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
            this.label3 = new System.Windows.Forms.Label();
            this.salarioactual = new System.Windows.Forms.TextBox();
            this.BotonBuscarEmpleado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saldonuevo = new System.Windows.Forms.TextBox();
            this.ActualizarSaldo = new System.Windows.Forms.Button();
            this.cboRut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cambiar Salario ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(9, 328);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 28);
            this.button7.TabIndex = 23;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingresar Rut del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Salario Actual";
            // 
            // salarioactual
            // 
            this.salarioactual.Location = new System.Drawing.Point(264, 158);
            this.salarioactual.Name = "salarioactual";
            this.salarioactual.Size = new System.Drawing.Size(100, 20);
            this.salarioactual.TabIndex = 27;
            // 
            // BotonBuscarEmpleado
            // 
            this.BotonBuscarEmpleado.Location = new System.Drawing.Point(415, 108);
            this.BotonBuscarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscarEmpleado.Name = "BotonBuscarEmpleado";
            this.BotonBuscarEmpleado.Size = new System.Drawing.Size(64, 26);
            this.BotonBuscarEmpleado.TabIndex = 28;
            this.BotonBuscarEmpleado.Text = "Buscar";
            this.BotonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BotonBuscarEmpleado.Click += new System.EventHandler(this.BotonBuscarEmpleado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Salario Nuevo";
            // 
            // saldonuevo
            // 
            this.saldonuevo.Location = new System.Drawing.Point(264, 205);
            this.saldonuevo.Name = "saldonuevo";
            this.saldonuevo.Size = new System.Drawing.Size(100, 20);
            this.saldonuevo.TabIndex = 30;
            // 
            // ActualizarSaldo
            // 
            this.ActualizarSaldo.Location = new System.Drawing.Point(415, 205);
            this.ActualizarSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarSaldo.Name = "ActualizarSaldo";
            this.ActualizarSaldo.Size = new System.Drawing.Size(64, 26);
            this.ActualizarSaldo.TabIndex = 31;
            this.ActualizarSaldo.Text = "Actualizar";
            this.ActualizarSaldo.UseVisualStyleBackColor = true;
            this.ActualizarSaldo.Click += new System.EventHandler(this.ActualizarSaldo_Click);
            // 
            // cboRut
            // 
            this.cboRut.FormattingEnabled = true;
            this.cboRut.Location = new System.Drawing.Point(264, 113);
            this.cboRut.Name = "cboRut";
            this.cboRut.Size = new System.Drawing.Size(100, 21);
            this.cboRut.TabIndex = 32;
            // 
            // CambiarSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cboRut);
            this.Controls.Add(this.ActualizarSaldo);
            this.Controls.Add(this.saldonuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotonBuscarEmpleado);
            this.Controls.Add(this.salarioactual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CambiarSalario";
            this.Text = "CambiarSalario";
            this.Load += new System.EventHandler(this.CambiarSalario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salarioactual;
        private System.Windows.Forms.Button BotonBuscarEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saldonuevo;
        private System.Windows.Forms.Button ActualizarSaldo;
        private System.Windows.Forms.ComboBox cboRut;
    }
}