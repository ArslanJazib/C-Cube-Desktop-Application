using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
namespace DataAccessaLayer

{
    public class TableQueueManager
    {

        static Stack<string> table1_check = new Stack<string>(2);
        static Stack<string> table2_check = new Stack<string>(2);
        static Stack<string> table3_check = new Stack<string>(2);
        static Stack<string> table4_check = new Stack<string>(2);
        static Stack<string> table5_check = new Stack<string>(2);
        static Stack<string> table6_check = new Stack<string>(2);
        static Stack<string> table7_check = new Stack<string>(2);
        static Stack<string> table8_check = new Stack<string>(2);
        static Stack<string> table9_check = new Stack<string>(2);

        


        static Stack<string>[] Alltables = { table1_check , table2_check , table3_check ,
        table4_check , table5_check ,table6_check,table7_check,table8_check,table9_check};

        Table GameTable = new Table();
        static public int GameID = 0;

        public static List<Player> WaitingPlayersQueue;

        public static Game setGame(ArrayList PlayerList,int total, string player1_ID_Set, string player2_ID_Set)
        {
            Game game = new Game();
            int PlayerCheck = -1;
            string unknownPlayer2;
            Player player1 = new Player();
            Player player2 = new Player();
            int total_players = total;
            if (total_players == 1)
            {
                PlayerCheck = Assign_Player(PlayerList, player1,player1_ID_Set);
                if (PlayerCheck != -1)
                {
                    unknownPlayer2 = Alltables[PlayerCheck].ElementAt<string>(1);
                    player2 = TableQueueManager.getPlayerByCNIC(unknownPlayer2, PlayerList);
                }
            }
            if (total_players == 2)
            {
                PlayerCheck = Assign_Player(PlayerList, player1, player2,  player1_ID_Set,  player2_ID_Set);
            }
            if (PlayerCheck >= 0)
            {
                game.GameID = GameID_generator();
                game.TableID = PlayerCheck;
                game.PlayerID = (player1.Cnic);
                game.Player2ID = (player2.Cnic);
            }
            return game;

        }
        // For a single Player
        public static int Assign_Player(ArrayList PlayerList, Player player, string player1_ID_Set)
        {
            bool status;
            bool Allfilled = Check_FilledStatus(); ;
            bool AllEmpty = Check_AllTablesStatus();
            int Player_Waiting;
            player.Cnic = player1_ID_Set;
            status = false; // Player registration is already confirmed
            if (status == false)
            {
                player = TableQueueManager.getPlayerByCNIC(player.Cnic, PlayerList);
                if (Allfilled == false)
                {
                    if (AllEmpty == true)
                    {
                        Alltables[0].Push((player.Cnic));
                        return -1;
                    }
                    else if (AllEmpty == false)
                    {
                        Player_Waiting = Check_Waiting();
                        if (Player_Waiting != -1)
                        {
                            for (int loop = 0; loop < 9; loop++)
                            {
                                if (Alltables[loop].Count == 0)
                                {
                                    Alltables[Player_Waiting].Push((player.Cnic));
                                    return Player_Waiting;
                                }
                            }

                        }
                        else
                        {
                            for (int loop = 0; loop < 9; loop++)
                            {
                                if (Alltables[loop].Count == 0)
                                {
                                    Alltables[loop].Push((player.Cnic));
                                    return -1;
                                }
                            }
                        }

                    }
                }
                else
                {
                    WaitingPlayersQueue[0] = player;
                }
            }
           
            return -1;
        }
        // For two Players
        public static int Assign_Player(ArrayList PlayerList, Player player1, Player player2, string player1_ID_Set, string player2_ID_Set)
        {
            bool status, status2;
            bool Allfilled = Check_FilledStatus(); ;
            bool AllEmpty = Check_AllTablesStatus();
            int Player_Waiting;
            player1.Cnic = player1_ID_Set;
            status = false;
            if (status == false)
            {
                player1 = TableQueueManager.getPlayerByCNIC(player1.Cnic, PlayerList);
            }
            player2.Cnic = player2_ID_Set;
            status2 = false;
            if (status2 == false)
            {
                player2 = TableQueueManager.getPlayerByCNIC(player2.Cnic, PlayerList);
            }           
            if (Allfilled == false)
            {
                if (AllEmpty == true)
                {
                    Alltables[0].Push((player1.Cnic));
                    Alltables[0].Push((player2.Cnic));
                    return 0;
                }
                else if (AllEmpty == false)
                {
                    Player_Waiting = Check_Waiting();

                    if (Player_Waiting != -1)
                    {
                        for (int loop = 0; loop < 9; loop++)
                        {
                            if (Alltables[loop].Count == 0)
                            {
                                Alltables[loop].Push(Alltables[Player_Waiting].Pop());
                                Alltables[loop - 1].Push((player1.Cnic));
                                Alltables[loop - 1].Push((player2.Cnic));
                                return loop;
                            }
                            else if (Alltables[8].Count == 1)
                            {
                                WaitingPlayersQueue = new List<Player>();
                                WaitingPlayersQueue.Add(WaitingPlayer_func(Alltables[Player_Waiting].Pop(), PlayerList));
                                Alltables[8].Push(player1.Cnic);
                                Alltables[8].Push(player2.Cnic);
                                return 8;

                            }
                            


                        }

                    }
                    if (Allfilled != true)
                    {
                        for (int loop = 0; loop < 9; loop++)
                        {
                            if (Alltables[loop].Count == 0)
                            {
                                Alltables[loop].Push((player1.Cnic));
                                Alltables[loop].Push((player2.Cnic));
                                return loop;
                            }

                        }
                    }

                }
            }
           
            return -1;
        }
        public static int GameID_generator()
        {
            
            return ++GameID;
        }
        public static int Check_Waiting()
        {
            for (int loop = 0; loop < 9; loop++)
            {
                if (Alltables[loop].Count == 1)
                {
                    return loop;
                }
            }
            return -1;
        }
        public static bool Display_TablesStatus(int[] filled, ref int waiting)
        {
            bool status=false;
            int flag = 0;
            for (int loop = 0; loop < 9; loop++)
            {
                if (Alltables[loop].Count == 0)
                {
                    flag++;
                }
                else if (Alltables[loop].Count == 2)
                {
                    filled[loop] = loop + 1;
                }
                else
                {
                    waiting = loop + 1;
                }
            }
            if (flag == 9)
            {
                status= true;
            }
            return status;
        }
        public static Player WaitingPlayer_func(string CNIC, ArrayList PlayerList)
        {
            Player WaitingPlayer = new Player();
            WaitingPlayer = TableQueueManager.getPlayerByCNIC(CNIC, PlayerList);
            return WaitingPlayer;
        }

