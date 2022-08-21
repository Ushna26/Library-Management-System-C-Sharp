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
    public partial class Publishers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Publishers()
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
        private void Publishers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTable("select * from Publisher;");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Publisher(Publisher_id,Publisher_Name,Publisher_Address)" +
               " VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" +  textBox3.Text + "'); ";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Publisher Information Saved Successfully");
            dataGridView1.DataSource = GetTable("select * from Publisher;");
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string query = ("Update Student set Publisher_Name='" + textBox2.Text + "' ,Publisher_Address = '" + textBox3.Text + "'where Publisher_id = " + textBox1.Text + "");
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Publisher Information updated Successfully");
            dataGridView1.DataSource = GetTable("select * from Publisher;");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Delete_Publisher dp = new Delete_Publisher();
            dp.ShowDialog();
            this.Close();
        }
    }
}
