
namespace Taller2
{
    partial class AgregarEmpleado
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
            this.fecha = new System.Windows.Forms.TextBox();
            this.BotonAgregarEmpleado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.rut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agregar un Nuevo Empleado";
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
            this.label1.Location = new System.Drawing.Point(131, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Rut";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(234, 222);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(122, 20);
            this.fecha.TabIndex = 25;
            // 
            // BotonAgregarEmpleado
            // 
            this.BotonAgregarEmpleado.Location = new System.Drawing.Point(260, 256);
            this.BotonAgregarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.BotonAgregarEmpleado.Name = "BotonAgregarEmpleado";
            this.BotonAgregarEmpleado.Size = new System.Drawing.Size(64, 26);
            this.BotonAgregarEmpleado.TabIndex = 26;
            this.BotonAgregarEmpleado.Text = "Agregar";
            this.BotonAgregarEmpleado.UseVisualStyleBackColor = true;
            this.BotonAgregarEmpleado.Click += new System.EventHandler(this.BotonAgregarEmpleado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha Contratación";
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(234, 178);
            this.salario.Margin = new System.Windows.Forms.Padding(2);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(122, 20);
            this.salario.TabIndex = 30;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(234, 140);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 20);
            this.nombre.TabIndex = 31;
            // 
            // rut
            // 
            this.rut.Location = new System.Drawing.Point(234, 102);
            this.rut.Margin = new System.Windows.Forms.Padding(2);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(122, 20);
            this.rut.TabIndex = 32;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 366);
            this.Controls.Add(this.rut);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonAgregarEmpleado);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Button BotonAgregarEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox rut;
    }
}