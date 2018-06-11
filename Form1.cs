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
    public partial class Login_Prompt : Form
    {
        public Login_Prompt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void PASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_empid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textbox_password.Focus();
        }

        private void textbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btn_login.PerformClick();
                
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_empid.Text))
            {
                MessageBox.Show("Please enter your employeeID","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
               return;

            }
            try
            {
                using (dbEntities store = new dbEntities())
                {
                    var query = from o in store.employees
                                where o.empID == textbox_empid.Text && o.password == textbox_password.Text
                                select o;
                    if(query.SingleOrDefault() != null)
                    {
                        //MessageBox.Show("you have been successfully logged in..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your credential's are wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    

        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            }

        private void EMPLOYEE_ID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_empid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
