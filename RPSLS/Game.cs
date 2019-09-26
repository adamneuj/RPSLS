using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public int winRounds = 2;
        string tempString;

        //constructor
        public Game()
        {

        }


        //member methods (CAN DO)
        public void RunGame()
        {
            DisplayRules();
            Console.WriteLine("Enter each player.  Type computer for a computer player.");
            PlayerSelect();
            GamePlayLoop();
            Console.ReadLine();

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

        public void PlayerSelect()
        {
            Console.WriteLine("Player One: ");
            tempString = Console.ReadLine();
                if(tempString == "computer")
                {
                    playerOne = new Computer();
                }
                else
                {
                    playerOne = new Human();
                    playerOne.name = tempString;
                }

            Console.WriteLine("Player Two: ");
            tempString = Console.ReadLine();
                if(tempString == "computer")
                {
                    playerTwo = new Computer();
                }
                else
                {
                    playerTwo = new Human();
                    playerTwo.name = tempString;
                }

        }

        public void StringValidation()
        {

            while (tempString == "" || tempString == null)
            {
                Console.WriteLine("Invalid input.  Please enter again.");
                tempString = Console.ReadLine();
            }
        }

        public void GamePlayLoop()
        {
            while (winRounds >= playerOne.score && winRounds >= playerTwo.score)
            {
                Console.WriteLine(playerOne.name + " choose:");
                playerOne.ChooseGesture();
                Console.WriteLine(playerTwo.name + " choose:");
                playerTwo.ChooseGesture();
                DetermineRound();
                DisplayScore();
            }
        }

        public void DetermineRound()
        {
            if (playerOne.gesture == "rock" && (playerTwo.gesture == "lizard" || playerTwo.gesture == "scissors"))
            {
                Console.WriteLine(playerOne.name + " wins this round.");
                playerOne.score++;
            }
            else if(playerOne.gesture == "paper" && (playerTwo.gesture == "rock" || playerTwo.gesture == "spock"))
            {
                Console.WriteLine(playerOne.name + " wins this round.");
                playerOne.score++;
            }
            else if(playerOne.gesture == "scissors" && (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard"))
            {
                Console.WriteLine(playerOne.name + " wins this round.");
                playerOne.score++;
            }
            else if (playerOne.gesture == "lizard" && (playerTwo.gesture == "spock" || playerTwo.gesture == "scissors"))
            {
                Console.WriteLine(playerOne.name + " wins this round.");
                playerOne.score++;
            }
            else if (playerOne.gesture == "spock" && (playerTwo.gesture == "rock" || playerTwo.gesture == "scissors"))
            {
                Console.WriteLine(playerOne.name + " wins this round.");
                playerOne.score++;
            }
            else if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Round tie. No point given.");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins this round.");
                playerTwo.score++;
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine("Score:");
            Console.WriteLine(playerOne.name + ": " + playerOne.score);
            Console.WriteLine(playerTwo.name + ": " + playerTwo.score);
            Console.WriteLine();
        }
    }
}
