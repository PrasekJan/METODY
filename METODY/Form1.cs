﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METODY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CifLichSoucet(int a)
        {
            int soucet = 0;
            while (a > 0)
            {
                if ((a % 10) % 2 != 0) soucet += a % 10;
                a /= 10;
            }
            return soucet;
        }
        bool prvocislo(int a)
        {
            if (a <= 1) return false;
            if (a == 2) return true;
            for (int i = 3; i < a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int a = Convert.ToInt32(textBox1.Text);
                label1.Text = CifLichSoucet(a).ToString();

            int b = Convert.ToInt32(textBox1.Text);
            label2.Text = prvocislo(b).ToString();

        }
    }
}
