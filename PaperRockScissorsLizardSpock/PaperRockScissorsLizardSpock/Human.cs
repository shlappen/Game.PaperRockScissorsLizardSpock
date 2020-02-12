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



        public override void ChooseGesture()
        {
            Console.WriteLine("Using the numbers below, please choose your secret gesture");
            for (int i = 0; i < choices.Count; i++) 
            {
                Console.WriteLine(i + ") " + choices[i].name);
                //}

                //write line choose gesture
                // 
                // gesture = console read line
                //var input = Console.ReadKey();
                //switch (input.Key)
                //{
                //    case ConsoleKey.NumPad0:

                //        break;
                //    default:
                //}

            }
        //{
        //    Console.WriteLine("Please choose your secret gesture");
        //    for(int i = 0; i < )
        //    Console.ReadLine();
        //    switch (response)
        //    {
        //        default:
        //            break;
        //    }
        //}

        }
    }
}
