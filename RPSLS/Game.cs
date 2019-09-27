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
        public int winRounds;
        string tempString;

        //constructor
        public Game()
        {
            winRounds = 2;
        }


        //member methods (CAN DO)
        public void RunGame()
        {
            StandardMessages.DisplayRules();
            PlayerSelect();
            GamePlayLoop();
            DisplayWinner();
            Console.ReadLine();

        }

        public void PlayerSelect()
        {
            StandardMessages.EnterEachPlayer();
            StandardMessages.PlayerOne();
            tempString = Console.ReadLine();
            StringValidation();
                if(tempString == "computer")
                {
                    playerOne = new Computer();
                }
                else
                {
                    playerOne = new Human();
                    playerOne.name = tempString;
                }
            Console.WriteLine();
            StandardMessages.PlayerTwo();
            tempString = Console.ReadLine();
            StringValidation();
                if (tempString == "computer")
                {
                    playerTwo = new Computer();
                }
                else
                {
                    playerTwo = new Human();
                    playerTwo.name = tempString;
                }
            Console.Clear();
        }

        public void StringValidation()
        {
            string validString = tempString;
            validString = validString.Replace(" ", string.Empty);
            while (validString == "" || validString == null)
            {
                Console.WriteLine("Invalid input.  Please enter Player again.");
                tempString = Console.ReadLine();
            }
        }


        public void GamePlayLoop()
        {
            while (winRounds != playerOne.score && winRounds != playerTwo.score)
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
            DisplayGestures();
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
            Console.WriteLine(playerOne.name + ": " + playerOne.score);
            Console.WriteLine(playerTwo.name + ": " + playerTwo.score);
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayWinner()
        {
            if (playerOne.score == winRounds)
            {
                Console.WriteLine(playerOne.name + " wins the game!");
                PlayAgain();
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins the game!");
                PlayAgain();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Play again?");
            string yesNo = Console.ReadLine();
            if (yesNo == "yes")
            {
                ScoreReset();
                Console.Clear();
                RunGame();
            }
        }

        public void ScoreReset()
        {
            playerOne.score = 0;
            playerTwo.score = 0;
        }

        public void DisplayGestures()
        {
            Console.WriteLine(playerOne.name + " chose: " + playerOne.gesture);
            Console.WriteLine(playerTwo.name + " chose: " + playerTwo.gesture);
            Console.WriteLine();
        }

    }
}
