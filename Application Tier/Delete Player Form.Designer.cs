namespace Journal
{
    partial class Delete_Player_Form
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
            this.Delete_CNIC = new System.Windows.Forms.RadioButton();
            this.Delete_Name = new System.Windows.Forms.RadioButton();
            this.PlayerData = new System.Windows.Forms.RichTextBox();
            this.DeleteCNIC_tbox = new System.Windows.Forms.TextBox();
            this.DeleteCNIC_label = new System.Windows.Forms.Label();
            this.DeleteName_label = new System.Windows.Forms.Label();
            this.DeleteName_tbox = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search_options = new System.Windows.Forms.GroupBox();
            this.SearchName_label = new System.Windows.Forms.Label();
            this.SearchCNIC_label = new System.Windows.Forms.Label();
            this.SearchName_tbox = new System.Windows.Forms.TextBox();
            this.SearchCNIC_tbox = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.RadioButton();
            this.SearchCNIC = new System.Windows.Forms.RadioButton();
            this.PlayerHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Search_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete_CNIC
            // 
            this.Delete_CNIC.AutoSize = true;
            this.Delete_CNIC.Location = new System.Drawing.Point(24, 106);
            this.Delete_CNIC.Name = "Delete_CNIC";
            this.Delete_CNIC.Size = new System.Drawing.Size(145, 24);
            this.Delete_CNIC.TabIndex = 0;
            this.Delete_CNIC.TabStop = true;
            this.Delete_CNIC.Text = "Delete By CNIC";
            this.Delete_CNIC.UseVisualStyleBackColor = true;
            this.Delete_CNIC.CheckedChanged += new System.EventHandler(this.Delete_CNIC_CheckedChanged);
            // 
            // Delete_Name
            // 
            this.Delete_Name.AutoSize = true;
            this.Delete_Name.Location = new System.Drawing.Point(24, 235);
            this.Delete_Name.Name = "Delete_Name";
            this.Delete_Name.Size = new System.Drawing.Size(149, 24);
            this.Delete_Name.TabIndex = 1;
            this.Delete_Name.TabStop = true;
            this.Delete_Name.Text = "Delete By Name";
            this.Delete_Name.UseVisualStyleBackColor = true;
            // 
            // PlayerData
            // 
            this.PlayerData.Location = new System.Drawing.Point(554, 12);
            this.PlayerData.Name = "PlayerData";
            this.PlayerData.ReadOnly = true;
            this.PlayerData.Size = new System.Drawing.Size(349, 521);
            this.PlayerData.TabIndex = 2;
            this.PlayerData.Text = "";
            // 
            // DeleteCNIC_tbox
            // 
            this.DeleteCNIC_tbox.Location = new System.Drawing.Point(98, 165);
            this.DeleteCNIC_tbox.Name = "DeleteCNIC_tbox";
            this.DeleteCNIC_tbox.Size = new System.Drawing.Size(145, 26);
            this.DeleteCNIC_tbox.TabIndex = 3;
            this.DeleteCNIC_tbox.Visible = false;
            this.DeleteCNIC_tbox.TextChanged += new System.EventHandler(this.DeleteCNIC_tbox_TextChanged);
            // 
            // DeleteCNIC_label
            // 
            this.DeleteCNIC_label.AutoSize = true;
            this.DeleteCNIC_label.Location = new System.Drawing.Point(20, 171);
            this.DeleteCNIC_label.Name = "DeleteCNIC_label";
            this.DeleteCNIC_label.Size = new System.Drawing.Size(47, 20);
            this.DeleteCNIC_label.TabIndex = 4;
            this.DeleteCNIC_label.Text = "CNIC";
            this.DeleteCNIC_label.Visible = false;
            // 
            // DeleteName_label
            // 
            this.DeleteName_label.AutoSize = true;
            this.DeleteName_label.Location = new System.Drawing.Point(24, 322);
            this.DeleteName_label.Name = "DeleteName_label";
            this.DeleteName_label.Size = new System.Drawing.Size(51, 20);
            this.DeleteName_label.TabIndex = 5;
            this.DeleteName_label.Text = "Name";
            this.DeleteName_label.Visible = false;
            // 
            // DeleteName_tbox
            // 
            this.DeleteName_tbox.Location = new System.Drawing.Point(98, 322);
            this.DeleteName_tbox.Name = "DeleteName_tbox";
            this.DeleteName_tbox.Size = new System.Drawing.Size(145, 26);
            this.DeleteName_tbox.TabIndex = 6;
            this.DeleteName_tbox.Visible = false;
            this.DeleteName_tbox.TextChanged += new System.EventHandler(this.DeleteName_tbox_TextChanged);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(28, 432);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(215, 46);
            this.Delete_Button.TabIndex = 7;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(473, 12);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 85);
            this.Search_button.TabIndex = 8;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Search_options
            // 
            this.Search_options.Controls.Add(this.SearchName_label);
            this.Search_options.Controls.Add(this.SearchCNIC_label);
            this.Search_options.Controls.Add(this.SearchName_tbox);
            this.Search_options.Controls.Add(this.SearchCNIC_tbox);
            this.Search_options.Controls.Add(this.SearchName);
            this.Search_options.Controls.Add(this.SearchCNIC);
            this.Search_options.Location = new System.Drawing.Point(314, 120);
            this.Search_options.Name = "Search_options";
            this.Search_options.Size = new System.Drawing.Size(234, 223);
            this.Search_options.TabIndex = 9;
            this.Search_options.TabStop = false;
            this.Search_options.Text = "Search Options";
            this.Search_options.Visible = false;
            // 
            // SearchName_label
            // 
            this.SearchName_label.AutoSize = true;
            this.SearchName_label.Location = new System.Drawing.Point(30, 182);
            this.SearchName_label.Name = "SearchName_label";
            this.SearchName_label.Size = new System.Drawing.Size(51, 20);
            this.SearchName_label.TabIndex = 5;
            this.SearchName_label.Text = "Name";
            this.SearchName_label.Visible = false;
            // 
            // SearchCNIC_label
            // 
            this.SearchCNIC_label.AutoSize = true;
            this.SearchCNIC_label.Location = new System.Drawing.Point(30, 93);
            this.SearchCNIC_label.Name = "SearchCNIC_label";
            this.SearchCNIC_label.Size = new System.Drawing.Size(47, 20);
            this.SearchCNIC_label.TabIndex = 4;
            this.SearchCNIC_label.Text = "CNIC";
            this.SearchCNIC_label.Visible = false;
            // 
            // SearchName_tbox
            // 
            this.SearchName_tbox.Location = new System.Drawing.Point(92, 176);
            this.SearchName_tbox.Name = "SearchName_tbox";
            this.SearchName_tbox.Size = new System.Drawing.Size(100, 26);
            this.SearchName_tbox.TabIndex = 3;
            this.SearchName_tbox.Visible = false;
            this.SearchName_tbox.TextChanged += new System.EventHandler(this.SearchName_tbox_TextChanged);
            // 
            // SearchCNIC_tbox
            // 
            this.SearchCNIC_tbox.Location = new System.Drawing.Point(92, 87);
            this.SearchCNIC_tbox.Name = "SearchCNIC_tbox";
            this.SearchCNIC_tbox.Size = new System.Drawing.Size(100, 26);
            this.SearchCNIC_tbox.TabIndex = 2;
            this.SearchCNIC_tbox.Visible = false;
            // 
            // SearchName
            // 
            this.SearchName.AutoSize = true;
            this.SearchName.Location = new System.Drawing.Point(34, 129);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(153, 24);
            this.SearchName.TabIndex = 1;
            this.SearchName.TabStop = true;
            this.SearchName.Text = "Search By Name";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.CheckedChanged += new System.EventHandler(this.SearchName_CheckedChanged);
            // 
            // SearchCNIC
            // 
            this.SearchCNIC.AutoSize = true;
            this.SearchCNIC.Location = new System.Drawing.Point(34, 46);
            this.SearchCNIC.Name = "SearchCNIC";
            this.SearchCNIC.Size = new System.Drawing.Size(149, 24);
            this.SearchCNIC.TabIndex = 0;
            this.SearchCNIC.TabStop = true;
            this.SearchCNIC.Text = "Search By CNIC";
            this.SearchCNIC.UseVisualStyleBackColor = true;
            this.SearchCNIC.CheckedChanged += new System.EventHandler(this.SearchCNIC_CheckedChanged);
            // 
            // PlayerHome
            // 
            this.PlayerHome.Location = new System.Drawing.Point(93, 12);
            this.PlayerHome.Name = "PlayerHome";
            this.PlayerHome.Size = new System.Drawing.Size(115, 41);
            this.PlayerHome.TabIndex = 18;
            this.PlayerHome.Text = "Player Menu";
            this.PlayerHome.UseVisualStyleBackColor = true;
            this.PlayerHome.Click += new System.EventHandler(this.PlayerHome_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 17;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete_Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 545);
            this.Controls.Add(this.PlayerHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Search_options);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.DeleteName_tbox);
            this.Controls.Add(this.DeleteName_label);
            this.Controls.Add(this.DeleteCNIC_label);
            this.Controls.Add(this.DeleteCNIC_tbox);
            this.Controls.Add(this.PlayerData);
            this.Controls.Add(this.Delete_Name);
            this.Controls.Add(this.Delete_CNIC);
            this.Name = "Delete_Player_Form";
            this.Text = "Delete_Player_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Player_Form_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Player_Form_Load);
            this.Search_options.ResumeLayout(false);
            this.Search_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Delete_CNIC;
        private System.Windows.Forms.RadioButton Delete_Name;
        private System.Windows.Forms.RichTextBox PlayerData;
        private System.Windows.Forms.TextBox DeleteCNIC_tbox;
        private System.Windows.Forms.Label DeleteCNIC_label;
        private System.Windows.Forms.Label DeleteName_label;
        private System.Windows.Forms.TextBox DeleteName_tbox;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.GroupBox Search_options;
        private System.Windows.Forms.Label SearchName_label;
        private System.Windows.Forms.Label SearchCNIC_label;
        private System.Windows.Forms.TextBox SearchName_tbox;
        private System.Windows.Forms.TextBox SearchCNIC_tbox;
        private System.Windows.Forms.RadioButton SearchName;
        private System.Windows.Forms.RadioButton SearchCNIC;
        private System.Windows.Forms.Button PlayerHome;
        private System.Windows.Forms.Button Home;
    }
}