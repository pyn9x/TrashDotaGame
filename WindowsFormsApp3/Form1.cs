﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //где Form2 - название вашей формы
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(); //где Form2 - название вашей формы
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fmr4 = new Form4();
            fmr4.Show();
        }
    }
}
