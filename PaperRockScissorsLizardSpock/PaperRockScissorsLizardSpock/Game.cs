using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    class Game
    {
        Human player1;
        Human player2;
        AI computer;
        Gestures gestures;

         
        public Game()
        {
            player1 = new Human();
            player2 = new Human();
            computer = new AI();
            gestures = new Gestures();
        }

        public void Turn(Player player)
        {

        }

        public void DisplayGestureOptions()
        {
            Console.WriteLine("Using the numbers below, please choose your secret gesture");
            for (int i = 0; i < gestures.choices.Count; i++)
            { Console.WriteLine(i + ") " + gestures.choices[i].name);
            }

        }

        public void RunGame()
        {
            DisplayGestureOptions();
        }

    }
}
