
namespace Taller2
{
    partial class AgregarCliente
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
            this.Agregar_Cliente = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textRut = new System.Windows.Forms.TextBox();
            this.Rut = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.Saldo = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agregar Nuevo Cliente";
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
            this.button7.TabIndex = 17;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Agregar_Cliente
            // 
            this.Agregar_Cliente.Location = new System.Drawing.Point(179, 287);
            this.Agregar_Cliente.Name = "Agregar_Cliente";
            this.Agregar_Cliente.Size = new System.Drawing.Size(100, 25);
            this.Agregar_Cliente.TabIndex = 18;
            this.Agregar_Cliente.Text = "Agregar";
            this.Agregar_Cliente.UseVisualStyleBackColor = true;
            this.Agregar_Cliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(112, 99);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 19;
            this.Nombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(179, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(189, 20);
            this.textNombre.TabIndex = 20;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(179, 131);
            this.textRut.Name = "textRut";
            this.textRut.Size = new System.Drawing.Size(100, 20);
            this.textRut.TabIndex = 22;
            // 
            // Rut
            // 
            this.Rut.AutoSize = true;
            this.Rut.Location = new System.Drawing.Point(112, 134);
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(24, 13);
            this.Rut.TabIndex = 21;
            this.Rut.Text = "Rut";
            this.Rut.Click += new System.EventHandler(this.label3_Click);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(179, 171);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 24;
            this.textSaldo.TextChanged += new System.EventHandler(this.textSaldo_TextChanged);
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(112, 174);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(34, 13);
            this.Saldo.TabIndex = 23;
            this.Saldo.Text = "Saldo";
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(179, 212);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(100, 20);
            this.textContraseña.TabIndex = 26;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(112, 215);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 25;
            this.Contraseña.Text = "Contraseña";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(179, 251);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(189, 20);
            this.textEmail.TabIndex = 28;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(112, 254);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 27;
            this.Email.Text = "Email";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.textRut);
            this.Controls.Add(this.Rut);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Agregar_Cliente);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Agregar_Cliente;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.Label Rut;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label Email;
    }
}