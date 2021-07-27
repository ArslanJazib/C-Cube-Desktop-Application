namespace Journal
{
    partial class Display_All_Games
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
            this.GameData = new System.Windows.Forms.RichTextBox();
            this.options = new System.Windows.Forms.ComboBox();
            this.choice = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.Player_label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.playerid_tbox = new System.Windows.Forms.TextBox();
            this.gameid_tbox = new System.Windows.Forms.TextBox();
            this.GameHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.choice.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameData
            // 
            this.GameData.Location = new System.Drawing.Point(578, 12);
            this.GameData.Name = "GameData";
            this.GameData.Size = new System.Drawing.Size(336, 594);
            this.GameData.TabIndex = 0;
            this.GameData.Text = "";
            this.GameData.TextChanged += new System.EventHandler(this.GameData_TextChanged);
            // 
            // options
            // 
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "Game ID",
            "Player ID"});
            this.options.Location = new System.Drawing.Point(12, 157);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(121, 28);
            this.options.TabIndex = 1;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // choice
            // 
            this.choice.Controls.Add(this.search_button);
            this.choice.Controls.Add(this.Player_label);
            this.choice.Controls.Add(this.ID_Label);
            this.choice.Controls.Add(this.playerid_tbox);
            this.choice.Controls.Add(this.gameid_tbox);
            this.choice.Location = new System.Drawing.Point(12, 248);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(251, 275);
            this.choice.TabIndex = 2;
            this.choice.TabStop = false;
            this.choice.Text = "Options";
            this.choice.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(61, 220);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(115, 34);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Player_label
            // 
            this.Player_label.AutoSize = true;
            this.Player_label.Location = new System.Drawing.Point(25, 155);
            this.Player_label.Name = "Player_label";
            this.Player_label.Size = new System.Drawing.Size(73, 20);
            this.Player_label.TabIndex = 3;
            this.Player_label.Text = "Player ID";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(24, 70);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(74, 20);
            this.ID_Label.TabIndex = 2;
            this.ID_Label.Text = "Game ID";
            // 
            // playerid_tbox
            // 
            this.playerid_tbox.Location = new System.Drawing.Point(104, 152);
            this.playerid_tbox.Name = "playerid_tbox";
            this.playerid_tbox.Size = new System.Drawing.Size(100, 26);
            this.playerid_tbox.TabIndex = 1;
            // 
            // gameid_tbox
            // 
            this.gameid_tbox.Location = new System.Drawing.Point(104, 67);
            this.gameid_tbox.Name = "gameid_tbox";
            this.gameid_tbox.Size = new System.Drawing.Size(100, 26);
            this.gameid_tbox.TabIndex = 0;
            // 
            // GameHome
            // 
            this.GameHome.Location = new System.Drawing.Point(93, 12);
            this.GameHome.Name = "GameHome";
            this.GameHome.Size = new System.Drawing.Size(109, 41);
            this.GameHome.TabIndex = 24;
            this.GameHome.Text = "Game Menu";
            this.GameHome.UseVisualStyleBackColor = true;
            this.GameHome.Click += new System.EventHandler(this.GameHome_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 23;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Display_All_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 618);
            this.Controls.Add(this.GameHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.choice);
            this.Controls.Add(this.options);
            this.Controls.Add(this.GameData);
            this.Name = "Display_All_Games";
            this.Text = "Display_All_Games";
            this.Load += new System.EventHandler(this.Display_All_Games_Load);
            this.choice.ResumeLayout(false);
            this.choice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox GameData;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.GroupBox choice;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label Player_label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox playerid_tbox;
        private System.Windows.Forms.TextBox gameid_tbox;
        private System.Windows.Forms.Button GameHome;
        private System.Windows.Forms.Button Home;
    }
}