﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3
{
    public class Quest
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public int RewardGold { get; set; }
        public int RewardXP { get; set; }
      public Quest(int id, string Name,string description,int gold,int xp)
        {
            ID = id;
            name = Name;
            Description = description;
            RewardGold = gold;
            RewardXP = xp;
        }
    }
}
