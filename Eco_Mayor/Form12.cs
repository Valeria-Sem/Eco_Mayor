﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Mayor
{
    public partial class Form12 : Form
    {
        public int point = 0;

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 0;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 5;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 10;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) - 5;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            f13.label3.Text = label3.Text;
            Close();
        }
    }
}
