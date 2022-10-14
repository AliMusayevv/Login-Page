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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        bool move ;
        int mouse_x;
            int mouse_y;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x=e.X;
            mouse_y=e.Y;    
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;   
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move) {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
                     }
        }

        
        char? none = null;
       

        

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        
           public string username = "ali";
           public string password = "admin123";
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBoxUsername.Text == DefaultAcc.username && textBoxPassword.Text == DefaultAcc.password)
                {

                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();




                }


                else if ((textBoxUsername.Text == "Username" && textBoxPassword.Text == "Password"))
                {
                    MessageBox.Show("Enter username and Password", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (textBoxUsername.Text == DefaultAcc.username && textBoxPassword.Text != DefaultAcc.password)
                {

                    MessageBox.Show("Password is incorrect!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (textBoxUsername.Text != DefaultAcc.username && textBoxPassword.Text == DefaultAcc.password)
                {

                    MessageBox.Show("Username is incorrect!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



                else

                {
                    MessageBox.Show("Entered information is incorrect!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("We apologize for the inconvenience!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void linkLabelFogPas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")

            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Silver;
                
                textBoxPassword.PasswordChar = Convert.ToChar(none);
                //textBoxPassword.PasswordChar = '*';
            }


        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
                textBoxPassword.Text = "";
              textBoxPassword.ForeColor = Color.Black;
              textBoxPassword.PasswordChar='*';
            

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {


                if (checkBoxShowPassword.Checked)
                {
                    textBoxPassword.PasswordChar = '\0';
                }
                else
                {
                    textBoxPassword.PasswordChar = '*';
                }
            }
            catch
            {
                MessageBox.Show("We apologize for the inconvenience!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

