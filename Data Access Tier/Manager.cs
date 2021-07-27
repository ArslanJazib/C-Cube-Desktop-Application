using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace DataAccessaLayer
{
    public class Manager : Person
    {
        FilesManager f = new FilesManager();

        double salary;
        DateTime dutyTime;
        public static List<Game> GameList;
        public static ArrayList PlayerList;
        public static KeyValuePair<Game, int>[] Currently_PlayedGames = new KeyValuePair<Game, int>[9];
        public static int game_index = 0;

        public static int table1_counter = 9;
        public static int table2_counter = 9;
        public static int table3_counter = 9;
        public static int table4_counter = 9;
        public static int table5_counter = 9;
        public static int table6_counter = 9;
        public static int table7_counter = 9;
        public static int table8_counter = 9;
        public static int table9_counter = 9;
        public static bool lasttable_filled = false;
        // Referencing the same list present in files manager class to the manager class
        public Manager()
        {
            PlayerList = f.PlayerList1;
            GameList = f.GameList;

        }
        public Manager(string cnic, string name, double salary, DateTime dutyTime) : base(cnic, name)
        {
            this.salary = salary;
            this.dutyTime = dutyTime;
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public DateTime DutyTime
        {
            set { dutyTime = value; }
            get { return dutyTime; }
        }
        public override string getData()
        {
            string data = base.getData();
            data += "Salary : " + this.salary + "\n";
            data += "Duty Time : " + this.dutyTime + "\n";
            return data;
        }

        // Registring a new player overloaded for win forms
        public bool registerNewPlayer(string cnic, string name)
        {
            Player newPlayer = new Player();
            newPlayer.Cnic = cnic;
            newPlayer.Name = name;
            int count = PlayerList.Count;
            bool validation = Check_CNIC(newPlayer, count, Manager.PlayerList); //Function to compare input with the Present data
            if (validation == true) // If the CNIC entered is unique then take other inputs
            {
                Manager.PlayerList.Add(newPlayer);
                return validation;
            }

            return validation = false;

        }
        public bool Check_CNIC(Player player, int length, ArrayList PlayerList)
        {
            bool valid = true;
            for (int index = 0; index < length; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Player p = PlayerList[index] as Player;
                if (p.Cnic == player.Cnic)
                {
                    valid = false;
                }
            }
            return valid;
        }
        // Check_CNIC overloaded
        public bool Check_CNIC(string cnic)
        {
            bool valid = false;
            for (int index = 0; index < Manager.PlayerList.Count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Player p = PlayerList[index] as Player;
                if (p.Cnic == cnic)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public string displayAllPlayers()
        {
            string allData = "";

            for (int index = 0; index < PlayerList.Count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Player p = PlayerList[index] as Player;
                allData += p.getData();
            }
            // InputOutputHandler.displayAllPlayers(this.PlayerList);
            return allData;

        }

        // Searching a player by their CNIC (overloaded function)
        public Player searchPlayerInfoByCNIC(string searched_cnic)
        {
            Player SearchedPlayer = new Player(); // To store the information of the searched player
            for (int index = 0; index < Manager.PlayerList.Count; index++)
            {
                // Comapring eachh CNIC withe the entered CNIC
                Player p = PlayerList[index] as Player;
                if (p.Cnic == searched_cnic)
                {
                    SearchedPlayer = p;
                    break;
                }
            }
            return SearchedPlayer;
        }
        // Searching a player by their name
        public List<Player> searchPlayerInfoByName(string searched_name)
        {
            List<Player> SearchedPlayer = new List<Player>(); // To store the information of the searched player
            for (int index = 0; index < Manager.PlayerList.Count; index++)
            {
                // Comapring eachh CNIC withe the entered CNIC
                Player p = PlayerList[index] as Player;
                if (p.Name == searched_name)
                {
                    SearchedPlayer.Add(p);
                }
            }
            return SearchedPlayer;
        }
        // Updating player's function overloaded for both option
        public Player updatePlayer(string cnic, string name, string old_cnic)
        {
            Player p = new Player();
            if (cnic != "" && name != "")
            {
                for (int index = 0; index < Manager.PlayerList.Count; index++)
                {
                    p = Manager.PlayerList[index] as Player;
                    if (p.Cnic == old_cnic)
                    {
                        
                            p.Cnic = cnic;
                            p.Name = name;
                            PlayerList[index] = p;
                            return p;
                        
                        
                    }
                }
            }
            return p;
        }
        // Update player overloaded for cnic option
        public Player updatePlayer(string cnic,string old_cnic)
        {
            Player p = new Player();
            if (cnic != "" && name != "")
            {
                for (int index = 0; index < Manager.PlayerList.Count; index++)
                {
                    p = Manager.PlayerList[index] as Player;
                    if (p.Cnic == old_cnic)
                    {

                        p.Cnic = cnic;
                        PlayerList[index] = p;
                        
                        return p;


                    }
                    else
                    {
                        p = new Player();
                    }
                }
            }
            return p;
        }
        // Update player  for name option
        public Player updatePlayername(string cnic, string name)
        {
            Player p = new Player();
            if (cnic != "" && name != "")
            {
                for (int index = 0; index < Manager.PlayerList.Count; index++)
                {
                    p = Manager.PlayerList[index] as Player;
                    if (p.Cnic == cnic)
                    {

                        p.Name = name;
                        PlayerList[index] = p;
                        return p;


                    }
                }
            }
            return p;
        }




        // Deleting a player from the list for windows form (CNIC)
        public bool DeletePlayer(string cnic)
        {
            int index2 = -1;           
            string delete_cnic = cnic;
            for (int index = 0; index < Manager.PlayerList.Count; index++)
            {
                Player deleted_player = Manager.PlayerList[index] as Player;
                if (deleted_player.Cnic == delete_cnic)
                {
                    index2=index;
                }
            }
            if (index2 != -1)
            {
                Manager.PlayerList.RemoveAt(index2);
                return true;

            }
            else
            {
                return false;
            }
            
        }
        public int DeletePlayerByName(string name,List<Player> indexes)
        {
            string delete_name = name;
            List<int> delete_index = new List<int>();
            for (int index = 0; index < Manager.PlayerList.Count; index++)
            {
                Player deleted_player = Manager.PlayerList[index] as Player;
                if (deleted_player.Name == delete_name)
                {
                    indexes.Add(deleted_player);
                    delete_index.Add(index);
                }
            }           
            if (indexes.Count==1)
            {
                Manager.PlayerList.RemoveAt(delete_index[0]);
                return 1;

            }
            else if(indexes.Count > 1)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        public bool DeleteGame(int id)
        {
            int index2 = -1;
            int deleted_game = id;
            for (int index = 0; index < Manager.GameList.Count; index++)
            {
                Game delete = Manager.GameList[index] as Game;
                if (delete.GameID == deleted_game)
                {
                    index2 = index;
                }
            }
            if (index2 != -1)
            {
                Manager.GameList.RemoveAt(index2);
                return true;

            }
            else
            {
                return false;
            }

        }
        public int DeleteGameByPlayer(string id, List<Game> indexes)
        {
            string delete = id;
            List<int> delete_index = new List<int>();
            for (int index = 0; index < Manager.GameList.Count; index++)
            {
                Game deleted_game = Manager.GameList[index] as Game;
                if (deleted_game.PlayerID == delete|| deleted_game.Player2ID == delete)
                {
                    indexes.Add(deleted_game);
                    delete_index.Add(index);
                }
            }
            if (indexes.Count == 1)
            {
                Manager.GameList.RemoveAt(delete_index[0]);
                return 1;

            }
            else if (indexes.Count > 1)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        // Saving all the changes in the player text file
        public void exit()
        {
            for (int index = 0; index < PlayerList.Count; index++)
            {
                Player p = PlayerList[index] as Player;
                FilesManager.UpdateFile(p);
            }
            for (int index = 0; index < GameList.Count; index++)
            {
                FilesManager.UpdateGameFile(GameList[index]);
            }
        }
        public bool setGame(int total,string player1_ID_Set, string player2_ID_Set,ref int table,ref Game game )
        {
            if(GameList.Count!=0)
            {
                TableQueueManager.GameID = GameList[GameList.Count - 1].GameID;
            }
            bool setflag = false;
            Game newGame = TableQueueManager.setGame(Manager.PlayerList,total, player1_ID_Set, player2_ID_Set);
            if (newGame.GameID != -1)
            {
                setflag = true;
                table = newGame.TableID;
                GameList.Add(newGame);
                Currently_PlayedGames[game_index] = new KeyValuePair<Game, int>(newGame, 0);
                TableQueueManager.Gametimer(game_index, Currently_PlayedGames, Manager
                    .PlayerList);
                game = GameList[GameList.Count - 1];
                if (lasttable_filled == true)
                {
                    game_index = 0;
                    table1_counter = 9;
                    table2_counter = 9;
                    table3_counter = 9;
                    table4_counter = 9;
                    table5_counter = 9;
                    table6_counter = 9;
                    table7_counter = 9;
                    table8_counter = 9;
                    if (TableQueueManager.WaitingPlayersQueue != null)
                    {

                        TableQueueManager.Assign_waiting(Manager.PlayerList, TableQueueManager.WaitingPlayersQueue[0]);

                    }

                }
                else
                {
                    game_index++;
                }

            }
            return setflag;
        }
        public bool DisplayTableStatus(int[] filled, ref int waiting)
        {
            bool status=TableQueueManager.Display_TablesStatus(filled,ref waiting);
            return status;
        }

        public string displayAllgames()
        {
            string allData = "";

            for (int index = 0; index < GameList.Count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Game game = GameList[index] as Game;
                allData += game.getData();
                allData += "\n";
            }

            return allData;
            
        }
        public Game getGamebyID(int searched_ID)
        {
            Game SearchedGame = new Game(); // To store the information of the searched game
            for (int index = 0; index < GameList.Count; index++)
            {
                // Comapring each ID with the entered ID
                if (GameList[index].GameID == searched_ID)
                {
                    SearchedGame = GameList[index];
                    break;
                }
            }
            return SearchedGame;
        }
        public List<Game> getGamebyPlayerID(string searched_ID)
        {
            List<Game> SearchedGame = new List<Game>(); // To store the information of the searched game
            for (int index = 0; index < GameList.Count; index++)
            {
                // Comapring each ID with the entered ID
                if (GameList[index].Player2ID == searched_ID || GameList[index].PlayerID == searched_ID)
                {
                    SearchedGame.Add(GameList[index]);
                }
            }
            return SearchedGame;
        }
    }
}

