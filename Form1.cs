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

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Employés.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee_Table VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1 + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert Data Successfully");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee_Table SET Nom_employé='" + textBox2.Text + "',Adresse='" + textBox3.Text + "',Salaire='" + textBox4.Text + "'WHERE id_Employé='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Successfuly");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" DELETE Employee_Table WHERE id_Employé='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data successfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
