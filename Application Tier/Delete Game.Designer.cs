namespace Journal
{
    partial class Delete_Game
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
            this.Search_options = new System.Windows.Forms.GroupBox();
            this.SearchPlayer_label = new System.Windows.Forms.Label();
            this.SearchGame_label = new System.Windows.Forms.Label();
            this.SearchPlayer_tbox = new System.Windows.Forms.TextBox();
            this.SearchGametbox = new System.Windows.Forms.TextBox();
            this.SearchPlayer = new System.Windows.Forms.RadioButton();
            this.SearchGame = new System.Windows.Forms.RadioButton();
            this.Search_button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.DeletePlayer_tbox = new System.Windows.Forms.TextBox();
            this.DeletePlayer_label = new System.Windows.Forms.Label();
            this.DeleteGame_label = new System.Windows.Forms.Label();
            this.DeleteGame_tbox = new System.Windows.Forms.TextBox();
            this.GameData = new System.Windows.Forms.RichTextBox();
            this.Delete_PlayerID = new System.Windows.Forms.RadioButton();
            this.Delete_GameID = new System.Windows.Forms.RadioButton();
            this.GameHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Search_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_options
            // 
            this.Search_options.Controls.Add(this.SearchPlayer_label);
            this.Search_options.Controls.Add(this.SearchGame_label);
            this.Search_options.Controls.Add(this.SearchPlayer_tbox);
            this.Search_options.Controls.Add(this.SearchGametbox);
            this.Search_options.Controls.Add(this.SearchPlayer);
            this.Search_options.Controls.Add(this.SearchGame);
            this.Search_options.Location = new System.Drawing.Point(289, 109);
            this.Search_options.Name = "Search_options";
            this.Search_options.Size = new System.Drawing.Size(234, 223);
            this.Search_options.TabIndex = 19;
            this.Search_options.TabStop = false;
            this.Search_options.Text = "Search Options";
            this.Search_options.Visible = false;
            // 
            // SearchPlayer_label
            // 
            this.SearchPlayer_label.AutoSize = true;
            this.SearchPlayer_label.Location = new System.Drawing.Point(12, 179);
            this.SearchPlayer_label.Name = "SearchPlayer_label";
            this.SearchPlayer_label.Size = new System.Drawing.Size(73, 20);
            this.SearchPlayer_label.TabIndex = 5;
            this.SearchPlayer_label.Text = "Player ID";
            this.SearchPlayer_label.Visible = false;
            // 
            // SearchGame_label
            // 
            this.SearchGame_label.AutoSize = true;
            this.SearchGame_label.Location = new System.Drawing.Point(12, 90);
            this.SearchGame_label.Name = "SearchGame_label";
            this.SearchGame_label.Size = new System.Drawing.Size(74, 20);
            this.SearchGame_label.TabIndex = 4;
            this.SearchGame_label.Text = "Game ID";
            this.SearchGame_label.Visible = false;
            // 
            // SearchPlayer_tbox
            // 
            this.SearchPlayer_tbox.Location = new System.Drawing.Point(92, 176);
            this.SearchPlayer_tbox.Name = "SearchPlayer_tbox";
            this.SearchPlayer_tbox.Size = new System.Drawing.Size(100, 26);
            this.SearchPlayer_tbox.TabIndex = 3;
            this.SearchPlayer_tbox.Visible = false;
            // 
            // SearchGametbox
            // 
            this.SearchGametbox.Location = new System.Drawing.Point(92, 87);
            this.SearchGametbox.Name = "SearchGametbox";
            this.SearchGametbox.Size = new System.Drawing.Size(100, 26);
            this.SearchGametbox.TabIndex = 2;
            this.SearchGametbox.Visible = false;
            // 
            // SearchPlayer
            // 
            this.SearchPlayer.AutoSize = true;
            this.SearchPlayer.Location = new System.Drawing.Point(34, 129);
            this.SearchPlayer.Name = "SearchPlayer";
            this.SearchPlayer.Size = new System.Drawing.Size(175, 24);
            this.SearchPlayer.TabIndex = 1;
            this.SearchPlayer.TabStop = true;
            this.SearchPlayer.Text = "Search By Player ID";
            this.SearchPlayer.UseVisualStyleBackColor = true;
            this.SearchPlayer.CheckedChanged += new System.EventHandler(this.SearchPlayer_CheckedChanged);
            // 
            // SearchGame
            // 
            this.SearchGame.AutoSize = true;
            this.SearchGame.Location = new System.Drawing.Point(34, 46);
            this.SearchGame.Name = "SearchGame";
            this.SearchGame.Size = new System.Drawing.Size(176, 24);
            this.SearchGame.TabIndex = 0;
            this.SearchGame.TabStop = true;
            this.SearchGame.Text = "Search By Game ID";
            this.SearchGame.UseVisualStyleBackColor = true;
            this.SearchGame.CheckedChanged += new System.EventHandler(this.SearchGame_CheckedChanged);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(448, 1);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 85);
            this.Search_button.TabIndex = 18;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(12, 437);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(215, 46);
            this.Delete_Button.TabIndex = 17;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // DeletePlayer_tbox
            // 
            this.DeletePlayer_tbox.Location = new System.Drawing.Point(96, 333);
            this.DeletePlayer_tbox.Name = "DeletePlayer_tbox";
            this.DeletePlayer_tbox.Size = new System.Drawing.Size(145, 26);
            this.DeletePlayer_tbox.TabIndex = 16;
            this.DeletePlayer_tbox.Visible = false;
            // 
            // DeletePlayer_label
            // 
            this.DeletePlayer_label.AutoSize = true;
            this.DeletePlayer_label.Location = new System.Drawing.Point(17, 333);
            this.DeletePlayer_label.Name = "DeletePlayer_label";
            this.DeletePlayer_label.Size = new System.Drawing.Size(73, 20);
            this.DeletePlayer_label.TabIndex = 15;
            this.DeletePlayer_label.Text = "Player ID";
            this.DeletePlayer_label.Visible = false;
            // 
            // DeleteGame_label
            // 
            this.DeleteGame_label.AutoSize = true;
            this.DeleteGame_label.Location = new System.Drawing.Point(17, 173);
            this.DeleteGame_label.Name = "DeleteGame_label";
            this.DeleteGame_label.Size = new System.Drawing.Size(74, 20);
            this.DeleteGame_label.TabIndex = 14;
            this.DeleteGame_label.Text = "Game ID";
            this.DeleteGame_label.Visible = false;
            // 
            // DeleteGame_tbox
            // 
            this.DeleteGame_tbox.Location = new System.Drawing.Point(97, 170);
            this.DeleteGame_tbox.Name = "DeleteGame_tbox";
            this.DeleteGame_tbox.Size = new System.Drawing.Size(145, 26);
            this.DeleteGame_tbox.TabIndex = 13;
            this.DeleteGame_tbox.Visible = false;
            this.DeleteGame_tbox.TextChanged += new System.EventHandler(this.DeleteGame_tbox_TextChanged);
            // 
            // GameData
            // 
            this.GameData.Location = new System.Drawing.Point(529, 1);
            this.GameData.Name = "GameData";
            this.GameData.ReadOnly = true;
            this.GameData.Size = new System.Drawing.Size(349, 521);
            this.GameData.TabIndex = 12;
            this.GameData.Text = "";
            // 
            // Delete_PlayerID
            // 
            this.Delete_PlayerID.AutoSize = true;
            this.Delete_PlayerID.Location = new System.Drawing.Point(8, 240);
            this.Delete_PlayerID.Name = "Delete_PlayerID";
            this.Delete_PlayerID.Size = new System.Drawing.Size(171, 24);
            this.Delete_PlayerID.TabIndex = 11;
            this.Delete_PlayerID.TabStop = true;
            this.Delete_PlayerID.Text = "Delete By Player ID";
            this.Delete_PlayerID.UseVisualStyleBackColor = true;
            // 
            // Delete_GameID
            // 
            this.Delete_GameID.AutoSize = true;
            this.Delete_GameID.Location = new System.Drawing.Point(8, 111);
            this.Delete_GameID.Name = "Delete_GameID";
            this.Delete_GameID.Size = new System.Drawing.Size(172, 24);
            this.Delete_GameID.TabIndex = 10;
            this.Delete_GameID.TabStop = true;
            this.Delete_GameID.Text = "Delete By Game ID";
            this.Delete_GameID.UseVisualStyleBackColor = true;
            this.Delete_GameID.CheckedChanged += new System.EventHandler(this.Delete_GameID_CheckedChanged);
            // 
            // GameHome
            // 
            this.GameHome.Location = new System.Drawing.Point(89, 12);
            this.GameHome.Name = "GameHome";
            this.GameHome.Size = new System.Drawing.Size(109, 41);
            this.GameHome.TabIndex = 26;
            this.GameHome.Text = "Game Menu";
            this.GameHome.UseVisualStyleBackColor = true;
            this.GameHome.Click += new System.EventHandler(this.GameHome_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(8, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 25;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 523);
            this.Controls.Add(this.GameHome);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Search_options);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.DeletePlayer_tbox);
            this.Controls.Add(this.DeletePlayer_label);
            this.Controls.Add(this.DeleteGame_label);
            this.Controls.Add(this.DeleteGame_tbox);
            this.Controls.Add(this.GameData);
            this.Controls.Add(this.Delete_PlayerID);
            this.Controls.Add(this.Delete_GameID);
            this.Name = "Delete_Game";
            this.Text = "Delete_Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Game_FormClosing);
            this.Search_options.ResumeLayout(false);
            this.Search_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Search_options;
        private System.Windows.Forms.Label SearchPlayer_label;
        private System.Windows.Forms.Label SearchGame_label;
        private System.Windows.Forms.TextBox SearchPlayer_tbox;
        private System.Windows.Forms.TextBox SearchGametbox;
        private System.Windows.Forms.RadioButton SearchPlayer;
        private System.Windows.Forms.RadioButton SearchGame;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox DeletePlayer_tbox;
        private System.Windows.Forms.Label DeletePlayer_label;
        private System.Windows.Forms.Label DeleteGame_label;
        private System.Windows.Forms.TextBox DeleteGame_tbox;
        private System.Windows.Forms.RichTextBox GameData;
        private System.Windows.Forms.RadioButton Delete_PlayerID;
        private System.Windows.Forms.RadioButton Delete_GameID;
        private System.Windows.Forms.Button GameHome;
        private System.Windows.Forms.Button Home;
    }
}