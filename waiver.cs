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
    public partial class waiver : Form
    {
        public waiver()
        {
            InitializeComponent();
        }

        private void waiver_agree_Click(object sender, EventArgs e)
        {
            this.Hide();
            tests form3 = new tests();
            form3.ShowDialog();

        }

        private void waiver_text_Click(object sender, EventArgs e)
        {

        }

        private void waiver_decline_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
