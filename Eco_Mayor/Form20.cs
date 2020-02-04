using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eco_Mayor
{
    public partial class Form20 : Form
    {
        static string ConnectionString = @"Data Source=LAPTOP-I9URQIMV\SQLEXPRESS;Initial Catalog=Eco-Mayor;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);
        SqlCommand com;
        SqlDataReader reader;

        string CommandText = "Select * from registration";
        static DataSet ds = new DataSet();
        static DataTable dt = new DataTable();
        static SqlDataAdapter dataAdapter;
        BindingSource bs;

        public Form20()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "registration");
            dataGridView1.DataSource = ds.Tables["registration"].DefaultView;

            bs = new BindingSource();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Close();
        }
    }
}
