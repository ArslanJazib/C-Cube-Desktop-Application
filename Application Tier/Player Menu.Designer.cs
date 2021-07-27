namespace Journal
{
    partial class Player_Menu
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
            this.Registration = new System.Windows.Forms.Button();
            this.Update_Player = new System.Windows.Forms.Button();
            this.Searching_Player = new System.Windows.Forms.Button();
            this.Delete_Player = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Welcom_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(214, 152);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(161, 56);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Register New Player";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Player
            // 
            this.Update_Player.Location = new System.Drawing.Point(479, 152);
            this.Update_Player.Name = "Update_Player";
            this.Update_Player.Size = new System.Drawing.Size(161, 56);
            this.Update_Player.TabIndex = 1;
            this.Update_Player.Text = "Update Player";
            this.Update_Player.UseVisualStyleBackColor = true;
            this.Update_Player.Click += new System.EventHandler(this.Update_Player_Click);
            // 
            // Searching_Player
            // 
            this.Searching_Player.Location = new System.Drawing.Point(214, 286);
            this.Searching_Player.Name = "Searching_Player";
            this.Searching_Player.Size = new System.Drawing.Size(161, 56);
            this.Searching_Player.TabIndex = 3;
            this.Searching_Player.Text = "Search/Display Players";
            this.Searching_Player.UseVisualStyleBackColor = true;
            this.Searching_Player.Click += new System.EventHandler(this.Searching_Player_Click);
            // 
            // Delete_Player
            // 
            this.Delete_Player.Location = new System.Drawing.Point(479, 286);
            this.Delete_Player.Name = "Delete_Player";
            this.Delete_Player.Size = new System.Drawing.Size(161, 56);
            this.Delete_Player.TabIndex = 2;
            this.Delete_Player.Text = "Delete Player";
            this.Delete_Player.UseVisualStyleBackColor = true;
            this.Delete_Player.Click += new System.EventHandler(this.Delete_Player_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 41);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Welcom_Label
            // 
            this.Welcom_Label.AutoSize = true;
            this.Welcom_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcom_Label.Location = new System.Drawing.Point(228, 12);
            this.Welcom_Label.Name = "Welcom_Label";
            this.Welcom_Label.Size = new System.Drawing.Size(396, 64);
            this.Welcom_Label.TabIndex = 5;
            this.Welcom_Label.Text = "Player Options";
            // 
            // Player_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 538);
            this.Controls.Add(this.Welcom_Label);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Searching_Player);
            this.Controls.Add(this.Delete_Player);
            this.Controls.Add(this.Update_Player);
            this.Controls.Add(this.Registration);
            this.Name = "Player_Menu";
            this.Text = "Player Menu";
            this.Load += new System.EventHandler(this.Player_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Update_Player;
        private System.Windows.Forms.Button Searching_Player;
        private System.Windows.Forms.Button Delete_Player;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Welcom_Label;
    }
}