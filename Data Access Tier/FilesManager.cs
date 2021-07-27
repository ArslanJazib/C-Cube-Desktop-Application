using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace DataAccessaLayer
{
    public class FilesManager
    {
        ArrayList PlayerList;

        List<Game> gameList = new List<Game>();

        static public int counter = 0; // To check if the file is ever updated before
        static public int game_counter = 0; // To check if the file is ever updated before

        public ArrayList PlayerList1
        {
            get
            {
                return PlayerList;
            }

            set
            {
                PlayerList = value;
            }
        }

        public List<Game> GameList
        {
            get { return gameList; }
            set { gameList = value; }
        }

        public FilesManager()
        {
            PlayerList1 = new ArrayList();
            this.ReadAllPlayers();
            GameList = new List<Game>();
            this.ReadAllGames();
        }
        // Writing the manager's data in a text file
        public static void StoreManagerInfo(Manager manager)
        {
            StreamWriter writer = new StreamWriter("Manager.txt", true);
            writer.WriteLine(manager.Cnic);
            writer.WriteLine(manager.Name);
            writer.WriteLine(manager.Salary);
            writer.WriteLine(manager.DutyTime);
            writer.Close();
        }
        // Writing the player's data in a text file
        public static void StorePlayerInfo(Player player)
        {
            StreamWriter writer = new StreamWriter("Player.txt", true);
            writer.WriteLine(player.Cnic);
            writer.WriteLine(player.Name);
            writer.WriteLine(player.TotalGamesPlayed);
            writer.WriteLine(player.TotalGamesLost);
            writer.WriteLine(player.TotalGamesWon);
            writer.Close();
        }
        // Reading manager's text file
        public Manager GetManagerFromFile()
        {
            Manager manager = new Manager();
            StreamReader reader = new StreamReader("Manager.txt");
            while (!reader.EndOfStream)
            {
                manager.Cnic = reader.ReadLine();
                manager.Name = reader.ReadLine();
                manager.Salary = double.Parse(reader.ReadLine());
                manager.DutyTime = DateTime.Parse(reader.ReadLine());
            }
            reader.Close();
            return manager;
        }
        // Reading player's text file
        public void ReadAllPlayers()
        {
            StreamReader reader = new StreamReader("Player.txt");
            while (!reader.EndOfStream)
            {
                Player player = new Player();
                player.Cnic = reader.ReadLine();
                player.Name = reader.ReadLine();
                player.TotalGamesPlayed = uint.Parse(reader.ReadLine());
                player.TotalGamesWon = uint.Parse(reader.ReadLine());
                player.TotalGamesLost = uint.Parse(reader.ReadLine());
                PlayerList1.Add(player);
            }
            reader.Close();
        }
        // Updating the player text file to all the changes present in the linked list
        public static void UpdateFile(Player p)
        {
            Player player = p;

            if (counter == 0) // If file is never updated before clear it's content
            {
                StreamWriter clear = new StreamWriter("Player.txt");
                clear.Flush();
                clear.Close();
            }
            // write the updated data
            StorePlayerInfo(p);           
            counter++;
        }

        public static void StoreGameInfo(Game game)
        {
            StreamWriter writer = new StreamWriter("Game.txt", true);
            writer.WriteLine(game.GameID);
            writer.WriteLine(game.TableID);
            writer.WriteLine(game.PlayerID);
            writer.WriteLine(game.Player2ID);
            writer.WriteLine(game.Result);
            writer.Close();
        }
        public void ReadAllGames()
        {
            StreamReader reader = new StreamReader("Game.txt");
            while (!reader.EndOfStream)
            {
                Game game = new Game();
                game.GameID = int.Parse(reader.ReadLine());
                game.TableID = int.Parse(reader.ReadLine());
                game.PlayerID = (reader.ReadLine());
                game.Player2ID = (reader.ReadLine());
                game.Result = byte.Parse(reader.ReadLine());
                GameList.Add(game);
            }
            reader.Close();
        }
        // Updating the Game text file to all the changes present in the linked list
        public static void UpdateGameFile(Game g)
        {
            if (game_counter == 0) // If file is never updated before clear it's content
            {
                StreamWriter clear = new StreamWriter("Game.txt");
                clear.Flush();
                clear.Close();
            }
            // write the updated data
            StoreGameInfo(g);
            game_counter++;
        }

    }
}



