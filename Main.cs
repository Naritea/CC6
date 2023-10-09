using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax4
{
    class MainGame
    {   
         public int Turn = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to THE GAME!");
            Console.WriteLine("Please enter your name.");
            string playerName = Console.Readline();
            Console.Writeline("Your name is " + playerName);
        }
    }
}
