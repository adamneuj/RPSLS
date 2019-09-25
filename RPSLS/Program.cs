using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game RPSLS = new Game();
            RPSLS.RunGame();

            //Display rules
            //Player One selects either human or computer player
            //Player Two selects either human or computer player
            //Player One picks either Rock, Paper, Scissors, Lizard, or Spock
            //Player Two picks either Rock, Paper, Scissors, Lizard, or Spock
            //Determine winner of round
            //Repeat until best two out of three
            //Display winner
        }
    }
}
