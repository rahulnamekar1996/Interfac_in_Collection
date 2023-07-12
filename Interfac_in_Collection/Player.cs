using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_in_Collection
{
    public class Player
    {
        public int runs;
        public string name;

        public Player(int runs,string name)
        {
            this.runs = runs;
            this.name = name;

        }
    
    
        public override string ToString()
        { 
            return $"runs{runs} name{name}";

 
        
        }
    }

    public class Team : IEnumerable

    {
        Player[] players;
        public Team()
        {
            players = new Player[3];
            players[0] = new Player(1200, "sachin");
            players[1] = new Player(1300, "rahul");
        }

        public IEnumerator GetEnumerator()
        {
           return players.GetEnumerator();
        }
    }
}


