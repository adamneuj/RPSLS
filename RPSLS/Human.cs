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
            gesture = ChooseGesture();
            name = null;
        }
        // member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock?");
            gesture = Console.ReadLine();
            return gesture;
        }
    }
}
