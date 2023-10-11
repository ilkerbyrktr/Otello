using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otello
{
    internal class Eleman
    {

        private string name;
        private string surname;
        private int iD;
        

        public Eleman(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            
        }

        public string Name { get { return name; } set { this.name = name; } }
        public string Surname { get { return surname; } set { this.surname = surname; } }
        public int ID { get { return iD; } }
        
    }
    
}
