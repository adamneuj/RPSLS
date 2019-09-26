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
        public string gesture;

        // constructor
        public Computer()
        {

        }
        // member methods
        public int GenerateRandom() 
        {
            Random random = new Random();
            int randomGesture = random.Next(0, 5);
            return randomGesture;
        }
    }
}
