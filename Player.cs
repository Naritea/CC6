/*
 * Created by SharpDevelop.
 * User: Daryl
 * Date: 10/13/2023
 * Time: 3:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Syntax4
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Player
	{
		public string playerName;
		public int maxHp;
		public int currentHp;
		public int att;
		public int def;
		public int spd;
		public Random rnd = new Random();
		
		public Player(string name, int hp, int attack, int defense, int speed)
		{
			playerName = name;
			maxHp = hp;
			currentHp = hp;
			att = attack;
			def = defense;
			spd = speed;
		}
		public int attackEnemy()
    	{
			int newAttack = att + rnd.Next(-2, 4);
			Console.WriteLine(playerName + " deals " + newAttack + " damage to the enemy!");
			
			Console.ReadKey(true);
			Console.Clear();
			return newAttack;
    	}
		public int healSelf()
    	{
			int newHp = currentHp + Convert.ToInt32((currentHp *.2));
			Console.WriteLine(playerName + " prays for a blessing and heal for " + Convert.ToInt32((currentHp *.2)) + " HP!");
			
			Console.ReadKey(true);
			Console.Clear();
			if (newHp > maxHp) {
				newHp = maxHp;
			}
			return newHp;
    	}
		public void isAlive()
    	{
			Console.WriteLine(playerName + " checks if their heart is still beating... Fortunately, It still is!");
			
			Console.ReadKey(true);
			Console.Clear();
    	}
	}
}
