using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Fleet
    {
        public List<Warrior> robots;
        public Fleet()
        {
            robots = new List<Warrior>() { new Robot("BB8"), new Robot("R2D2"), new Robot("C3PO") };
        }
    }
}
