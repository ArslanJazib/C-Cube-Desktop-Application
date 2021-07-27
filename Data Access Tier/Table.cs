using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessaLayer
{
    public class Table
    {
        int tableID;
        bool check;

        public Table() { }
        public int TableID
        {
            get { return tableID; }
            set
            {
                    tableID = value;   
            }
        }
        public bool Check
        {
            get { return check; }
            set { check = value; }
        }

    }
}
