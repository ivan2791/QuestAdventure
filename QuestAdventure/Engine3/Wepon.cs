using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3
{
  public  class Wepon:Item
    {
     
        public int Damage { get; set; }
        public Wepon(int id,string Name,int damage):base(Name,id)
        {
            Damage = damage;
        }
    }
}
