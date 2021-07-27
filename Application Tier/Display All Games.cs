using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessaLayer;
namespace Journal
{
    public partial class Display_All_Games : Form
    {
        public Display_All_Games()
        {
            InitializeComponent();
        }

        private void Display_All_Games_Load(object sender, EventArgs e)
        {
            GameData.Text = Game_Menu.Mgr.displayAllgames();
            
            choice.Visible = false;
            ID_Label.Visible = false;
            gameid_tbox.Visible = false;
            Player_label.Visible = false;
            playerid_tbox.Visible = false;
        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(options.SelectedIndex==0)
            {
                choice.Visible = true;
                ID_Label.Visible = true;
                gameid_tbox.Visible = true;
                Player_label.Visible = false;
                playerid_tbox.Visible = false;
            }
            else if(options.SelectedIndex == 1)
            {
                choice.Visible = true;
                ID_Label.Visible = false;
                gameid_tbox.Visible = false;
                Player_label.Visible = true;
                playerid_tbox.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (options.SelectedIndex == 0)
            {
                Game searched=Game_Menu.Mgr.getGamebyID(int.Parse(gameid_tbox.Text));
                GameData.Text = searched.getData();
            }
            else if(options.SelectedIndex == 1)
            {
                this.GameData.Text = "";
                List<Game> searched = Game_Menu.Mgr.getGamebyPlayerID(playerid_tbox.Text);
                foreach (Game game in searched )
                {
                    this.GameData.Text += game.getData();
                }
            }
        }

        private void GameData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }

        private void GameHome_Click(object sender, EventArgs e)
        {
            Game_Menu gamehome = new Game_Menu();
            this.Hide();
            gamehome.Show();
        }
    }
}
