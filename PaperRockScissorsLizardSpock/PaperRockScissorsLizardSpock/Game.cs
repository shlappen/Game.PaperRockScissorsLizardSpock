using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    class Game
    {
        Player player1;
        Player player2;


        public Game()
        {

        }

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("Rock beats Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }


        public string GetNumberOfPlayers()
        {
            bool isValid = false;
            string numberOfPlayers = "";
            do
            {
                Console.WriteLine("Press 1 to play against the computer. Press 2 to play against a friend. Press 3 to run a computer-versus-computer simulation.");
                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        numberOfPlayers = "1";
                        isValid = true;
                        break;
                    case "2":
                        numberOfPlayers = "2";
                        isValid = true;
                        break;
                    case "3":
                        numberOfPlayers = "3";
                        isValid = true;
                        break;
                    default:
                        break;
                }
            } while (isValid == false);
            return numberOfPlayers;

        }
        public void SetNumberOfPlayers(string numberOfPlayers)
        {
            numberOfPlayers = GetNumberOfPlayers();
            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new AI();
                Console.WriteLine("Player 1, please enter your name.");
                player1.name = Console.ReadLine();
                Console.WriteLine();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
                Console.WriteLine("Player 1, please enter your name.");
                player1.name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Player 2, please enter your name.");
                player2.name = Console.ReadLine();
                Console.WriteLine();
            }
            else
            {
                player1 = new AI()
                {
                    name = "Computer 1"
                };
                player2 = new AI()
                {
                    name = "Computer 2"
                };

            }
        }

        public void CompareChoices(int player1Choice, int player2Choice)
        {
            Console.WriteLine("{0} chose {1}!", player1.name, player1.choices[player1Choice].name);
            Console.WriteLine("{0} chose {1}!", player2.name, player2.choices[player2Choice].name);
            Console.WriteLine();
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("It's a tie!");
            }

            else if (((player1Choice == 0 && (player2Choice == 2 || player2Choice == 3))
                || ((player1Choice == 1) && (player2Choice == 0 || player2Choice == 4))
                    || ((player1Choice == 2) && (player2Choice == 1 || player2Choice == 3))
                        || ((player1Choice == 3) && (player2Choice == 1 || player2Choice == 4)))
                            || ((player1Choice == 4) && (player2Choice == 2) || player2Choice == 0))
            {
                player1.score++;
                Console.WriteLine("{0} wins this round!", player1.name);
                Console.WriteLine();
            }
            else
            {
                player2.score++;
                Console.WriteLine("{0} wins this round!", player2.name);
                Console.WriteLine();
            }
        }

        public void DisplayScores()
        {
            Console.WriteLine("Scores:");
            Console.WriteLine("{0}: {1}", player1.name, player1.score);
            Console.WriteLine("{0}: {1}", player2.name, player2.score);
            Console.ReadLine();
            Console.WriteLine();
        }

        public void DisplayGameWinner()
        {
            if (player1.score > player2.score)
            {
                Console.WriteLine("{0} WINS!", player1.name);
            }
            if (player2.score > player1.score)
            {
                Console.WriteLine("{0} WINS!", player2.name);
            }

            Console.WriteLine("Do you want to play again? Press Y for yes and N for no.");
            bool isValid = false;
            do
            {
                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "Y":
                    case "y":
                    case "yes":
                    case "Yes":
                        RunGame();
                        break;
                    case "N":
                    case "n":
                    case "no":
                    case "No":
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Do you want to play again? Press 'Y' for Yes and 'N' for No.");
                        break;
                }
            } while (isValid == false);

        }
        
        


        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine();
            DisplayRules();
            Console.WriteLine();
            SetNumberOfPlayers("");
            do
            {
                if (player1.name != "Computer 1")
                {
                    Console.WriteLine("{0}, please choose a gesture using 1 through 5.", player1.name);
                }
                int player1Choice = player1.ChooseGesture();
                Console.ReadLine();
                if (player2.name != "Computer 2" || player2.name == "Computer")
                {
                    Console.WriteLine("{0}, please choose a gesture using 1 through 5.", player2.name);
                }
                int player2Choice = player2.ChooseGesture();
                CompareChoices(player1Choice, player2Choice);
                DisplayScores();
            } while (player1.score < 2 && player2.score < 2);
            DisplayGameWinner();
            Console.ReadLine();
                




        }

    }
}
