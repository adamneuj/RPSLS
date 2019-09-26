using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        // member variables

        // constructor
        public Computer()
        {
            score = 0;
            gesture = null;
            name = "Computer";
        }
        // member methods
        public static int GenerateRandom() 
        {
            Random random = new Random();
            int randomGesture = random.Next(0, 5);
            return randomGesture;
        }

        public override string ChooseGesture()
        {
            int resultRandom = GenerateRandom();
            Hand hand = new Hand();
            gesture = hand.gestures[resultRandom];
            Console.WriteLine(gesture);
            Console.WriteLine();
            return gesture;
        }
    }
}
