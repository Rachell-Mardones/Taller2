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
    public partial class AgregarDineroCliente : Form
    {
        public AgregarDineroCliente()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesCliente f = new ModificacionesCliente();
            this.Hide();
            f.Show();
        }
    }
}
