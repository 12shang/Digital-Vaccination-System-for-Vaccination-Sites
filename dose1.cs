using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bovid
{
    public partial class _1st_dose : Form
    {
        public _1st_dose()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(36);

            label6.Text = today.ToShortDateString();

            label4.Text = answer.ToShortDateString();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Documents\\user_information.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _1st_dose_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from user_details where username='" + textBox1.Text + "'and password='" + textBox2.Text +  "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {


                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update user_details set date1='"+ label6.Text+ "'where username = '"+textBox1.Text+"'and password = '"+textBox2.Text+"'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                string query1 = "update user_details set date2='"+label4.Text+ "'where username = '"+ textBox1.Text+"'and password = '"+ textBox2.Text+ "'";
                command.CommandText = query1;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                MessageBox.Show("update successful");
                connection.Close();


                this.Hide();
                dose form56 = new dose();
                form56.ShowDialog();

            }
            else
            {
                MessageBox.Show("Either Username/Password is incorrect");
            }



            connection.Close();
        }
    }
}
