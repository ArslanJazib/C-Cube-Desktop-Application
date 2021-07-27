using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessaLayer
{
    public abstract class Person
    {
       
       protected string cnic;
       protected string name;

        public Person()
        {
            cnic = "Unknown";
            name = "Unknown";
        } 
        public Person (string cnic,string name)
        {
            this.cnic = cnic;
            this.name = name;
        }
        public string Cnic
        {
            set { cnic = value; }
            get { return cnic; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

       virtual public  string getData()
        {
            string data = "--------------------\n";
            data += "CNIC : " + this.cnic + "\n";
            data += "Name : " + this.name + "\n";
            return data;
        }
    }
}
