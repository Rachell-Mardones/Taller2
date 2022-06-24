
namespace Taller2
{
    partial class ListadoLibrosPromocion_22_
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
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.verLibros = new System.Windows.Forms.Button();
            this.dato = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoriaLibro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dato)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Listado de Libros por Categoria";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "en Promoción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 344);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 28);
            this.button7.TabIndex = 23;
            this.button7.Text = "Atrás";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // verLibros
            // 
            this.verLibros.Location = new System.Drawing.Point(405, 146);
            this.verLibros.Name = "verLibros";
            this.verLibros.Size = new System.Drawing.Size(59, 21);
            this.verLibros.TabIndex = 38;
            this.verLibros.Text = "Ver libros";
            this.verLibros.UseVisualStyleBackColor = true;
            this.verLibros.Click += new System.EventHandler(this.verLibros_Click);
            // 
            // dato
            // 
            this.dato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dato.Location = new System.Drawing.Point(96, 173);
            this.dato.Name = "dato";
            this.dato.Size = new System.Drawing.Size(523, 166);
            this.dato.TabIndex = 37;
            this.dato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dato_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Categoría del libro";
            // 
            // cboCategoriaLibro
            // 
            this.cboCategoriaLibro.FormattingEnabled = true;
            this.cboCategoriaLibro.Location = new System.Drawing.Point(251, 147);
            this.cboCategoriaLibro.Name = "cboCategoriaLibro";
            this.cboCategoriaLibro.Size = new System.Drawing.Size(148, 21);
            this.cboCategoriaLibro.TabIndex = 39;
            this.cboCategoriaLibro.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaLibro_SelectedIndexChanged);
            // 
            // ListadoLibrosPromocion_22_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategoriaLibro);
            this.Controls.Add(this.verLibros);
            this.Controls.Add(this.dato);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListadoLibrosPromocion_22_";
            this.Text = "ListadoLibrosPromocion_22_";
            this.Load += new System.EventHandler(this.ListadoLibrosPromocion_22__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button verLibros;
        private System.Windows.Forms.DataGridView dato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoriaLibro;
    }
}