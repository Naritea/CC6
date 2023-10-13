using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class MainGame
    {   
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to THE GAME!");
            Console.WriteLine("Please enter your name.");
            string playerName = Console.ReadLine();
            
        	Console.Clear();
        	
            Console.WriteLine("Your name is " + playerName);
            Console.WriteLine("");
            
            //player initialization
            int hp = rnd.Next(20, 35); //Health: 20 - 35
			int att = rnd.Next(5, 10); //Strength: 5 - 10
			int def = rnd.Next(0, 5); //Defense: 0 - 5
			int spd = rnd.Next(1, 10); //Speed: 1 - 10
			
			Player player = new Player(playerName, hp, att, def, spd);
			Console.WriteLine("Your Stats for this session:");
			Console.WriteLine("Health:" + player.currentHp);
			Console.WriteLine("Attack:" + player.att);
			Console.WriteLine("Defense:" + player.def);
			Console.WriteLine("Speed:" + player.spd);
			
            Console.WriteLine("Are you ready to begin..?");
			Console.ReadKey(true);
			
			Enemy enemy = enemyInit();
			battleLoop(player, enemy);
        }
        
        public static Enemy enemyInit()
    	{
			
			
			//Enemy Initialize
			int hp = rnd.Next(10, 25); //Health: 20 - 35
			int att = rnd.Next(2, 6); //Strength: 5 - 10
			int def = rnd.Next(0, 3); //Defense: 0 - 5
			int spd = rnd.Next(0, 5); //Speed: 1 - 10
			Enemy enemy = new Enemy(hp, att, def, spd);
			
			Console.Clear();
			Console.WriteLine("You encounter a " + enemy.name);
			Console.WriteLine("The battle has begun!");
			Console.ReadKey(true);
			Console.Clear();
			
			return enemy;
    	}
        
        public static void battleLoop(Player player, Enemy enemy)
        {
        	if (enemy.spd > player.spd) 
        		{
        			Console.WriteLine("The enemy moves first!");
	        	}
        	while (enemy.currentHp > 0 && player.currentHp > 0) 
        	{
        		if (enemy.spd > player.spd) 
        		{
        			player.currentHp -= enemy.enemyTurn();
	        	}
        		
	        	Console.WriteLine(player.playerName + ": \t\t\t" + enemy.name + ":");
				Console.WriteLine("HP: " + player.currentHp + "/" + player.maxHp + "\t\t" + "HP: " + enemy.currentHp + "/" + enemy.maxHp);
				Console.WriteLine("Att: " + player.att);
				Console.WriteLine("Def: " + player.def);
				Console.WriteLine();
				Console.WriteLine("Menu:");
				Console.WriteLine("1. Attack");
				Console.WriteLine("2. Heal");
				Console.WriteLine("3. Inventory");
				Console.WriteLine("4. IsAlive");
				string choice = Console.ReadLine();
				
				switch (choice)
	            {
	                case "1":
						Console.Clear();
						enemy.currentHp -= player.attackEnemy();
	                    break;
	                case "2":
	                    Console.Clear();
	                    player.currentHp = player.healSelf();
	                    break;
	                case "3":
	                    break;
	                case "4":
	                    player.isAlive();
	                    break;
	                default:
	                    Console.WriteLine("Invalid Choice!");
	                    Console.WriteLine("The enemy takes advantage of your indecision!");
	                    Console.ReadKey(true);
	                    break;
	            
            	}
				if (enemy.spd < player.spd && enemy.currentHp > 0) 
				{
        			player.currentHp -= enemy.enemyTurn();
        		}
        	}
        	if (enemy.currentHp < 0) 
        	{
        		victoryScreen(player);
        	}
        	else 
        	{
        		gameOver();
        	}
        }
        
        public static void gameOver()
    	{
        	Console.Clear();
        	Console.WriteLine("You've Died!");
        	Console.ReadKey(true);
        }
        public static void victoryScreen(Player player)
    	{
        	Console.Clear();
        	Console.WriteLine("You've defeated the enemy!");
        	Console.ReadKey(true);
        	Console.WriteLine("You move further into the Dungeon.");
        	Console.ReadKey(true);
        	Console.Clear();
        	Enemy enemy = enemyInit();
			battleLoop(player, enemy);
        }
    }
}