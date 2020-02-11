using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    abstract class Warrior
    {
        public int health;
        public int attackPower;
        public string name;
        public abstract void Attack(Warrior warrior);
    }
}
