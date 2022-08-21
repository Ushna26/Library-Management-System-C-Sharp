using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        private void deletebooks_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Deletebooks db = new Deletebooks();
            db.ShowDialog();
        }

        private void publishers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Publishers pub = new Publishers();
            pub.ShowDialog();
        }

        private void Addbooks_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddBooks ab = new AddBooks();
            ab.ShowDialog();
        }
    }
}
