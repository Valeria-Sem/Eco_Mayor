using System;
using System.Windows.Forms;

namespace Eco_Mayor
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
