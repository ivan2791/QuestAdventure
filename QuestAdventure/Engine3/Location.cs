using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3
{
  public  class Location
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Item item { get; set; }
        public Monster monster { get; set; }
        public Quest Quest { get; set; }


        public Location(int id,string Name,Item itm,Monster monstr,Quest Ques)
        {
            ID = id;
            name = Name;
            item = itm;
            monster = monstr;
            Quest = Ques;
        }

    }
}
