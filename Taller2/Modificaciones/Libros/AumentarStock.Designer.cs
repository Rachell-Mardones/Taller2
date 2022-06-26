
namespace Taller2
{
    partial class AumentarStock
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
            this.verLibros = new System.Windows.Forms.Button();
            this.dato = new System.Windows.Forms.DataGridView();
            this.textStockLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboISBNLibro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aumentar Stock";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(9, 328);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 28);
            this.button7.TabIndex = 20;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // verLibros
            // 
            this.verLibros.Location = new System.Drawing.Point(483, 224);
            this.verLibros.Name = "verLibros";
            this.verLibros.Size = new System.Drawing.Size(135, 23);
            this.verLibros.TabIndex = 43;
            this.verLibros.Text = "Mostrar Libros";
            this.verLibros.UseVisualStyleBackColor = true;
            this.verLibros.Click += new System.EventHandler(this.verLibros_Click);
            // 
            // dato
            // 
            this.dato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dato.Location = new System.Drawing.Point(12, 68);
            this.dato.Name = "dato";
            this.dato.Size = new System.Drawing.Size(606, 150);
            this.dato.TabIndex = 42;
            // 
            // textStockLibro
            // 
            this.textStockLibro.Location = new System.Drawing.Point(233, 317);
            this.textStockLibro.Name = "textStockLibro";
            this.textStockLibro.Size = new System.Drawing.Size(148, 20);
            this.textStockLibro.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nuevo Stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ISBN del libro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboISBNLibro
            // 
            this.cboISBNLibro.FormattingEnabled = true;
            this.cboISBNLibro.Location = new System.Drawing.Point(233, 266);
            this.cboISBNLibro.Name = "cboISBNLibro";
            this.cboISBNLibro.Size = new System.Drawing.Size(148, 21);
            this.cboISBNLibro.TabIndex = 37;
            // 
            // AumentarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.verLibros);
            this.Controls.Add(this.dato);
            this.Controls.Add(this.textStockLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboISBNLibro);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AumentarStock";
            this.Text = "AumentarStock";
            this.Load += new System.EventHandler(this.AumentarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button verLibros;
        private System.Windows.Forms.DataGridView dato;
        private System.Windows.Forms.TextBox textStockLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboISBNLibro;
    }
}