using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    class Human : Player
    {
        public Human()
        {


        }



        public override int ChooseGesture()
        {
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + choices[i].name);
            }
            Console.WriteLine();
            bool isValid = false;
            int choice = 0;
            do
            {
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        choice = 0;
                        isValid = true;
                        break;
                    case "2":
                        choice = 1;
                        isValid = true;
                        break;
                    case "3":
                        choice = 2;
                        isValid = true;
                        break;
                    case "4":
                        choice = 3;
                        isValid = true;
                        break;
                    case "5":
                        choice = 4;
                        isValid = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a number 1 through 4 to select a gesture");
                        break;
                }
            } while (isValid == false);
            return choice;
        }
    }
}
