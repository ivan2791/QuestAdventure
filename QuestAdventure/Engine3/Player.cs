using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3
{
   public class Player:Creature
    {
      
        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public Player(int gold, int xp, int level, int cHP, int mHP) : base(cHP,mHP)
        {
           Gold = gold;
            XP = xp;
            Level = level;
        }

    }
}
