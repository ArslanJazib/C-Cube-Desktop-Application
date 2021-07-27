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
    public partial class Set_Game : Form
    {
        static int table;
        static int table1_counter = 0;
        static int table2_counter = 0;
        static int table3_counter = 0;
        static int table4_counter = 0;
        static int table5_counter = 0;
        static int table6_counter = 0;
        static int table7_counter = 0;
        static int table8_counter = 0;
        static int table9_counter = 0;
        public static List<Game> GameList=new List<Game>();

        public Set_Game()
        {
            InitializeComponent();
        }

        private void Set_For_Two_CheckedChanged(object sender, EventArgs e)
        {
            if(Set_For_Two.Checked==true)
            {
                IDLabel1.Visible = true;
                IDLabel2.Visible = true;
                IDLabel3.Visible = false;
                Player1_ID_Set2.Visible = true;
                Player2_ID_Set2.Visible = true;
                Player1_ID_Set1.Visible = false;
                
            }
            else if(Set_For_One.Checked == true)
            {
                IDLabel1.Visible = false;
                IDLabel2.Visible = false;
                IDLabel3.Visible = true;
                Player1_ID_Set2.Visible = false;
                Player2_ID_Set2.Visible = false;
                Player1_ID_Set1.Visible = true;
                
            }
        }

        private void SetGame_btn_Click(object sender, EventArgs e)
        {
            if(GameList!=null)
            {
                if(GameList.Count==9)
                {
                    GameList = new List<Game>();
                }
            }
            
            if (Set_For_Two.Checked == true)
            {
                bool p1current_game_flag = false;
                bool p2current_game_flag = false;
                if (GameList != null)
                {
                    for (int index = 0; index < GameList.Count; index++)
                    {
                        if (Player1_ID_Set2.Text == GameList[index].PlayerID || Player1_ID_Set2.Text == GameList[index].Player2ID)
                        {
                            p1current_game_flag = true;
                            MessageBox.Show("Player 1 is already in another game", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (Player2_ID_Set2.Text == GameList[index].PlayerID || Player2_ID_Set2.Text == GameList[index].Player2ID)
                        {
                            p2current_game_flag = true;
                            MessageBox.Show("Player 2 is already in another game", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                Game game = new Game();
                bool check_player1 = Game_Menu.Mgr.Check_CNIC(Player1_ID_Set2.Text);
                bool check_player2 = Game_Menu.Mgr.Check_CNIC(Player2_ID_Set2.Text);
                if (check_player1 == true && check_player2 == true && p1current_game_flag==false && p2current_game_flag == false)
                {
                    bool status = Game_Menu.Mgr.setGame(2, Player1_ID_Set2.Text, Player2_ID_Set2.Text,ref table,ref game);
                    if (status == true)
                    {
                        GameList.Add(game);

                        if (table==0 )
                        {
                            if(table1_counter==0)
                            {
                                table1.BackColor = Color.Green;

                            }
                            else
                            {
                                table1.BackColor = Color.GreenYellow;
                            }
                            table1_counter++;
                        }
                        else if (table == 1)
                        {
                            if (table2_counter == 0)
                            {
                                table2.BackColor = Color.Green;

                            }
                            else
                            {
                                table2.BackColor = Color.GreenYellow;
                            }
                            table2_counter++;

                        }
                        else if (table == 2)
                        {
                            if (table3_counter == 0)
                            {
                                table3.BackColor = Color.Green;

                            }
                            else
                            {
                                table3.BackColor = Color.GreenYellow;
                            }
                            table3_counter++;

                        }
                        else if (table == 3)
                        {
                            if (table4_counter == 0)
                            {
                                table4.BackColor = Color.Green;
                                
                            }
                            else
                            {
                                table4.BackColor = Color.GreenYellow;
                            }
                            table4_counter++;

                        }
                        else if (table == 4)
                        {
                            if (table5_counter == 0)
                            {
                                table5.BackColor = Color.Green;

                            }
                            else
                            {
                                table5.BackColor = Color.GreenYellow;
                            }
                            table5_counter++;

                        }
                        else if (table == 5)
                        {
                            if (table6_counter == 0)
                            {
                                table6.BackColor = Color.Green;

                            }
                            else
                            {
                                table6.BackColor = Color.GreenYellow;
                            }
                            table6_counter++;

                        }
                        else if (table == 6)
                        {
                            if (table7_counter == 0)
                            {
                                table7.BackColor = Color.Green;

                            }
                            else
                            {
                                table7.BackColor = Color.GreenYellow;
                            }
                            table7_counter++;

                        }
                        else if (table == 7)
                        {
                            if (table8_counter == 0)
                            {
                                table8.BackColor = Color.Green;

                            }
                            else
                            {
                                table8.BackColor = Color.GreenYellow;
                            }
                            table8_counter++;

                        }
                        else if (table == 8)
                        {
                            if (table9_counter == 0)
                            {
                                table9.BackColor = Color.Green;

                            }
                            else
                            {
                                table9.BackColor = Color.GreenYellow;
                            }
                            table9_counter++;

                        }
                        GameData.Text += game.getData();
                        GameData.Text += "\n";
                    }
                    
                }
                else
                {
                    Registration_Form register = new Registration_Form();

                    if (check_player1 == false && check_player2==false)
                    {
                        MessageBox.Show("Player 1 & 2 are not registered players please register", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        register.Show();

                    }
                    else if (check_player1 == true && check_player2 == false)
                    {

                        MessageBox.Show("Player 2 is not a registered player please register", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        register.Show();
                    }
                    else if (check_player1 == false && check_player2 == true)
                    {

                        MessageBox.Show("Player 1 is not a registered player please register", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        register.Show();
                    }
                }
                

            }
            else if (Set_For_One.Checked == true)
            {
                bool p1current_game_flag = false;
                if (GameList != null)
                {
                    for (int index = 0; index < GameList.Count; index++)
                    {
                        if (Player1_ID_Set1.Text == GameList[index].PlayerID || Player1_ID_Set1.Text == GameList[index].Player2ID)
                        {
                            p1current_game_flag = true;
                            MessageBox.Show("Player 1 is already in another game", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    }
                }
                bool check_player1 = Game_Menu.Mgr.Check_CNIC(Player1_ID_Set1.Text);
                if (check_player1 == true && p1current_game_flag==false)
                {
                    
                    Game game = new Game();
                    bool status = Game_Menu.Mgr.setGame(1, Player1_ID_Set1.Text, "", ref table,ref game);
                    if (status == true)
                    {
                        GameList.Add(game);
                        if (table == 0)
                        {
                            if (table1_counter == 0)
                            {
                                table1.BackColor = Color.Green;

                            }
                            else
                            {
                                table1.BackColor = Color.GreenYellow;
                                
                            }
                            table1_counter++;
                            
                        }
                        else if (table == 1)
                        {
                            if (table2_counter == 0)
                            {
                                table2.BackColor = Color.Green;

                            }
                            else
                            {
                                table2.BackColor = Color.GreenYellow;
                            }
                            table2_counter++;

                        }
                        else if (table == 2)
                        {
                            if (table3_counter == 0)
                            {
                                table3.BackColor = Color.Green;

                            }
                            else
                            {
                                table3.BackColor = Color.GreenYellow;
                            }
                            table3_counter++;

                        }
                        else if (table == 3)
                        {
                            if (table4_counter == 0)
                            {
                                table4.BackColor = Color.Green;

                            }
                            else
                            {
                                table4.BackColor = Color.GreenYellow;
                            }
                            table4_counter++;

                        }
                        else if (table == 4)
                        {
                            if (table5_counter == 0)
                            {
                                table5.BackColor = Color.Green;

                            }
                            else
                            {
                                table5.BackColor = Color.GreenYellow;
                            }
                            table5_counter++;

                        }
                        else if (table == 5)
                        {
                            if (table6_counter == 0)
                            {
                                table6.BackColor = Color.Green;

                            }
                            else
                            {
                                table6.BackColor = Color.GreenYellow;
                            }
                            table6_counter++;

                        }
                        else if (table == 6)
                        {
                            if (table7_counter == 0)
                            {
                                table7.BackColor = Color.Green;

                            }
                            else
                            {
                                table7.BackColor = Color.GreenYellow;
                            }
                            table7_counter++;

                        }
                        else if (table == 7)
                        {
                            if (table8_counter == 0)
                            {
                                table8.BackColor = Color.Green;

                            }
                            else
                            {
                                table8.BackColor = Color.GreenYellow;
                            }
                            table8_counter++;

                        }
                        else if (table == 8)
                        {
                            if (table9_counter == 0)
                            {
                                table9.BackColor = Color.Green;

                            }
                            else
                            {
                                table9.BackColor = Color.GreenYellow;
                                table1_counter = 0;
                                table2_counter = 0;
                                table3_counter = 0;
                                table4_counter = 0;
                                table5_counter = 0;
                                table6_counter = 0;
                                table7_counter = 0;
                                table8_counter = 0;
                                table9_counter = 0;
                            }
                            table9_counter++;

                        }
                        GameData.Text += game.getData();
                        GameData.Text += "\n";
                    }
                    
                }
                else
                {
                    Registration_Form register = new Registration_Form();

                    if (check_player1 == false)
                    {
                        MessageBox.Show("Player 1 is not a registered player please register", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        register.Show();

                    }
                }
            }
        }

        private void Set_Game_Load(object sender, EventArgs e)
        {

        }

        private void Player1_ID_Set2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_Tables all = new All_Tables();
            all.Show();
        }

        private void Player1_ID_Set1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Set_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game_Menu.Mgr.exit();
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
