namespace Login_Page
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRepassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "It\'s free hardly takes more than 30 seconds.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::Login_Page.Properties.Resources._2223;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(128, 575);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 69);
            this.label2.TabIndex = 8;
            this.label2.Text = "Create Account";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsername.Location = new System.Drawing.Point(143, 210);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(473, 41);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxEmail.Location = new System.Drawing.Point(143, 285);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(473, 41);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPassword.Location = new System.Drawing.Point(143, 363);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(473, 42);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxRepassword
            // 
            this.textBoxRepassword.BackColor = System.Drawing.Color.White;
            this.textBoxRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepassword.ForeColor = System.Drawing.Color.Silver;
            this.textBoxRepassword.Location = new System.Drawing.Point(143, 435);
            this.textBoxRepassword.Multiline = true;
            this.textBoxRepassword.Name = "textBoxRepassword";
            this.textBoxRepassword.Size = new System.Drawing.Size(473, 41);
            this.textBoxRepassword.TabIndex = 12;
            this.textBoxRepassword.Text = "RePassword";
            this.textBoxRepassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRepassword.Enter += new System.EventHandler(this.textBoxRepassword_Enter);
            this.textBoxRepassword.Leave += new System.EventHandler(this.textBoxRepassword_Leave);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(102, 496);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(514, 59);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 23);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(27, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(656, 23);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(660, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 621);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(27, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 621);
            this.label6.TabIndex = 17;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(337, 629);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(47, 40);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Page.Properties.Resources.eee1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 713);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxRepassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Your Account";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRepassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBack;
    }
}