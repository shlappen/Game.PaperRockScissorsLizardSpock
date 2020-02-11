using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Herd
    {
        public List<Warrior> dinosaurs;
        public Herd()
        {
            dinosaurs = new List<Warrior>() { new Dinosaur("Stega", 80), new Dinosaur("Raptor", 80), new Dinosaur("TRex", 80) };
        }
    }
}
