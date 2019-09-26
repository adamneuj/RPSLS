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
        }
        // member methods
        public override void EnterName()
        {
            name = "Computer";
        }
    }
}
