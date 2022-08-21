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
    public partial class AddBooks : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public AddBooks()
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
      
        private void AddBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter1.Fill(this.libraryDataSet1.Publisher);
            dataGridView1.DataSource = GetTable("select * from Books;");
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO Books(ISBN_Code,Book_title,Author,Language,Category_Name,Publisher_id,Publication_year)" +
                " VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + int.Parse(comboBox1.Text) + "','" + int.Parse(comboBox4.Text) + "'); ";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Book Information Saved Successfully");
            dataGridView1.DataSource = GetTable("select * from Books;");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            string query = ("Update Student set Book_title = '" + textBox2.Text + "',Author='" + textBox3.Text + "',Language='" + comboBox2.SelectedItem.ToString() + "',Category_Name='" + comboBox3.SelectedItem.ToString() + "',Publisher_id='" + int.Parse(comboBox1.Text) + "',Publication_year='" + int.Parse(comboBox4.Text) + "'where ISBN_Code = " + textBox1.Text + "");
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Book Information Updated Successfully");
            dataGridView1.DataSource = GetTable("select * from Books;");
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books book = new Books();
            book.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
