using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class Player
    {      
        Random random = new Random();
        
        public int Health = random.Next(20,35);
        public int Strength = random.Next(5,10);
        public int Defense = random.Next(0,5);
        private int Crit = random.Next(0,20)

        public void Attack(string[] args)
        {   
            Enemy Emy = new Enemy();
            if (Crit>=16)
            {
                int Damage = Strength x 2;
                Emy.Health -= Emy.Defense-Damage;
            }
            else()
            {
                Emy.Health -= Emy.Defense-Strength;
            }
            
        }
        public void Heal()
        {
            Health =+ Health * 0.20;
        }
        public void isAlive()
        {
            if(Health>0)
            {
                Console.WriteLine("The You're still alive!!!");


            }
            else{
                Console.WriteLine("YOU DIED");
            }
        }
    }
}
