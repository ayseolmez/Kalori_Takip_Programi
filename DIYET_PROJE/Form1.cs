﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYET_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form2 frm2;

        private void btnGirisYapForm1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(); 
            frm2.Show();
            this.Hide();

        }
    }
}
