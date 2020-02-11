using System;

namespace RobosvsDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.SimulateBattle();
            Console.ReadLine();
        }
    }
}
