using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Dinosaur : Warrior
    {
        public int energy;
        public Dinosaur(string name, int energy)
        {
            this.name = name;
            this.energy = energy;
            health = 100;
            attackPower = new Random().Next(10, 99);
        }

        public override void Attack(Warrior robot)
        {
            robot.health -= attackPower;
        }
    }
}
