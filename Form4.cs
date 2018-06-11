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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=grocerystoredb;Integrated Security=True");
     private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select *from customer where cphone = '" + textBox1.Text + "' ", cn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {





        }
    }
}