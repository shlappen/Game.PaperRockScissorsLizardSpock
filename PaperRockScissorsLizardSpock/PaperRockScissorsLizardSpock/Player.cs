using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    abstract class Player
    {
        public int score;
        public string name;

        public abstract void ChooseGesture(Choice choices);
    }
}

