using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetLink_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBoxEmail.Text.Length == 0)
                {
                    MessageBox.Show("Enter your mail adress", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxEmail.Text == "Enter your mail adress")
                {
                    MessageBox.Show("Enter your mail adress", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("We sended password reset link to your mail.Click link and reset your password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("We apologize for the inconvenience!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxEmail.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label5;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
