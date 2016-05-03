using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            new Search().Show();
            this.Hide();
        }
    }
}
