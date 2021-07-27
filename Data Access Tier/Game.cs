using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessaLayer
{
    public class Game
    {
        int gameID;
        int tableID;
        string playerID;
        string player2ID;
        byte result;

        public Game()
        {
            gameID = -1;
        }

        public Game(int gid, int tid, string p1id, string p2id, byte result)
        {
            this.gameID = gid;
            this.TableID = tid;
            this.playerID = p1id;
            this.Player2ID = p2id;
            this.result = result;
        }
        public int GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        public string PlayerID
        {
            get
            {
                return playerID;
            }

            set
            {
                playerID = value;
            }
        }

        public string Player2ID
        {
            get
            {
                return player2ID;
            }

            set
            {
                player2ID = value;
            }
        }

        public byte Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        public string getData()
        {
            string data;
            data  = "Game ID : " + this.gameID + "\n";
            data += "Table ID: " + this.tableID + "\n";
            data += "Player 1 ID: " + this.playerID + "\n";
            data += "Player 2 ID: " + this.Player2ID + "\n";
            data += "Result: " + this.result + "\n";
            return data;
        }
    }
}
