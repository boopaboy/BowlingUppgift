using BowlingUppgift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingUppgift.Entities
{
    public class Match
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        
        public void SimulateMatch()
        {
            var random = new Random();
            var p1Score = random.Next(100, 200);
            var p2Score = random.Next(100, 200);
            Winner = p1Score > p2Score ? Player1 : Player2;
        }
    }
}
