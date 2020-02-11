using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Robot : Warrior
    {
        public Weapon weapon;
        public Robot(string name)
        {
            this.name = name;
            weapon = new Weapon("Gun", 25);
            health = 100;
            attackPower = 70;
        }

        public override void Attack(Warrior dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }
    }
}
