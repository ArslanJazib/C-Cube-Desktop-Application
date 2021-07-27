namespace Journal
{
    partial class Search_Display
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
            this.AllPayer_Screen = new System.Windows.Forms.RichTextBox();
            this.Input_CNIC_label = new System.Windows.Forms.Label();
            this.Input_CNIC_tbox = new System.Windows.Forms.TextBox();
            this.Options_Box = new System.Windows.Forms.GroupBox();
            this.Old_CNIC_tbox = new System.Windows.Forms.TextBox();
            this.Old_CNIC_label = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.CheckBox();
            this.Input_Name_tbox = new System.Windows.Forms.TextBox();
            this.Input_Name_label = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.ComboBox();
            this.PlayerHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Options_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPayer_Screen
            // 
            this.AllPayer_Screen.Location = new System.Drawing.Point(398, 12);
            this.AllPayer_Screen.Name = "AllPayer_Screen";
            this.AllPayer_Screen.ReadOnly = true;
            this.AllPayer_Screen.Size = new System.Drawing.Size(418, 629);
            this.AllPayer_Screen.TabIndex = 0;
            this.AllPayer_Screen.Text = "";
            this.AllPayer_Screen.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Input_CNIC_label
            // 
            this.Input_CNIC_label.AutoSize = true;
            this.Input_CNIC_label.Location = new System.Drawing.Point(47, 38);
            this.Input_CNIC_label.Name = "Input_CNIC_label";
            this.Input_CNIC_label.Size = new System.Drawing.Size(47, 20);
            this.Input_CNIC_label.TabIndex = 1;
            this.Input_CNIC_label.Text = "CNIC";
            this.Input_CNIC_label.Click += new System.EventHandler(this.S_CNIC_Click);
            // 
            // Input_CNIC_tbox
            // 
            this.Input_CNIC_tbox.Location = new System.Drawing.Point(149, 38);
            this.Input_CNIC_tbox.Name = "Input_CNIC_tbox";
            this.Input_CNIC_tbox.Size = new System.Drawing.Size(100, 26);
            this.Input_CNIC_tbox.TabIndex = 3;
            this.Input_CNIC_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Options_Box
            // 
            this.Options_Box.Controls.Add(this.Old_CNIC_tbox);
            this.Options_Box.Controls.Add(this.Old_CNIC_label);
            this.Options_Box.Controls.Add(this.Search_btn);
            this.Options_Box.Controls.Add(this.Choice);
            this.Options_Box.Controls.Add(this.Input_CNIC_label);
            this.Options_Box.Controls.Add(this.Input_Name_tbox);
            this.Options_Box.Controls.Add(this.Input_Name_label);
            this.Options_Box.Controls.Add(this.Input_CNIC_tbox);
            this.Options_Box.Location = new System.Drawing.Point(35, 245);
            this.Options_Box.Name = "Options_Box";
            this.Options_Box.Size = new System.Drawing.Size(300, 345);
            this.Options_Box.TabIndex = 5;
            this.Options_Box.TabStop = false;
            this.Options_Box.Text = "Options";
            this.Options_Box.Visible = false;
            this.Options_Box.Enter += new System.EventHandler(this.Options_Box_Enter);
            // 
            // Old_CNIC_tbox
            // 
            this.Old_CNIC_tbox.AcceptsReturn = true;
            this.Old_CNIC_tbox.Location = new System.Drawing.Point(149, 88);
            this.Old_CNIC_tbox.Name = "Old_CNIC_tbox";
            this.Old_CNIC_tbox.Size = new System.Drawing.Size(100, 26);
            this.Old_CNIC_tbox.TabIndex = 8;
            this.Old_CNIC_tbox.TextChanged += new System.EventHandler(this.Old_CNIC_text_TextChanged);
            // 
            // Old_CNIC_label
            // 
            this.Old_CNIC_label.AutoSize = true;
            this.Old_CNIC_label.Location = new System.Drawing.Point(47, 94);
            this.Old_CNIC_label.Name = "Old_CNIC_label";
            this.Old_CNIC_label.Size = new System.Drawing.Size(75, 20);
            this.Old_CNIC_label.TabIndex = 7;
            this.Old_CNIC_label.Text = "Old CNIC";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(51, 261);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 37);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.Location = new System.Drawing.Point(201, 275);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(63, 24);
            this.Choice.TabIndex = 5;
            this.Choice.Text = "Edit";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.CheckedChanged += new System.EventHandler(this.Choice_CheckedChanged);
            // 
            // Input_Name_tbox
            // 
            this.Input_Name_tbox.Location = new System.Drawing.Point(149, 150);
            this.Input_Name_tbox.Name = "Input_Name_tbox";
            this.Input_Name_tbox.Size = new System.Drawing.Size(100, 26);
            this.Input_Name_tbox.TabIndex = 4;
            this.Input_Name_tbox.TextChanged += new System.EventHandler(this.O_Name_TextChanged);
            // 
            // Input_Name_label
            // 
            this.Input_Name_label.AutoSize = true;
            this.Input_Name_label.Location = new System.Drawing.Point(47, 150);
            this.Input_Name_label.Name = "Input_Name_label";
            this.Input_Name_label.Size = new System.Drawing.Size(51, 20);
            this.Input_Name_label.TabIndex = 2;
            this.Input_Name_label.Text = "Name";
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "CNIC",
            "Name",
            "Both"});
            this.Options.Location = new System.Drawing.Point(35, 126);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(121, 28);
            this.Options.TabIndex = 6;
            this.Options.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PlayerHome
            // 
            this.PlayerHome.Location = new System.Drawing.Point(93, 12);
            this.PlayerHome.Name = "PlayerHome";
            this.PlayerHome.Size = new System.Drawing.Size(108, 41);
            this.PlayerHome.TabIndex = 16;
            this.PlayerHome.Text = "Player Menu";
            this.PlayerHome.UseVisualStyleBackColor = true;
            this.PlayerHome.Click += new System.EventHandler(this.PlayerHome_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Search_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 653);
            this.Controls.Add(this.PlayerHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Options_Box);
            this.Controls.Add(this.AllPayer_Screen);
            this.Name = "Search_Display";
            this.Text = "Search and Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Display_FormClosing);
            this.Load += new System.EventHandler(this.All_Players_Load);
            this.Options_Box.ResumeLayout(false);
            this.Options_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AllPayer_Screen;
        private System.Windows.Forms.Label Input_CNIC_label;
        private System.Windows.Forms.TextBox Input_CNIC_tbox;
        private System.Windows.Forms.GroupBox Options_Box;
        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.TextBox Input_Name_tbox;
        private System.Windows.Forms.Label Input_Name_label;
        private System.Windows.Forms.CheckBox Choice;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Old_CNIC_tbox;
        private System.Windows.Forms.Label Old_CNIC_label;
        private System.Windows.Forms.Button PlayerHome;
        private System.Windows.Forms.Button Home;
    }
}