﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (HAS A)


        //constructor
        public Game()
        {

        }


        //member methods (CAN DO)

        public void RunGame()
        {
            DisplayRules();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("First you will select whether each player will be either a human player or computer player.");
            Console.WriteLine("Then each player will pick Rock, Paper, Scissors, Lizard, or Spock.");
            Console.WriteLine("Rock crushes Scissors and Lizard.");
            Console.WriteLine("Paper covers Rock and disproves Spock.");
            Console.WriteLine("Scissors cuts Paper and decapitates Lizard.");
            Console.WriteLine("Lizard eats Paper and poisons Spock.");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock.");
            Console.WriteLine("Press ANY KEY when ready to start game.");
            Console.ReadLine();
        }
    }
}
