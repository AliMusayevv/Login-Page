using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Login_Page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        
        char? none = null;




        private void Form2_Load(object sender, EventArgs e)
        {

            this.ActiveControl = label1;

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;

            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Silver;
            }

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {

            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "Password")
                textBoxPassword.Text = "";
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.PasswordChar = '*';
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Silver;
                textBoxPassword.PasswordChar = Convert.ToChar(none);
                    }
            else {
                 textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxRepassword_Enter(object sender, EventArgs e)
        {
            if (textBoxRepassword.Text == "RePassword")
                textBoxRepassword.Text = "";
            textBoxRepassword.ForeColor = Color.Black;
            textBoxRepassword.PasswordChar = '*';
        }

        private void textBoxRepassword_Leave(object sender, EventArgs e)
        {
            if (textBoxRepassword.Text == "")
            {
                textBoxRepassword.Text = "RePassword";
                textBoxRepassword.ForeColor = Color.Silver;
                textBoxRepassword.PasswordChar = Convert.ToChar(none);
            }
            else
            {


                textBoxRepassword.PasswordChar = '*';
            }
        }
       
        private void buttonSignUp_Click(object sender, EventArgs e)
        {

            
            try
            {
                





                if (textBoxUsername.Text == "Username" || textBoxEmail.Text == "Email" || textBoxPassword.Text == "Password" || textBoxRepassword.Text == "RePassword")
                {

                    MessageBox.Show("Enter all your details!", " Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxPassword.Text != textBoxRepassword.Text)
                {
                    MessageBox.Show("Password and Repassword are not same!", " Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                else
                {
                    DefaultAcc.username = textBoxUsername.Text;
                    DefaultAcc.password = textBoxPassword.Text;

                    MessageBox.Show("Registration is complete", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
            }


            catch
                {
                MessageBox.Show("We apologize for the inconvenience!", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
   

