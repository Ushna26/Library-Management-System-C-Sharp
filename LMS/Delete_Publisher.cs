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
    public partial class Delete_Publisher : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Delete_Publisher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Enter the Publisher ID:");
            else
            {
                Con.Open();
                string q = "delete from Publisher where Publisher_id = " + int.Parse(comboBox1.Text) + "";
                SqlCommand cmd = new SqlCommand(q, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher Record deleted successfully");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Publishers pub = new Publishers();
            pub.ShowDialog();
            this.Close();
        }

        private void Delete_Publisher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.libraryDataSet1.Publisher);

        }
    }
}
