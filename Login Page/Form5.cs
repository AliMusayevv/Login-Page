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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonReTry_Click(object sender, EventArgs e)
        {
            createRandom();
        }

        private void createRandom()
        {
            textBoxRandom.Clear();
            Random random = new Random();
            char a = Convert.ToChar(random.Next(65, 91));
            char b = Convert.ToChar(random.Next(97, 123));
            int c = Convert.ToChar(random.Next(0, 10));
            char d = Convert.ToChar(random.Next(65, 91));
            char w = Convert.ToChar(random.Next(97, 123));
            int f = Convert.ToChar(random.Next(0, 10));

            labelRandom.Text = (a.ToString() + b.ToString() + c.ToString() + d.ToString() + w.ToString() + f.ToString());
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            createRandom();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            try
            {




                if (textBoxRandom.Text == labelRandom.Text)
                {
                    MessageBox.Show("Completed", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }

                else if (textBoxRandom.Text == "")
                {
                    MessageBox.Show("Enter the text above with case sensitivity!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    createRandom();
                    MessageBox.Show("Not Same!Please ReTry!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRandom.Clear();
                }
            }
            catch
            {
                MessageBox.Show("We apologize for the inconvenience!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
