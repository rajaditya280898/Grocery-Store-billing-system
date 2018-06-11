using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=grocerystoredb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("Insert into customer values('" + textBox1.Text+"', '" + textBox2.Text+"','" + textBox3.Text+"');",con);
            object o = sc.ExecuteNonQuery();
            MessageBox.Show("Database is successfully updated !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fa = new Form2();
            fa.Show();
            this.Hide();
        }
    }
}
