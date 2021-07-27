namespace Journal
{
    partial class Registration_Form
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
            this.New_CNIC = new System.Windows.Forms.Label();
            this.New_Name = new System.Windows.Forms.Label();
            this.New_CNICbox = new System.Windows.Forms.TextBox();
            this.New_Namebox = new System.Windows.Forms.TextBox();
            this.Reg_New = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.PlayerHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_CNIC
            // 
            this.New_CNIC.AutoSize = true;
            this.New_CNIC.Location = new System.Drawing.Point(223, 134);
            this.New_CNIC.Name = "New_CNIC";
            this.New_CNIC.Size = new System.Drawing.Size(47, 20);
            this.New_CNIC.TabIndex = 0;
            this.New_CNIC.Text = "CNIC";
            // 
            // New_Name
            // 
            this.New_Name.AutoSize = true;
            this.New_Name.Location = new System.Drawing.Point(223, 214);
            this.New_Name.Name = "New_Name";
            this.New_Name.Size = new System.Drawing.Size(51, 20);
            this.New_Name.TabIndex = 1;
            this.New_Name.Text = "Name";
            // 
            // New_CNICbox
            // 
            this.New_CNICbox.Location = new System.Drawing.Point(474, 134);
            this.New_CNICbox.Name = "New_CNICbox";
            this.New_CNICbox.Size = new System.Drawing.Size(100, 26);
            this.New_CNICbox.TabIndex = 2;
            this.New_CNICbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // New_Namebox
            // 
            this.New_Namebox.Location = new System.Drawing.Point(474, 208);
            this.New_Namebox.Name = "New_Namebox";
            this.New_Namebox.Size = new System.Drawing.Size(100, 26);
            this.New_Namebox.TabIndex = 3;
            // 
            // Reg_New
            // 
            this.Reg_New.Location = new System.Drawing.Point(315, 320);
            this.Reg_New.Name = "Reg_New";
            this.Reg_New.Size = new System.Drawing.Size(158, 44);
            this.Reg_New.TabIndex = 4;
            this.Reg_New.Text = "Register";
            this.Reg_New.UseVisualStyleBackColor = true;
            this.Reg_New.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 5;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // PlayerHome
            // 
            this.PlayerHome.Location = new System.Drawing.Point(93, 12);
            this.PlayerHome.Name = "PlayerHome";
            this.PlayerHome.Size = new System.Drawing.Size(109, 41);
            this.PlayerHome.TabIndex = 6;
            this.PlayerHome.Text = "Player Menu";
            this.PlayerHome.UseVisualStyleBackColor = true;
            this.PlayerHome.Click += new System.EventHandler(this.GameHome_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Reg_New);
            this.Controls.Add(this.New_Namebox);
            this.Controls.Add(this.New_CNICbox);
            this.Controls.Add(this.New_Name);
            this.Controls.Add(this.New_CNIC);
            this.Name = "Registration_Form";
            this.Text = "Registration Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_Form_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label New_CNIC;
        private System.Windows.Forms.Label New_Name;
        private System.Windows.Forms.TextBox New_CNICbox;
        private System.Windows.Forms.TextBox New_Namebox;
        private System.Windows.Forms.Button Reg_New;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button PlayerHome;
    }
}