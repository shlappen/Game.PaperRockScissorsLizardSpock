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
                Console.WriteLine("Press 1 to play against the computer.  Press 2 to play against a friend.");
                string input = Console.ReadLine();
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
                Console.WriteLine("Player 1, please enter your name");
                player1.name = Console.ReadLine();


            }
            else
            {
                player1 = new Human();
                player2 = new Human();
                Console.WriteLine("Player 1, please enter your name");
                player1.name = Console.ReadLine();
                Console.WriteLine("Player 2, please enter your name");
                player2.name = Console.ReadLine();
            }
        }









        public void CompareChoices(//choice 1, choice 2)
            )
        {

        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine();
            DisplayRules();
            Console.WriteLine();
            SetNumberOfPlayers("");
            player1.ChooseGesture();

  
            

        }

    }
}
