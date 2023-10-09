using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class Item
    {
        public int stats = random.Next(5,10);
        public string potionSmall = "Small Potion";
        public string potionLarge = "Large Potion";
        public string biscuitSmall = "Small Biscuit";
        public string biscuitLarge = "Large Biscuit";
        
        public Dictionary<string, int> items = new Dictionary<string, int>();

        public Items(itemName, itemStats){
            items. add(itemName, itemStats);
        }

        public static StrengthBuffs()
        {
            int value = random.Next(5,10);
            Console.WriteLine(value);
        }

        public static DefenseBuffs()
        {
            int value = random.Next(5,10)
            Console.WriteLine(value);
        }
    }
}
