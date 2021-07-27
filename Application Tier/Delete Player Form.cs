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
    public partial class Delete_Player_Form : Form
    {
        List<Player> indexes = new List<Player>();

        public Delete_Player_Form()
        {
            InitializeComponent();
        }

        private void Delete_Player_Form_Load(object sender, EventArgs e)
        {

        }

        private void Delete_CNIC_CheckedChanged(object sender, EventArgs e)
        {
            if(Delete_CNIC.Checked==true)
            {
                DeleteCNIC_label.Visible = true;
                DeleteCNIC_tbox.Visible = true;
                DeleteName_label.Visible = false;
                DeleteName_tbox.Visible = false;
            }
            if(Delete_Name.Checked == true)
            {
                DeleteName_label.Visible = true;
                DeleteName_tbox.Visible = true;
                DeleteCNIC_label.Visible = false;
                DeleteCNIC_tbox.Visible = false;
            }
        }

        private void DeleteCNIC_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Delete_CNIC.Checked==true)
            {
                bool status=Player_Menu.Mgr.DeletePlayer(DeleteCNIC_tbox.Text);
                if(status==true)
                {
                    MessageBox.Show("Player Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Player does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                PlayerData.Text=Player_Menu.Mgr.displayAllPlayers();
            }
            else if(Delete_Name.Checked==true)
            {

                int status = Player_Menu.Mgr.DeletePlayerByName(DeleteName_tbox.Text,this.indexes);
                if(status==-1)
                {
                    MessageBox.Show("Player does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PlayerData.Text = Player_Menu.Mgr.displayAllPlayers();

                }
                else if(status ==1)
                {
                    MessageBox.Show("Player Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PlayerData.Text = Player_Menu.Mgr.displayAllPlayers();

                }
                else if(status==2)
                {
                    this.PlayerData.Text = "";
                    for (int index=0;index<indexes.Count;index++)
                    {
                        this.PlayerData.Text += indexes[index].getData();
                    }
                    MessageBox.Show("Choose the CNIC from the list in the delete by CNIC option", "Next Step", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    indexes = new List<Player>();

                }
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Search_options.Visible = true;
            Player searched_player = new Player();
            if(SearchCNIC.Checked==true)
            {
                if (SearchCNIC_tbox.Text != "")
                {
                    searched_player = Player_Menu.Mgr.searchPlayerInfoByCNIC(SearchCNIC_tbox.Text);
                    if (searched_player.Cnic != "Unknown")
                    {
                        PlayerData.Text = searched_player.getData();
                    }
                    else
                    {
                        MessageBox.Show("Player does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (SearchName.Checked == true)
            {

                SearchCNIC_tbox.Text = "";
                if (SearchCNIC_tbox.Text == "" && SearchName_tbox.Text != "")
                {
                    this.PlayerData.Text = "";
                    List<Player> result = Player_Menu.Mgr.searchPlayerInfoByName(SearchName_tbox.Text);
                    foreach (Player result_player in result)
                    {
                        this.PlayerData.Text += result_player.getData();
                    }
                }
            }
        }

        private void DeleteName_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchName_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchCNIC_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchCNIC.Checked == true)
            {
                SearchCNIC_label.Visible = true;
                SearchCNIC_tbox.Visible = true;
                SearchName_label.Visible = false;
                SearchName_tbox.Visible = false;
            }
        }

        private void SearchName_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchName.Checked == true)
            {
                SearchName_label.Visible = true;
                SearchName_tbox.Visible = true;
                SearchCNIC_label.Visible = false;
                SearchCNIC_tbox.Visible = false;
            }
        }

        private void Delete_Player_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Player_Menu.Mgr.exit();
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }

        private void PlayerHome_Click(object sender, EventArgs e)
        {
            Player_Menu PlayerHome = new Player_Menu();
            this.Hide();
            PlayerHome.Show();
        }
    }
}
