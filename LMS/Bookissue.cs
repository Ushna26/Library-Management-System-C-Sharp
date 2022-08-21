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
    public partial class Bookissue : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Bookissue()
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
        private void Bookissue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);
            // TODO: This line of code loads data into the 'libraryDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryDataSet1.Student);
            dataGridView1.DataSource = GetTable("select * from Book_Issue;");

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Book_Issue(Issue_Id,Student_Id,ISBN,Issued_Date,Return_Date)" +
                " VALUES('" + textBox1.Text + "','" + int.Parse(comboBox1.Text) + "','" + int.Parse(comboBox2.Text) + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + DateTime.Parse(dateTimePicker2.Text) + "'); ";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Book Issue Successfully");
            dataGridView1.DataSource = GetTable("select * from Book_Issue;");
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            string query = ("Update Student set Student_Id='" + int.Parse(comboBox1.Text) + "',ISBN='" + int.Parse(comboBox2.Text) + "',Issued_Date='" + DateTime.Parse(dateTimePicker1.Text) + "',Return_Date='" + DateTime.Parse(dateTimePicker2.Text) + "'where ISBN_Code = " + textBox1.Text + "");
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Book Issue Information Updated Successfully");
            dataGridView1.DataSource = GetTable("select * from Book_Issue;");
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Books book = new Books();
            book.ShowDialog();
        }
    }
}
