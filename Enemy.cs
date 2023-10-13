/*
 * Created by SharpDevelop.
 * User: Daryl
 * Date: 10/13/2023
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Syntax4
{
	/// <summary>
	/// Description of Enemy.
	/// </summary>
	public class Enemy
	{
		static Random rnd = new Random();
		public int ID = rnd.Next(0,3);
		public int enemyID;
		public string name;
		public int maxHp;
		public int currentHp;
		public int att;
		public int def;
		public int spd;
		public int healCooldown = 3;
		
		
		public string[] enemyNames = {"Goblin Scout", "Green Slime", "Zombie", "Harpy"};
		public string[] enemyAttacks = {"Smacks you with their club", "Digests you", "Claws at you", "Uses her talons to scratch you"};
		public string[] enemyHeals = {"has their fellow goblins lick their wounds", "sits still", "consumes a pocketed brain", "perches high up and rests"};
		
		public Enemy(int hp, int attack, int defense, int speed)
		{
			enemyID = ID;
			name = enemyNames[enemyID];
			maxHp = hp;
			currentHp = hp;
			att = attack;
			def = defense;
			spd = speed;
		}
		public int enemyTurn()
    	{
			healCooldown--;
			if (healCooldown == 0) {
				healCooldown = 3;
				currentHp = enemyHeal();
				return 0;
			}
			else{
				int turnResult = enemyAttack();
				return turnResult;
			}
    	}
		public int enemyAttack()
    	{
			int newAttack = att + rnd.Next(-4, 2);
			
			if (newAttack <= 0) {
				newAttack = 1;
			}
			
			Console.WriteLine(name + " " + enemyAttacks[ID] + ", dealing " + newAttack + " damage!");
			
			Console.ReadKey(true);
			Console.Clear();
			return newAttack;
    	}
		public int enemyHeal()
    	{
			int newHp = currentHp + Convert.ToInt32((currentHp *.2));
			Console.WriteLine(name + " " + enemyHeals[ID] + ", healing for " + Convert.ToInt32((currentHp *.2)) + " HP!");
			Console.ReadKey(true);
			Console.Clear();
			
			if (newHp > maxHp) {
				newHp = maxHp;
			}
			return newHp;
    	}
	}
}
