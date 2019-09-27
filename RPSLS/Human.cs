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
            gesture = null;
            name = null;
        }
        // member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock?");
            gesture = Console.ReadLine();
            ValidationLoop();
            Console.Clear();
            return gesture;
        }

        public void ValidationLoop()
        {
            Hand validHand = new Hand();
            bool validSwitch = false;
            for (int i = 0; i < validHand.gesturesCount; i++)
            {
                if (gesture == validHand.gestures[i])
                {
                    validSwitch = true;
                }
                else if (gesture != validHand.gestures[i])
                {
                    continue;
                }
                else if (validSwitch == true)
                {
                    continue;
                }
            }
            if (validSwitch == false)
            {
                Console.WriteLine("Invalid input.");
                ChooseGesture();
            }
        }

    }
}
