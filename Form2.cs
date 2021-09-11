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
namespace LOGINpage
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Employés.mdf;Integrated Security=True;Connect Timeout=30");

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployésEntities context = new EmployésEntities();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                var user = context.AdminLogins.Where(a => a.username.Equals(textBox1.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(textBox2.Text))
                    {

                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("password incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("username incorrect ");
                }
            }
            else
            {
                MessageBox.Show("username and password required");
            }
        }
    }
}
