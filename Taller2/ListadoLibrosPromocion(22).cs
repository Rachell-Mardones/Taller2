﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class ListadoLibrosPromocion_22_ : Form
    {
        public ListadoLibrosPromocion_22_()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro2 f = new Libro2();
            this.Hide();
            f.Show();
        }
    }
}
