namespace Journal
{
    partial class Game_Menu
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
            this.SetGame_btn = new System.Windows.Forms.Button();
            this.DisplayTable = new System.Windows.Forms.Button();
            this.DisplayGame = new System.Windows.Forms.Button();
            this.DeleteGame = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Welcom_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetGame_btn
            // 
            this.SetGame_btn.Location = new System.Drawing.Point(174, 162);
            this.SetGame_btn.Name = "SetGame_btn";
            this.SetGame_btn.Size = new System.Drawing.Size(187, 67);
            this.SetGame_btn.TabIndex = 0;
            this.SetGame_btn.Text = "Set Game";
            this.SetGame_btn.UseVisualStyleBackColor = true;
            this.SetGame_btn.Click += new System.EventHandler(this.SetGame_btn_Click);
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(489, 162);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(187, 67);
            this.DisplayTable.TabIndex = 1;
            this.DisplayTable.Text = "Show All Table Status";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // DisplayGame
            // 
            this.DisplayGame.Location = new System.Drawing.Point(174, 298);
            this.DisplayGame.Name = "DisplayGame";
            this.DisplayGame.Size = new System.Drawing.Size(187, 67);
            this.DisplayGame.TabIndex = 2;
            this.DisplayGame.Text = "Dislay All Games";
            this.DisplayGame.UseVisualStyleBackColor = true;
            this.DisplayGame.Click += new System.EventHandler(this.DisplayGame_Click);
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(489, 298);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(187, 67);
            this.DeleteGame.TabIndex = 3;
            this.DeleteGame.Text = "Delete Game";
            this.DeleteGame.UseVisualStyleBackColor = true;
            this.DeleteGame.Click += new System.EventHandler(this.DeleteGame_Click);
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
            // Welcom_Label
            // 
            this.Welcom_Label.AutoSize = true;
            this.Welcom_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcom_Label.Location = new System.Drawing.Point(242, 12);
            this.Welcom_Label.Name = "Welcom_Label";
            this.Welcom_Label.Size = new System.Drawing.Size(390, 64);
            this.Welcom_Label.TabIndex = 6;
            this.Welcom_Label.Text = "Game Options";
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 577);
            this.Controls.Add(this.Welcom_Label);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.DisplayGame);
            this.Controls.Add(this.DisplayTable);
            this.Controls.Add(this.SetGame_btn);
            this.Name = "Game_Menu";
            this.Text = "Game_Menu";
            this.Load += new System.EventHandler(this.Game_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetGame_btn;
        private System.Windows.Forms.Button DisplayTable;
        private System.Windows.Forms.Button DisplayGame;
        private System.Windows.Forms.Button DeleteGame;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Welcom_Label;
    }
}