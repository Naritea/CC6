using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class Enemy
    {
        Random random = new Random();
        
        public int enemy_HP = random.Next(15,25);
        public int enemy_STR = random.Next(3,8);
        public int enemy_DEF = random.Next(0,3);

        public void Attack(string[] args)
        {   
            Player Plyr = new Player();
            Plyr.Health -= Plyr.Defense-Strength;
            
        }
        public void isAlive()
        {
            if(Health>0)
            {
                Console.WriteLine("The Enemy is still alive!!!")


            }
            else{
                Console.WriteLine("You have defeated the enemy!!!")
            }
        }
    }
}
