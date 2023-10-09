using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class Inventory
    {
        List<Item> Inv = new List<Item>();
        

        public static addItem()
        {
            Item potion = new Item();
            Inv.Add(item);
        }
        
        public static useItem()
        {
            
        }
      
        static List getItem(List<Item> Inv)
        {
            for(int i=0;i<Inv.Count;i++)
            {
                Console.WriteLine(Inv[i].name);
            }
            return Inv;
        }
    }
}
