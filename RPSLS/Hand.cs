using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Hand
    {
        // member variables
        public List<string> gestures = new List<string>();
        public int computerGesture;
        public string humanGesture;

        // constructor
        public Hand()
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
            computerGesture = 0;
            humanGesture = null;
        }

        // member methods
    }
}
