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
            Console.WriteLine("Please choose your gesture.");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(i + ") " + choices[i].name);
            }

            int result = 0;
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Please only enter 0-4!");
                return ChooseGesture();
            }

            return result;
            //do
            //{
            //    string input = Console.ReadLine();
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (input)
            //    {
            //        case "0":
            //            gesture = choices[0];
            //            isValid = true;
            //            break;
            //        case "1":
            //            gesture = choices[1];
            //            isValid = true;
            //            break;
            //        case "2":
            //            gesture = choices[2];
            //            isValid = true;
            //            break;
            //        case "3":
            //            gesture = choices[3];
            //            isValid = true;
            //            break;
            //        case "4":
            //            gesture = choices[4];
            //            isValid = true;
            //            break;

            //        default:
            //            break;
            //    }
            //} while (isValid == false);
            //return gesture;

        }
    }
}
