﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MySql.Data.MySqlClient;

namespace Taller2
{
    public partial class LibrosCategoriacs : Form
    {
        public LibrosCategoriacs()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro2 f = new Libro2();
            this.Hide();
            f.Show();
        }

        
        private void LibrosCategoriacs_Load(object sender, EventArgs e)
        {

        }
    }
}
