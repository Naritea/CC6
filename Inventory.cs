/*
 * Created by SharpDevelop.
 * User: Daryl
 * Date: 10/13/2023
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
	
namespace Syntax4
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Inventory
	{
		public static List<Item> Inv = new List<Item>();
		public Inventory()
		{
			Item item = new Item(0);
			Inv.Add(item);
			item = new Item(2);
			Inv.Add(item);
		}
		public Player inventoryMenu(Player player)
    	{
			Console.WriteLine("You begin to rummage through your pack.");
			Console.WriteLine("1. View Pack");
			Console.WriteLine("2. Use an item");
			Console.WriteLine("3. Pray for an item");
			string choice = Console.ReadLine();
			switch (choice)
            {
                case "1":
					Console.Clear();
					viewInventory();
                    break;
                case "2":
                    Console.Clear();
					player = useItem(player);
                    break;
                case "3":
                    addItem();
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine("The enemy takes advantage of your indecision!");
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
			}
			return player;
		}
		public void viewInventory()
    	{
			Console.WriteLine("You check if everything is accounted for in your bag...");
			Console.WriteLine("");
			for (var i = 0; i < Inv.Count; i++) 
			{
				Console.WriteLine((i+1) + ". " + Inv[i].itemName);
			}
			Console.ReadKey(true);
			Console.Clear();
		}
		public void addItem()
    	{
			Console.Clear();
			Console.WriteLine("Select an item you'd like to pray for:");
			Console.WriteLine("1. Small Biscuit");
			Console.WriteLine("2. Large Biscuit");
			Console.WriteLine("3. Small Potion");
			Console.WriteLine("4. Big potion");
			string choice = Console.ReadLine();
			try 
			{
				Console.Clear();
				int result = Int32.Parse(choice);
				Item item = new Item(result-1);
				Console.WriteLine("You pray to your gods for a " + item.itemName);
				Console.WriteLine("Your bag becomes a little heavier.");
				Console.ReadKey(true);
				Console.Clear();
				
				Inv.Add(item);
			} 
			catch (Exception)
			{
				Console.WriteLine("Invalid Choice!");
                Console.WriteLine("The enemy takes advantage of your indecision!");
                Console.Clear();
			}
		}
		public Player useItem(Player player)
    	{
			Console.WriteLine("You look into your bag for something that can help you!");
			Console.WriteLine("");
			
			for (var i = 0; i < Inv.Count; i++) 
			{
				Console.WriteLine((i+1) + ". " + Inv[i].itemName);
			}
			
			Console.WriteLine("");
			Console.WriteLine("Which item do you use?");
			
			string choice = Console.ReadLine();
			try 
			{
				Console.Clear();
				int result = (Int32.Parse(choice))-1;
				Item item = new Item(result);
				Console.WriteLine("You bring out your " + Inv[result].itemName + " and use it!");
				if (Inv[result].itemEffect.Equals("strBuff"))
				{
					Console.WriteLine("You feel more powerful, your next attack will hurt " + 100*Inv[result].itemStrength + "% more!");
					player.strBuff += Convert.ToInt32((Inv[result].itemStrength)*player.att);
					Console.WriteLine("+"+Convert.ToInt32((Inv[result].itemStrength)*player.att)+ " damage");
					Inv.RemoveAt(result);
				}
				else
				{
					int heal = Convert.ToInt32(Inv[result].itemStrength*player.maxHp);
						
					Console.WriteLine("The potion reinvigorates you, you heal for " + heal + " HP");
					player.currentHp += heal;
					if (player.currentHp > player.maxHp) 
					{
						player.currentHp = player.maxHp;
					}
					Inv.RemoveAt(result);
				}
				Console.ReadKey(true);
				Console.Clear();
				
			}		
			catch (Exception)
			{
				Console.WriteLine("Invalid Choice!");
                Console.WriteLine("The enemy takes advantage of your indecision!");
                Console.Clear();
			}
			return player;	
		}
		public void itemDrop()
    	{
			
		}
	}
}
