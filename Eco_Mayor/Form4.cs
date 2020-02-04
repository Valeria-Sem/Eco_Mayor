using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eco_Mayor
{
    public partial class Form4 : Form
    {
        static string ConnectionString = @"Data Source=LAPTOP-I9URQIMV\SQLEXPRESS;Initial Catalog=Eco-Mayor;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);
        SqlCommand com;
        SqlDataReader reader;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == null ||
                textBox2.Text == "" || textBox3.Text == null || textBox3.Text == "" || textBox4.Text == null || textBox4.Text == ""
                || textBox5.Text == null || textBox5.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                conn.Open();

                com = new SqlCommand("Select count (*) from registration", conn);
                com = new SqlCommand("Select top 1 id from registration order by id desc", conn);

                reader = com.ExecuteReader();

                reader.Read();
                int id = Convert.ToInt32(reader[0]) + 1;
                reader.Close();

                com = new SqlCommand("INSERT INTO registration VALUES (@id, @Name ,@Surname, @Date, @Login ,@Password)", conn);
                com.Parameters.Add("@id", SqlDbType.Int).Value = id;
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBox1.Text;
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = textBox2.Text;
                com.Parameters.Add("@Date", SqlDbType.Date).Value = textBox3.Text;
                com.Parameters.Add("@Login", SqlDbType.NVarChar).Value = textBox4.Text;
                com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBox5.Text;
                com.ExecuteNonQuery();

                conn.Close();
                reader.Close();

                Form1 frm1 = new Form1();
                frm1.Show();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Close();
        }
    }
}
