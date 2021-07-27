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
    public partial class Update_Player_Form : Form
    {
        static bool flag = false;
        public Update_Player_Form()
        {
            InitializeComponent();
        }

        private void Update_Player_Form_Load(object sender, EventArgs e)
        {
            this.player_data.Text = Player_Menu.Mgr.displayAllPlayers();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Only_CNIC_CheckedChanged(object sender, EventArgs e)
        {
            if(Only_CNIC.Checked == true)
            {
                Old_CNIC.Visible = true;
                Old_CNIC_tbox.Visible = true;
                New_CNIC.Visible = true;
                New_CNIC_tbox.Visible = true;
                New_Name.Visible = false;
                New_Name_tbox.Visible = false;

               

            }         
        }

        private void Only_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (Only_Name.Checked == true)
            {
                Old_CNIC.Visible = false;
                Old_CNIC_tbox.Visible = false;
                New_CNIC.Text = "CNIC";
                New_CNIC.Visible = true;
                New_CNIC_tbox.Visible = true;
                New_Name.Visible = true;
                New_Name_tbox.Visible = true;
                
            }
        }

        private void Both_CheckedChanged(object sender, EventArgs e)
        {
            Old_CNIC.Visible = true;
            Old_CNIC_tbox.Visible = true;
            New_CNIC.Text = "New CNIC";
            New_CNIC.Visible = true;
            New_CNIC_tbox.Visible = true;
            New_Name.Visible = true;
            New_Name_tbox.Visible = true;
        }

        private void Old_CNIC_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_CNIC_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void choice_label_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Player edit_player = new Player();
            if (Only_CNIC.Checked == true)
            {
                New_Name_tbox.Text = "";
                if (New_CNIC_tbox.Text != "" && Old_CNIC_tbox.Text != ""
                    && New_Name_tbox.Text == "")
                {
                    bool existing_flag = Player_Menu.Mgr.Check_CNIC(Old_CNIC_tbox.Text);
                    bool no_repetition_flag= Player_Menu.Mgr.Check_CNIC(New_CNIC_tbox.Text);
                    if(existing_flag==true && no_repetition_flag==false)
                    {
                        edit_player = Player_Menu.Mgr.updatePlayer(New_CNIC_tbox.Text, Old_CNIC_tbox.Text);
                        MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        player_data.Text = edit_player.getData();
                        Updated_Player.Text = "Player Information";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Only_Name.Checked == true)
            {
                Old_CNIC_tbox.Text = "";
                if (Old_CNIC_tbox.Text == "" && New_CNIC_tbox.Text != ""
                    && New_Name_tbox.Text != "")
                {
                    bool no_repetition_flag = Player_Menu.Mgr.Check_CNIC(New_CNIC_tbox.Text);
                    if(no_repetition_flag==true)
                    {
                        edit_player = Player_Menu.Mgr.updatePlayername(New_CNIC_tbox.Text, New_Name_tbox.Text);
                        MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        player_data.Text = edit_player.getData();
                        Updated_Player.Text = "Player Information";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(Both.Checked==true)
            {
                if (New_CNIC_tbox.Text != "" && Old_CNIC_tbox.Text != ""
                    && New_Name_tbox.Text != "")
                {
                    bool existing_flag = Player_Menu.Mgr.Check_CNIC(Old_CNIC_tbox.Text);
                    bool no_repetition_flag = Player_Menu.Mgr.Check_CNIC(New_CNIC_tbox.Text);
                    if (existing_flag == true && no_repetition_flag == false)
                    {
                    edit_player = Player_Menu.Mgr.updatePlayer(New_CNIC_tbox.Text, New_Name_tbox.Text, Old_CNIC_tbox.Text);
                    MessageBox.Show("Player Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        player_data.Text = edit_player.getData();
                        Updated_Player.Text = "Player Information";

                    }
                    else
                    {
                        MessageBox.Show("Wrong Input", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void Update_Player_Form_FormClosing(object sender, FormClosingEventArgs e)
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
