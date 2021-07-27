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
    public partial class Search_Display : Form
    {
        public Search_Display()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void All_Players_Load(object sender, EventArgs e)
        {
            this.AllPayer_Screen.Text = Player_Menu.Mgr.displayAllPlayers();
            this.Old_CNIC_label.Visible = false;
            this.Old_CNIC_tbox.Visible = false;
            this.Input_CNIC_label.Visible = false;
            this.Input_CNIC_tbox.Visible = false;
            this.Input_Name_label.Visible = false;
            this.Input_Name_tbox.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Old_CNIC_label.Visible = false;
            this.Old_CNIC_tbox.Visible = false;
            this.Input_CNIC_label.Visible = false;
            this.Input_CNIC_tbox.Visible = false;
            this.Input_Name_label.Visible = false;
            this.Input_Name_tbox.Visible = false;
            this.Options_Box.Visible = true;

            if (this.Options.SelectedIndex == 0)
            {
                this.Input_CNIC_label.Visible = true;
                this.Input_CNIC_tbox.Visible = true;
                if (Choice.Text == "Search")
                {
                    this.Old_CNIC_label.Visible = true;
                    this.Old_CNIC_tbox.Visible = true;
                }

            }
            else if (this.Options.SelectedIndex == 1)
            {
                this.Input_Name_label.Visible = true;
                this.Input_Name_tbox.Visible = true;
                if (Choice.Text == "Search")
                {
                    this.Input_CNIC_label.Text = "CNIC";
                    this.Input_CNIC_label.Visible = true;
                    this.Input_CNIC_tbox.Visible = true;
                }
            }

            else if (this.Options.SelectedIndex == 2)
            {
                this.Input_CNIC_label.Visible = true;
                this.Input_CNIC_tbox.Visible = true;
                this.Input_Name_label.Visible = true;
                this.Input_Name_tbox.Visible = true;
                if (Choice.Text == "Search")
                {
                    this.Input_CNIC_label.Text = "New CNIC";
                    this.Old_CNIC_label.Visible = true;
                    this.Old_CNIC_tbox.Visible = true;
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void O_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Options_Box_Enter(object sender, EventArgs e)
        {

        }

        private void Choice_CheckedChanged(object sender, EventArgs e)
        {
            

            if (Choice.Text == "Edit")
            {
                
                Choice.Text = "Search";
                Search_btn.Text = "Edit";
                if(Options.SelectedIndex==0)
                {
                    this.Input_CNIC_label.Text = "New CNIC";
                    this.Old_CNIC_tbox.Visible = true;
                    this.Old_CNIC_label.Visible = true;
                }
                else if (Options.SelectedIndex == 1)
                {
                    this.Input_Name_label.Text = "New Name";
                    this.Input_CNIC_label.Visible = true;
                    this.Input_CNIC_tbox.Visible = true;
                }
                if (Options.SelectedIndex == 2)
                {
                    this.Input_Name_label.Text = "New Name";
                    this.Input_CNIC_label.Text = "New CNIC";
                    this.Old_CNIC_tbox.Visible = true;
                    this.Old_CNIC_label.Visible = true;
                }
            }
            else if (Choice.Text == "Search")
            {

                this.Input_CNIC_label.Text = "CNIC";
                this.Input_Name_label.Text = "Name";
                Choice.Text = "Edit";
                Search_btn.Text = "Search";
                if (Options.SelectedIndex == 0 || Options.SelectedIndex == 2)
                {
                    this.Old_CNIC_tbox.Visible = false;
                    this.Old_CNIC_label.Visible = false;
                }
                else if (Options.SelectedIndex == 1)
                {
                    this.Input_CNIC_label.Visible = false;
                    this.Input_CNIC_tbox.Visible = false;
                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            if (Search_btn.Text == "Search")
            {
                Player searched_player = new Player();
                if(Input_CNIC_tbox.Text != "")
                {
                    searched_player = Player_Menu.Mgr.searchPlayerInfoByCNIC(Input_CNIC_tbox.Text);
                    if (searched_player.Cnic != "Unknown")
                    {
                        AllPayer_Screen.Text = searched_player.getData();
                    }
                    else
                    {
                        MessageBox.Show("Player does not exist", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if(Input_CNIC_tbox.Text == "" && Input_Name_tbox.Text!="")
                {
                    this.AllPayer_Screen.Text = "";
                    List<Player> result = Player_Menu.Mgr.searchPlayerInfoByName(Input_Name_tbox.Text);
                    foreach (Player result_player  in result)
                    {
                        this.AllPayer_Screen.Text +=result_player.getData();
                    }
                }

            }
            if (Search_btn.Text == "Edit")
            {
                Player edit_player = new Player();
                if (Input_CNIC_tbox.Text != "" && Old_CNIC_tbox.Text != ""
                    && Input_Name_tbox.Text != "")
                {
                    bool existing_flag = Player_Menu.Mgr.Check_CNIC(Old_CNIC_tbox.Text);
                    bool no_repetition_flag = Player_Menu.Mgr.Check_CNIC(Input_CNIC_tbox.Text);
                    if (existing_flag == true && no_repetition_flag == false)
                    {
                        edit_player = Player_Menu.Mgr.updatePlayer(Input_CNIC_tbox.Text, Input_Name_tbox.Text, Old_CNIC_tbox.Text);
                        MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllPayer_Screen.Text = edit_player.getData();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if(Input_CNIC_tbox.Text!="" && Old_CNIC_tbox.Text != ""
                    && Input_Name_tbox.Text == "")
                {
                    bool existing_flag = Player_Menu.Mgr.Check_CNIC(Old_CNIC_tbox.Text);
                    bool no_repetition_flag = Player_Menu.Mgr.Check_CNIC(Input_CNIC_tbox.Text);
                    if (existing_flag == true && no_repetition_flag == false)
                    {
                        edit_player = Player_Menu.Mgr.updatePlayer(Input_CNIC_tbox.Text, Old_CNIC_tbox.Text);
                        MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllPayer_Screen.Text = edit_player.getData();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (Old_CNIC_tbox.Text == "" && Input_CNIC_tbox.Text!= ""
                    && Input_Name_tbox.Text != "")
                {
                    bool existing_flag = Player_Menu.Mgr.Check_CNIC(Old_CNIC_tbox.Text);
                    if (existing_flag == true)
                    {
                        edit_player = Player_Menu.Mgr.updatePlayername(Input_CNIC_tbox.Text, Input_Name_tbox.Text);
                        MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllPayer_Screen.Text = edit_player.getData();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void Old_Name_Click(object sender, EventArgs e)
        {

        }

        private void Old_CNIC_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_CNIC_Click(object sender, EventArgs e)
        {

        }

        private void Search_Display_FormClosing(object sender, FormClosingEventArgs e)
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
