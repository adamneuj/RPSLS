using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        // member variables

        // constructor
        public Human()
        {
            score = 0;
            name = null;
        }
        // member methods
        public override void EnterName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }
    }
}
