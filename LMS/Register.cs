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
namespace LMS
{
    public partial class Register : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Register()
        {
            InitializeComponent();
        }
        public DataTable GetTable(string query)
        {
            Con.Open();
            SqlDataAdapter data = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmd1 = new SqlCommandBuilder(data);
            var table = new DataTable();
            data.Fill(table);
            Con.Close();
            return table;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTable("select * from Student;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string query = "INSERT INTO Student(Student_Id,Student_Name,Sex,Date_Of_Birth,Department,Course,Semester,contact_Number)" +
                " VALUES('" + textBox3.Text + "','" + textBox1.Text + "','" + gender + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";
           
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Student Information Saved Successfully");
            dataGridView1.DataSource = GetTable("select * from Student;");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string query = ("Update Student set Student_Name='" + textBox1.Text + "' ,Sex = '" + gender + "' ,Date_Of_Birth= '" + DateTime.Parse(dateTimePicker1.Text) + "',Department= '" + comboBox1.SelectedItem.ToString() + "',Course='" + textBox4.Text + "',Semester='" + textBox5.Text + "',contact_Number='" + textBox6.Text + "'where Student_Id = " + textBox3.Text + "");

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Student Information Updated Successfully");
            dataGridView1.DataSource = GetTable("select * from Student;");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dialog dialog = new Dialog();
            dialog.ShowDialog();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
