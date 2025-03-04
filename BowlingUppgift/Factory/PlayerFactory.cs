using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingUppgift.Entities;

namespace BowlingUppgift.Factory
{
    public static class PlayerFactory

    {

        //Här använder vi Factory Pattern för att instansiera ett Player objekt.

        public static Player CreatePlayer(string name) => new Player(name);
    }
}
