using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessaLayer
{
    public class Player:Person
    {
        uint totalGamesPlayed;
        uint totalGamesLost;
        uint totalGamesWon;
        
        public Player() { }

        public Player(string cnic ,string name,uint totalGamesPlayed =0, uint totalGamesLost=0, uint totalGamesWon=0):base(cnic,name)
        {
            this.totalGamesPlayed = totalGamesPlayed;
            this.totalGamesWon = totalGamesWon;
            this.totalGamesLost = totalGamesLost;

        }
        public uint TotalGamesPlayed
        {
            set { totalGamesPlayed = value; }
            get { return totalGamesPlayed; }
        }
        public uint TotalGamesLost
        {
            set { totalGamesLost = value; }
            get { return totalGamesLost; }
        }
        public uint TotalGamesWon
        {
            set { totalGamesWon = value; }
            get { return totalGamesWon; }
        }
        public override string getData()
        {
            string data = base.getData();
            data += "Total Games Played : " + this.totalGamesPlayed + "\n";
            data += "Total Games Lost: " + this.totalGamesLost + "\n";
            data += "Total Games Won: " + this.totalGamesWon + "\n";
            return data;
        }
    }
}
