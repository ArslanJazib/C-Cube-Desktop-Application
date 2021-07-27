namespace Journal
{
    partial class Main_Menu
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
            this.Player = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Button();
            this.Welcom_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(270, 261);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(163, 71);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player Options";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Game
            // 
            this.Game.Location = new System.Drawing.Point(560, 261);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(163, 71);
            this.Game.TabIndex = 1;
            this.Game.Text = "Game Options";
            this.Game.UseVisualStyleBackColor = true;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // Welcom_Label
            // 
            this.Welcom_Label.AutoSize = true;
            this.Welcom_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcom_Label.Location = new System.Drawing.Point(259, 27);
            this.Welcom_Label.Name = "Welcom_Label";
            this.Welcom_Label.Size = new System.Drawing.Size(498, 64);
            this.Welcom_Label.TabIndex = 4;
            this.Welcom_Label.Text = "Welcome Manager";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 619);
            this.Controls.Add(this.Welcom_Label);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Player);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.Button Game;
        private System.Windows.Forms.Label Welcom_Label;
    }
}

