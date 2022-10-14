namespace Login_Page
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabelFogPas = new System.Windows.Forms.LinkLabel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Tomato;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(804, 498);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(243, 71);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblSignUp
            // 
            this.linkLblSignUp.AutoSize = true;
            this.linkLblSignUp.BackColor = System.Drawing.Color.White;
            this.linkLblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblSignUp.LinkColor = System.Drawing.Color.Black;
            this.linkLblSignUp.Location = new System.Drawing.Point(859, 585);
            this.linkLblSignUp.Name = "linkLblSignUp";
            this.linkLblSignUp.Size = new System.Drawing.Size(133, 38);
            this.linkLblSignUp.TabIndex = 8;
            this.linkLblSignUp.TabStop = true;
            this.linkLblSignUp.Text = "Sign Up";
            this.linkLblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSignUp_LinkClicked);
            // 
            // linkLabelFogPas
            // 
            this.linkLabelFogPas.AutoSize = true;
            this.linkLabelFogPas.BackColor = System.Drawing.Color.White;
            this.linkLabelFogPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFogPas.ForeColor = System.Drawing.Color.Red;
            this.linkLabelFogPas.LinkColor = System.Drawing.Color.Black;
            this.linkLabelFogPas.Location = new System.Drawing.Point(968, 433);
            this.linkLabelFogPas.Name = "linkLabelFogPas";
            this.linkLabelFogPas.Size = new System.Drawing.Size(172, 20);
            this.linkLabelFogPas.TabIndex = 9;
            this.linkLabelFogPas.TabStop = true;
            this.linkLabelFogPas.Text = "I Forget My Password";
            this.linkLabelFogPas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFogPas_LinkClicked);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsername.Location = new System.Drawing.Point(721, 272);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(400, 50);
            this.textBoxUsername.TabIndex = 10;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPassword.Location = new System.Drawing.Point(721, 364);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(400, 50);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Login_Page.Properties.Resources.x;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1100, 41);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(721, 429);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(151, 24);
            this.checkBoxShowPassword.TabIndex = 14;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = false;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 661);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.linkLabelFogPas);
            this.Controls.Add(this.linkLblSignUp);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLblSignUp;
        private System.Windows.Forms.LinkLabel linkLabelFogPas;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}

