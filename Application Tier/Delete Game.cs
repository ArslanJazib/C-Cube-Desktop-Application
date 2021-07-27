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
    public partial class Delete_Game : Form
    {
        List<Game> indexes = new List<Game>();

        public Delete_Game()
        {
            InitializeComponent();
        }

        private void Delete_GameID_CheckedChanged(object sender, EventArgs e)
        {
            if (Delete_GameID.Checked == true)
            {
                DeleteGame_label.Visible = true;
                DeleteGame_tbox.Visible = true;
                DeletePlayer_label.Visible = false;
                DeletePlayer_tbox.Visible = false;
            }
            if (Delete_PlayerID.Checked == true)
            {
                DeletePlayer_label.Visible = true;
                DeletePlayer_tbox.Visible = true;
                DeleteGame_label.Visible = false;
                DeleteGame_tbox.Visible = false;
            }
        }

        private void DeleteGame_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Delete_GameID.Checked == true)
            {
                bool status = Game_Menu.Mgr.DeleteGame(int.Parse(DeleteGame_tbox.Text));
                if (status == true)
                {
                    MessageBox.Show("Game Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Game does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                GameData.Text = Game_Menu.Mgr.displayAllPlayers();
            }
            else if (Delete_PlayerID.Checked == true)
            {

                int status = Game_Menu.Mgr.DeleteGameByPlayer(DeletePlayer_tbox.Text, this.indexes);
                if (status == -1)
                {
                    MessageBox.Show("Game does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GameData.Text = Game_Menu.Mgr.displayAllgames();

                }
                else if (status == 1)
                {
                    MessageBox.Show("Game Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GameData.Text = Game_Menu.Mgr.displayAllgames();

                }
                else if (status == 2)
                {
                    this.GameData.Text = "";
                    for (int index = 0; index < indexes.Count; index++)
                    {
                        this.GameData.Text += indexes[index].getData();
                    }
                    MessageBox.Show("Choose the game id from the list in the delete by Game ID option", "Next Step", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    indexes = new List<Game>();

                }
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Search_options.Visible = true;
            Game searched_game = new Game();
            if (SearchGame.Checked == true)
            {
                if (SearchGametbox.Text != "")
                {
                    searched_game = Game_Menu.Mgr.getGamebyID(int.Parse(SearchGametbox.Text));
                    if (searched_game.GameID != 0)
                    {
                        GameData.Text = searched_game.getData();
                    }
                    else
                    {
                        MessageBox.Show("Game does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (SearchPlayer.Checked == true)
            {

                SearchGametbox.Text = "";
                if (SearchGametbox.Text == "" && SearchPlayer_tbox.Text != "")
                {
                    this.GameData.Text = "";
                    List<Game> result = Game_Menu.Mgr.getGamebyPlayerID(SearchPlayer_tbox.Text);
                    foreach (Game result_game in result)
                    {
                        this.GameData.Text += result_game.getData();
                    }
                }
            }
        }

        private void SearchGame_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchGame.Checked == true)
            {
                SearchGame_label.Visible = true;
                SearchGametbox.Visible = true;
                SearchPlayer_label.Visible = false;
                SearchPlayer_tbox.Visible = false;
            }
        }

        private void SearchPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchPlayer.Checked == true)
            {
                SearchGame_label.Visible = false;
                SearchGametbox.Visible = false;
                SearchPlayer_label.Visible = true;
                SearchPlayer_tbox.Visible = true;
            }
        }

        private void Delete_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game_Menu.Mgr.exit();
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
