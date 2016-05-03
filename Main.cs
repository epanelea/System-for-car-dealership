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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Admin1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void Customer1_Click(object sender, EventArgs e)
        {
            new Selling().Show();
            this.Hide();
        }
    }
}
