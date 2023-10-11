using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class Inventory
    {
        public IDictionary<string, int> Inv = new Dictionary<string, int>();
        public IDictionary<string, int> itemTypes = new Dictionary<string, int>();
        itemTypes.Add("Small Potion", 25); //numbers are the % increase in stats
        itemTypes.Add("Large Potion", 50);
        itemTypes.Add("Small Biscuit", 25);
        itemTypes.Add("Large Biscuit", 50);

    }
    public void addItem()
    {
        Console.WriteLine("What item would you like to add?");
        Console.WriteLine("1. Small Potion");
        Console.WriteLine("2. Large Potion");
        Console.WriteLine("3. Small Biscuit");
        Console.WriteLine("4. Large Biscuit");
        Console.ReadLine();

    }

    public void useItem()
    {

    }

    public void getItem()
    {
        foreach (var kvp in itemTypes)
        {
        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }
}