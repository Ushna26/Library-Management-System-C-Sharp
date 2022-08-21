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
    public partial class Deletebooks : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Deletebooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Enter the Book ISBN Code");
            else
            {
                Con.Open();
                string q = "delete from Books where ISBN_Code = " + int.Parse(comboBox1.Text) + "";
                SqlCommand cmd = new SqlCommand(q, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Record deleted successfully");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.ShowDialog();
            this.Hide();
        }

        private void Deletebooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
