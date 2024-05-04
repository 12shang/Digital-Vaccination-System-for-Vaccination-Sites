using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bovid
{
    public partial class dose : Form
    {
        public dose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration_screen form53 = new registration_screen();
            form53.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form67 = new Form1();
            form67.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            last_choice form98 = new last_choice();
            form98.ShowDialog();
        }

        private void dose_Load(object sender, EventArgs e)
        {

        }
    }
}
