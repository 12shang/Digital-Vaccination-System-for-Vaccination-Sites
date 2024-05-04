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
    public partial class registration_screen : Form
    {
        public registration_screen()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Documents\\user_information.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        private void registration_screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 1 | textBox4.Text.Length < 1 | textBox1.Text.Length < 1 | textBox2.Text.Length < 1)
            {
                MessageBox.Show("Please fill out all the fields");
                this.Hide();
                registration_screen form67 = new registration_screen();
                form67.ShowDialog();


            }
            else
            {
                connection.Open();
                
                command = new OleDbCommand("INSERT INTO user_details([username],[password],[fullname],[contactnumber]) values(@username,@password,@fullname,@contactnumber)", connection);
                command.Parameters.AddWithValue("@username", textBox3.Text);
                command.Parameters.AddWithValue("@password", textBox4.Text);
                command.Parameters.AddWithValue("@fullname", textBox1.Text);
                command.Parameters.AddWithValue("@contactnumber", textBox2.Text);
                command.ExecuteNonQuery();



                connection.Close();

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                waiver form7 = new waiver();
                form7.ShowDialog();
            }
           

            

          

          


        }
    }
}
