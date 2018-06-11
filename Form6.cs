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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=grocerystoredb;Integrated Security=True");

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select productname from product", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "product";
            comboBox1.ValueMember = "productname";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select productcode, mrp, mfd, expiry from product where productname= '"+ comboBox1.SelectedValue+"'", cn);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                dataGridView2.Columns.Add(c.Clone() as DataGridViewColumn);
            }

            //then you can copy the rows values one by one (working on the selectedrows collection)
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int index = dataGridView2.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    dataGridView2.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            textBox1.Show();




        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
            textBox2.ForeColor = Color.Blue;

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
            textBox2.ForeColor = Color.Blue;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
            textBox2.ForeColor = Color.Blue;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();

            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();

            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();

            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();

            count = 4;
            label1.Text = num.ToString() + "%";
        }

        private void button_calcu_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lenght = textBox2.TextLength - 1;
            string text = textBox2.Text;
            textBox2.Clear();
            for (int i = 0; i < lenght; i++)
                textBox2.Text = textBox2.Text + text[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
            textBox2.ForeColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));
            doc.Open();
            PdfPTable pt = new PdfPTable(dataGridView2.Columns.Count);
            for(int j =0; j < dataGridView2.Columns.Count;j++)
            {
                pt.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));

            }
            pt.HeaderRows = 1;
            for(int i =0; i< dataGridView2.Rows.Count;i++)
            {
                for(int k= 0; k<dataGridView2.Columns.Count;k++)
                {
                    if(dataGridView2[k,i].Value != null)
                    {
                        pt.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(pt);
            Paragraph pr = new Paragraph(textBox1.Text);
            doc.Close();
        }

        public void compute()
        {
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

    }
}
