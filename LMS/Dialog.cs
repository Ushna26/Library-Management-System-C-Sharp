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
    public partial class Dialog : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = localhost;Initial Catalog = Library;Integrated Security = True");
        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Enter the Student ID");
            else
            {
                Con.Open();
                string q = "delete from Student where Student_Id = " + int.Parse(comboBox1.Text) + "";
                SqlCommand cmd = new SqlCommand(q, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Record deleted successfully");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryDataSet1.Student);

        }
    }
}
