using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DataAccessaLayer
{
    public class InputOutputHandler
    {
        // Taking input from the user for new registration
        public static Player getPlayerInfoFromUser(ArrayList PlayerList)
        {
            bool validation = false; // For checking CNIC to avoid repetition
            Player player = new Player();

            // Loop to keep asking for the CNIC in case if CNIC already exists
            do
            {
                Console.WriteLine("-----------------------\n");
                Console.WriteLine("Enter information to register new player\n");
                Console.WriteLine("-----------------------\n");
                Console.Write("Enter CNIC: ");
                player.Cnic = Console.ReadLine();
                int count = PlayerList.Count;
                    validation = Check_CNIC(player, count, PlayerList); //Function to compare input with the Present data

                    if (validation == true) // If the CNIC entered is unique then take other inputs
                    {
                        Console.Write("Enter Name: ");
                        player.Name = Console.ReadLine();
                        return player;

                    }
                    else
                    {
                        Console.WriteLine("Player already exists enter again: ");
                    }
                    Console.WriteLine("------------------------\n");
               

            } while (validation == false);
            return player;
        }

        // Function to Compare user's input with the CNIC present in file
        public static bool Check_CNIC(Player player, int count, ArrayList PlayerList)
        {
            bool validation = true;
            for (int index = 0; index <count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Player p = PlayerList[index] as Player;
                if (p.Cnic == player.Cnic)
                {
                    validation = false;
                }
            }
            return validation;
        }

        // Displaying all players
        public static void displayAllPlayers(ArrayList playerlist)
        {
            for (int index = 0; index < playerlist.Count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Player p = playerlist[index] as Player;
                Console.WriteLine(p.getData());
            }

        }

        // Searching a player by their CNIC
        public static Player getPlayerByCNIC(ArrayList playerlist)
        {
            Player SearchedPlayer = new Player(); // To store the information of the searched player
            Console.Write("Enter CNIC: ");
            string searched_cnic = Console.ReadLine();
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

        // Searching a player by their CNIC (overloaded function)
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
        // Update player's infor based on input
        public static ArrayList UpdatePlayerInfo(ArrayList playerList)
        {
            string input;
            string check = "0";
            int choice;
            bool validation = false; // For checking CNIC to avoid repetition
            int count = playerList.Count;
            Player p = new Player();
            do
            {
                Console.Write("Enter CNIC of the player to update his/her record: ");
                input = Console.ReadLine();
                for (int index = 0; index < playerList.Count; index++)
                {
                    p = playerList[index] as Player;
                    if (p.Cnic == input)
                    {
                        Console.WriteLine("Press 1 to change CNIC");
                        Console.WriteLine("Press 2 to change Name");
                        Console.WriteLine("Press 3 to change Both");
                        choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.Write("Enter New CNIC: ");
                            input = Console.ReadLine();
                            Player temp = new Player(); // A temporary object to hold the new CNIC for comparison
                            temp.Cnic = input;
                            validation = Check_CNIC(temp, count, playerList); //Function to compare input with the Present data
                            if (validation == true) // If the CNIC entered is unique then take other inputs
                            {
                                p.Cnic = input;
                                playerList[index] = p;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("CNIC Already exists");
                            }
                        }
                        else if (choice == 2)
                        {
                            Console.Write("Enter New Name: ");
                            input=Console.ReadLine();
                            p.Name = input;
                            playerList[index] = p;
                            break;
                        }
                        else if (choice == 3)
                        {
                     
                            Console.Write("Enter New CNIC: ");
                            input = Console.ReadLine();
                            Player temp = new Player(); // A temporary object to hold the new CNIC for comparison
                            temp.Cnic = input;
                            validation = Check_CNIC(temp, count, playerList); //Function to compare input with the Present data
                            if (validation == true) // If the CNIC entered is unique then take other inputs
                            {
                                p.Cnic = input;
                                Console.Write("Enter New Name: ");
                                input = Console.ReadLine();
                                p.Name = input;
                                playerList[index] = p;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("CNIC Already exists");
                            }
                        }
                        else
                        {
                            Console.Write("Wrong Choice: ");
                            break;

                        }

                    }
                }
                Console.Write("Press 1 if you want to update another player : ");
                check = Console.ReadLine();
            } while (check == "1");

            return playerList;

        }

        // Deleting a player
        public static int DeletePlayer(ArrayList playerList)
        {
            int index2=-1;
            Console.Write("Enter CNIC: ");
            string delete_cnic = Console.ReadLine();
            for (int index = 0; index < playerList.Count; index++)
            {
                Player deleted_player = playerList[index] as Player;
                if (deleted_player.Cnic == delete_cnic)
                {
                    return index;
                }
            }
            return index2;
        }
        
        // Updating the file with all the changes made
        public static void Updatefile(ArrayList playerList)
        {
            for(int index=0;index<playerList.Count;index++)
            {
                Player p = playerList[index] as Player;
                FilesManager.UpdateFile(p);
            }
        }

        // Deleting a game
        public static int DeleteGame(List<Game> GameList)
        {
            int index2 = -1;
            Console.Write("Enter Game ID: ");
            int deleted_game = int.Parse(Console.ReadLine());
            for (int index = 0; index < GameList.Count; index++)
            {
                if (deleted_game == GameList[index].TableID)
                {
                    return index;
                }
            }
            return index2;
        }
        // Updating the game file with all the changes made
        public static void UpdateGamefile(List<Game> GameList)
        {
            for (int index = 0; index < GameList.Count; index++)
            {
                FilesManager.UpdateGameFile(GameList[index]);
            }
        }
        // Searching a game by GameID
        public static Game getGamebyID(int searched_ID, List<Game> GameList)
        {
            Game SearchedGame = new Game(); // To store the information of the searched game
            for (int index = 0; index < GameList.Count; index++)
            {
                // Comapring each ID with the entered ID
                if (GameList[index].TableID == searched_ID)
                {
                    SearchedGame = GameList[index];
                    break;
                }
            }
            return SearchedGame;
        }
        // Displaying all games
        public static void displayAllgames(List<Game> GameList )
        {
            for (int index = 0; index < GameList.Count; index++)
            {
                // Parsing back player objects from the PlayerList (linked list)
                Console.WriteLine(GameList[index].getData());
            }

        }
    }
}
