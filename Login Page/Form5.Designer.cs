namespace Login_Page
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.buttonReTry = new System.Windows.Forms.Button();
            this.labelRandom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK.Location = new System.Drawing.Point(455, 349);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(84, 58);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRandom.Location = new System.Drawing.Point(157, 341);
            this.textBoxRandom.Multiline = true;
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(275, 79);
            this.textBoxRandom.TabIndex = 5;
            this.textBoxRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonReTry
            // 
            this.buttonReTry.BackColor = System.Drawing.Color.White;
            this.buttonReTry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReTry.BackgroundImage")));
            this.buttonReTry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReTry.FlatAppearance.BorderSize = 0;
            this.buttonReTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReTry.Location = new System.Drawing.Point(61, 341);
            this.buttonReTry.Name = "buttonReTry";
            this.buttonReTry.Size = new System.Drawing.Size(80, 66);
            this.buttonReTry.TabIndex = 4;
            this.buttonReTry.UseVisualStyleBackColor = false;
            this.buttonReTry.Click += new System.EventHandler(this.buttonReTry_Click);
            // 
            // labelRandom
            // 
            this.labelRandom.BackColor = System.Drawing.Color.White;
            this.labelRandom.Font = new System.Drawing.Font("Chiller", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandom.Location = new System.Drawing.Point(254, 193);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(296, 87);
            this.labelRandom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxRandom);
            this.Controls.Add(this.buttonReTry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Button buttonReTry;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label label1;
    }
}