        public static bool Check_AllTablesStatus()
        {
            int flag = 0;

            for (int loop = 0; loop < 9; loop++)
            {
                if (Alltables[loop].Count == 0)
                {
                    flag++;
                }

            }
            if (flag == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Check_FilledStatus()
        {
            int flag = 0;

            for (int loop = 0; loop < 9; loop++)
            {
                if (Alltables[loop].Count == 2)
                {
                    flag++;
                }

            }
            if (flag == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Gametimer(int index, KeyValuePair<Game, int>[] current_games, ArrayList PlayerList)
        {
            Game to_be_deleted = new Game();
            Player temporary = new Player();
            string player1;
            string player2;
            uint Intitial_GamesWonP1 = 0;
            uint Intitial_GamesWonP2 = 0;
            bool result_flag = false;

            if (index == 0)
            {
                if(Manager.lasttable_filled==true)
                {
                    Manager.lasttable_filled = true;
                    Manager.table9_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table9_counter);
                }
                Manager.table1_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table1_counter);
            }
            else if (index == 1)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table2_counter);
            }
            else if (index == 2)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table3_counter);
            }
            else if (index == 3)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table4_counter);
            }
            else if (index == 4)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[3] = new KeyValuePair<Game, int>(current_games[3].Key, Manager.table4_counter);
                Manager.table5_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table5_counter);
            }
            else if (index == 5)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[3] = new KeyValuePair<Game, int>(current_games[3].Key, Manager.table4_counter);
                Manager.table5_counter--;
                current_games[4] = new KeyValuePair<Game, int>(current_games[4].Key, Manager.table5_counter);
                Manager.table6_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table6_counter);
            }
            else if (index == 6)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[3] = new KeyValuePair<Game, int>(current_games[3].Key, Manager.table4_counter);
                Manager.table5_counter--;
                current_games[4] = new KeyValuePair<Game, int>(current_games[4].Key, Manager.table5_counter);
                Manager.table6_counter--;
                current_games[5] = new KeyValuePair<Game, int>(current_games[5].Key, Manager.table6_counter);
                Manager.table7_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table7_counter);
            }
            else if (index == 7)
            {
                if (Manager.lasttable_filled == true)
                {
                    Manager.table8_counter--;
                    current_games[8] = new KeyValuePair<Game, int>(current_games[8].Key, Manager.table8_counter);
                }
                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[3] = new KeyValuePair<Game, int>(current_games[3].Key, Manager.table4_counter);
                Manager.table5_counter--;
                current_games[4] = new KeyValuePair<Game, int>(current_games[4].Key, Manager.table5_counter);
                Manager.table6_counter--;
                current_games[5] = new KeyValuePair<Game, int>(current_games[5].Key, Manager.table6_counter);
                Manager.table7_counter--;
                current_games[6] = new KeyValuePair<Game, int>(current_games[6].Key, Manager.table7_counter);
                Manager.table8_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table8_counter);
            }
            else if (index == 8)
            {

                Manager.table1_counter--;
                current_games[0] = new KeyValuePair<Game, int>(current_games[0].Key, Manager.table1_counter);
                Manager.table2_counter--;
                current_games[1] = new KeyValuePair<Game, int>(current_games[1].Key, Manager.table2_counter);
                Manager.table3_counter--;
                current_games[2] = new KeyValuePair<Game, int>(current_games[2].Key, Manager.table3_counter);
                Manager.table4_counter--;
                current_games[3] = new KeyValuePair<Game, int>(current_games[3].Key, Manager.table4_counter);
                Manager.table5_counter--;
                current_games[4] = new KeyValuePair<Game, int>(current_games[4].Key, Manager.table5_counter);
                Manager.table6_counter--;
                current_games[5] = new KeyValuePair<Game, int>(current_games[5].Key, Manager.table6_counter);
                Manager.table7_counter--;
                current_games[6] = new KeyValuePair<Game, int>(current_games[6].Key, Manager.table7_counter);
                Manager.table8_counter--;
                current_games[7] = new KeyValuePair<Game, int>(current_games[7].Key, Manager.table8_counter);
                Manager.table9_counter--;
                current_games[index] = new KeyValuePair<Game, int>(current_games[index].Key, Manager.table9_counter);
                Manager.lasttable_filled = true;
            }
            if (Manager.table1_counter == 0)
            {
                emptytable(0);
            }
            if (Manager.table2_counter == 0)
            {
                emptytable(1);

            }
            if (Manager.table3_counter == 0)
            {
                emptytable(2);

            }
            if (Manager.table4_counter == 0)
            {
                emptytable(3);

            }
            if (Manager.table5_counter == 0)
            {
                emptytable(4);

            }
            if (Manager.table6_counter == 0)
            {
                emptytable(5);

            }
            if (Manager.table7_counter == 0)
            {
                emptytable(6);

            }
            if (Manager.table8_counter == 0)
            {
                emptytable(7);

            }
            if (Manager.table9_counter == 0)
            {
                emptytable(8);
                Manager.lasttable_filled = false;
                Manager.table9_counter = 9;
            }

            void emptytable(int table)
            {
                to_be_deleted = current_games[table].Key;
                player1 = to_be_deleted.PlayerID;
                player2 = to_be_deleted.Player2ID;

                for (int loop = 0; loop < Alltables.Length; loop++)
                {
                    if (Alltables[loop].ElementAt(0) == player2)
                    {
                        Alltables[loop].Pop();
                        Alltables[loop].Pop();
                    }
                }
                for (int loop = 0; loop < PlayerList.Count; loop++)
                {
                    Player player = PlayerList[loop] as Player;

                    if (player.Cnic == player1)
                    {
                        Intitial_GamesWonP1 = player.TotalGamesWon;
                        if (result_flag == false)
                        {
                            result_calculator();
                            if (current_games[table].Key.Result == 0) //Draw
                            {
                                player.TotalGamesPlayed++;
                            }
                            else if (current_games[table].Key.Result == 1) // Player 1 wins
                            {
                                player.TotalGamesWon++;
                            }
                            else if (current_games[table].Key.Result == 2) // Player 1 wins
                            {
                                player.TotalGamesLost++;
                            }
                            result_flag = true;
                            temporary = player;
                        }
                        else if (temporary.TotalGamesWon > Intitial_GamesWonP2)
                        {
                            player.TotalGamesLost++;
                            player.TotalGamesPlayed++;
                        }
                        else
                        {
                            player.TotalGamesPlayed++;
                        }
                        PlayerList[loop] = player;
                    }
                    else if (player.Cnic == player2)
                    {
                        Intitial_GamesWonP2 = player.TotalGamesWon;

                        if (result_flag == false)
                        {
                            result_calculator();
                            if (current_games[table].Key.Result == 0) //Draw
                            {
                                player.TotalGamesPlayed++;
                            }
                            else if (current_games[table].Key.Result == 1) // Player 1 wins
                            {
                                player.TotalGamesLost++;
                            }
                            else if (current_games[table].Key.Result == 2) // Player 1 wins
                            {
                                player.TotalGamesWon++;
                            }
                            result_flag = true;
                            temporary = player;
                        }
                        else if (temporary.TotalGamesWon > Intitial_GamesWonP1)
                        {
                            player.TotalGamesLost++;
                            player.TotalGamesPlayed++;
                        }
                        else
                        {
                            player.TotalGamesPlayed++;
                        }
                    }
                    PlayerList[loop] = player;
                }
                void result_calculator()
                {

                    current_games[table].Key.Result = result();

                    byte result(byte min = 0, byte max = 2)
                    {
                        Random random = new Random();
                        return byte.Parse((random.Next(min, max)).ToString());
                    }
                }
                for(int inc=0;inc<Manager.GameList.Count;inc++)
                {
                    if(Manager.GameList[inc].GameID == current_games[table].Key.GameID)
                    {
                        Manager.GameList[inc]= current_games[table].Key;
                    }
                }
            }
        }
        public static int Assign_waiting(ArrayList PlayerList, Player player)
        {
            bool Allfilled = Check_FilledStatus(); ;
            bool AllEmpty = Check_AllTablesStatus();
            int Player_Waiting;
                if (Allfilled == false)
                {
                    if (AllEmpty == false)
                    {
                        Player_Waiting = Check_Waiting();
                        if (Player_Waiting != -1)
                        {
                            for (int loop = 0; loop < 9; loop++)
                            {
                                if (Alltables[loop].Count == 0)
                                {
                                    Alltables[Player_Waiting].Push((player.Cnic));
                                    return Player_Waiting;
                                }
                            }

                        }
                        else
                        {
                            for (int loop = 0; loop < 9; loop++)
                            {
                                if (Alltables[loop].Count == 0)
                                {
                                    Alltables[loop].Push((player.Cnic));
                                    return -1;
                                }
                            }
                        }

                    }
                }
                else
                {
                    WaitingPlayersQueue[0] = player;
                }
            return -1;
            
        }


        public static Player getPlayerByCNIC(string searched_cnic, ArrayList playerlist)
        {
            Player SearchedPlayer = new Player(); // To store the information of the searched player
            for (int index = 0; index < playerlist.Count; index++)
            {
                // Comapring eachh CNIC withe the entered CNIC
                Player p = playerlist[index] as Player;
                if (p.Cnic == searched_cnic)
                {
                    SearchedPlayer = p;
                    break;
                }
            }
            return SearchedPlayer;
        }
    }
    
}
