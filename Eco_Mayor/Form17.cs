using System;
using System.Windows.Forms;

namespace Eco_Mayor
{
    public partial class Form17 : Form
    {
        public int point = 0;

        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 10;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 0;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) - 5;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            point = Convert.ToInt32(label3.Text) + 5;
            label3.Text = Convert.ToString(point);
            button5.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(label3.Text);

            if (total >= 70 )
            {
                Form18 f18 = new Form18();
                f18.Show();
                Close();
            }
            else
            {
                Form19 f19 = new Form19();
                f19.Show();
                Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();
        }
    }
}
