namespace Journal
{
    partial class Update_Player_Form
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
            this.Old_CNIC = new System.Windows.Forms.Label();
            this.New_CNIC = new System.Windows.Forms.Label();
            this.New_Name = new System.Windows.Forms.Label();
            this.Only_CNIC = new System.Windows.Forms.RadioButton();
            this.Only_Name = new System.Windows.Forms.RadioButton();
            this.Both = new System.Windows.Forms.RadioButton();
            this.choice_label = new System.Windows.Forms.Label();
            this.Old_CNIC_tbox = new System.Windows.Forms.TextBox();
            this.New_CNIC_tbox = new System.Windows.Forms.TextBox();
            this.New_Name_tbox = new System.Windows.Forms.TextBox();
            this.player_data = new System.Windows.Forms.RichTextBox();
            this.Updated_Player = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.PlayerHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Old_CNIC
            // 
            this.Old_CNIC.AutoSize = true;
            this.Old_CNIC.Location = new System.Drawing.Point(113, 178);
            this.Old_CNIC.Name = "Old_CNIC";
            this.Old_CNIC.Size = new System.Drawing.Size(75, 20);
            this.Old_CNIC.TabIndex = 0;
            this.Old_CNIC.Text = "Old CNIC";
            // 
            // New_CNIC
            // 
            this.New_CNIC.AutoSize = true;
            this.New_CNIC.Location = new System.Drawing.Point(336, 178);
            this.New_CNIC.Name = "New_CNIC";
            this.New_CNIC.Size = new System.Drawing.Size(82, 20);
            this.New_CNIC.TabIndex = 1;
            this.New_CNIC.Text = "New CNIC";
            // 
            // New_Name
            // 
            this.New_Name.AutoSize = true;
            this.New_Name.Location = new System.Drawing.Point(559, 178);
            this.New_Name.Name = "New_Name";
            this.New_Name.Size = new System.Drawing.Size(86, 20);
            this.New_Name.TabIndex = 2;
            this.New_Name.Text = "New Name";
            // 
            // Only_CNIC
            // 
            this.Only_CNIC.AutoSize = true;
            this.Only_CNIC.Location = new System.Drawing.Point(206, 96);
            this.Only_CNIC.Name = "Only_CNIC";
            this.Only_CNIC.Size = new System.Drawing.Size(72, 24);
            this.Only_CNIC.TabIndex = 3;
            this.Only_CNIC.TabStop = true;
            this.Only_CNIC.Text = "CNIC";
            this.Only_CNIC.UseVisualStyleBackColor = true;
            this.Only_CNIC.CheckedChanged += new System.EventHandler(this.Only_CNIC_CheckedChanged);
            // 
            // Only_Name
            // 
            this.Only_Name.AutoSize = true;
            this.Only_Name.Location = new System.Drawing.Point(400, 96);
            this.Only_Name.Name = "Only_Name";
            this.Only_Name.Size = new System.Drawing.Size(76, 24);
            this.Only_Name.TabIndex = 4;
            this.Only_Name.TabStop = true;
            this.Only_Name.Text = "Name";
            this.Only_Name.UseVisualStyleBackColor = true;
            this.Only_Name.CheckedChanged += new System.EventHandler(this.Only_Name_CheckedChanged);
            // 
            // Both
            // 
            this.Both.AutoSize = true;
            this.Both.Location = new System.Drawing.Point(590, 96);
            this.Both.Name = "Both";
            this.Both.Size = new System.Drawing.Size(68, 24);
            this.Both.TabIndex = 5;
            this.Both.TabStop = true;
            this.Both.Text = "Both";
            this.Both.UseVisualStyleBackColor = true;
            this.Both.CheckedChanged += new System.EventHandler(this.Both_CheckedChanged);
            // 
            // choice_label
            // 
            this.choice_label.AutoSize = true;
            this.choice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_label.Location = new System.Drawing.Point(256, 9);
            this.choice_label.Name = "choice_label";
            this.choice_label.Size = new System.Drawing.Size(335, 40);
            this.choice_label.TabIndex = 6;
            this.choice_label.Text = "Choose To Update";
            this.choice_label.Click += new System.EventHandler(this.choice_label_Click);
            // 
            // Old_CNIC_tbox
            // 
            this.Old_CNIC_tbox.Location = new System.Drawing.Point(200, 175);
            this.Old_CNIC_tbox.Name = "Old_CNIC_tbox";
            this.Old_CNIC_tbox.Size = new System.Drawing.Size(100, 26);
            this.Old_CNIC_tbox.TabIndex = 7;
            this.Old_CNIC_tbox.TextChanged += new System.EventHandler(this.Old_CNIC_tbox_TextChanged);
            // 
            // New_CNIC_tbox
            // 
            this.New_CNIC_tbox.Location = new System.Drawing.Point(423, 175);
            this.New_CNIC_tbox.Name = "New_CNIC_tbox";
            this.New_CNIC_tbox.Size = new System.Drawing.Size(100, 26);
            this.New_CNIC_tbox.TabIndex = 8;
            this.New_CNIC_tbox.TextChanged += new System.EventHandler(this.New_CNIC_tbox_TextChanged);
            // 
            // New_Name_tbox
            // 
            this.New_Name_tbox.Location = new System.Drawing.Point(646, 175);
            this.New_Name_tbox.Name = "New_Name_tbox";
            this.New_Name_tbox.Size = new System.Drawing.Size(100, 26);
            this.New_Name_tbox.TabIndex = 9;
            // 
            // player_data
            // 
            this.player_data.Location = new System.Drawing.Point(12, 363);
            this.player_data.Name = "player_data";
            this.player_data.Size = new System.Drawing.Size(855, 203);
            this.player_data.TabIndex = 10;
            this.player_data.Text = "";
            this.player_data.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Updated_Player
            // 
            this.Updated_Player.AutoSize = true;
            this.Updated_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updated_Player.Location = new System.Drawing.Point(328, 340);
            this.Updated_Player.Name = "Updated_Player";
            this.Updated_Player.Size = new System.Drawing.Size(193, 20);
            this.Updated_Player.TabIndex = 11;
            this.Updated_Player.Text = "All Player\'s Information";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(336, 273);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(183, 49);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // PlayerHome
            // 
            this.PlayerHome.Location = new System.Drawing.Point(93, 8);
            this.PlayerHome.Name = "PlayerHome";
            this.PlayerHome.Size = new System.Drawing.Size(111, 41);
            this.PlayerHome.TabIndex = 14;
            this.PlayerHome.Text = "Player Menu";
            this.PlayerHome.UseVisualStyleBackColor = true;
            this.PlayerHome.Click += new System.EventHandler(this.PlayerHome_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 8);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Update_Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 578);
            this.Controls.Add(this.PlayerHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Updated_Player);
            this.Controls.Add(this.player_data);
            this.Controls.Add(this.New_Name_tbox);
            this.Controls.Add(this.New_CNIC_tbox);
            this.Controls.Add(this.Old_CNIC_tbox);
            this.Controls.Add(this.choice_label);
            this.Controls.Add(this.Both);
            this.Controls.Add(this.Only_Name);
            this.Controls.Add(this.Only_CNIC);
            this.Controls.Add(this.New_Name);
            this.Controls.Add(this.New_CNIC);
            this.Controls.Add(this.Old_CNIC);
            this.Name = "Update_Player_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Player_Form_FormClosing);
            this.Load += new System.EventHandler(this.Update_Player_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Old_CNIC;
        private System.Windows.Forms.Label New_CNIC;
        private System.Windows.Forms.Label New_Name;
        private System.Windows.Forms.RadioButton Only_CNIC;
        private System.Windows.Forms.RadioButton Only_Name;
        private System.Windows.Forms.RadioButton Both;
        private System.Windows.Forms.Label choice_label;
        private System.Windows.Forms.TextBox Old_CNIC_tbox;
        private System.Windows.Forms.TextBox New_CNIC_tbox;
        private System.Windows.Forms.TextBox New_Name_tbox;
        private System.Windows.Forms.RichTextBox player_data;
        private System.Windows.Forms.Label Updated_Player;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button PlayerHome;
        private System.Windows.Forms.Button Home;
    }
}