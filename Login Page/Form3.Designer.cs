namespace Login_Page
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonResetLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Your Password?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 92);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not to worry!Give us your email,and we\'ll email you a password reset link.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxEmail.Location = new System.Drawing.Point(95, 308);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(826, 60);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Text = "Enter your mail adress";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.Click += new System.EventHandler(this.textBoxEmail_Click);
            // 
            // buttonResetLink
            // 
            this.buttonResetLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.buttonResetLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonResetLink.FlatAppearance.BorderSize = 4;
            this.buttonResetLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResetLink.Location = new System.Drawing.Point(312, 400);
            this.buttonResetLink.Name = "buttonResetLink";
            this.buttonResetLink.Size = new System.Drawing.Size(387, 111);
            this.buttonResetLink.TabIndex = 6;
            this.buttonResetLink.Text = "Send reset link";
            this.buttonResetLink.UseVisualStyleBackColor = false;
            this.buttonResetLink.Click += new System.EventHandler(this.buttonResetLink_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(905, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(953, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(52, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(908, 23);
            this.label5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(928, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 43);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(55, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(893, 24);
            this.label6.TabIndex = 20;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonResetLink);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAVE YOUR EMAIL";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonResetLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}