using BowlingUppgift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingUppgift.Factory
{

    public static class MatchFactory
    {
    
        public static Match Create(Player p1, Player p2) => new Match
        {
            Player1 = p1,
            Player2 = p2
        };


    }
}
