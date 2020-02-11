using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Weapon
    {
        public string type;
        public int attackPower;
        public Weapon(string type, int attackPowerPassed)
        {
            this.type = type;
            attackPower = attackPowerPassed;
        }
    }
}
