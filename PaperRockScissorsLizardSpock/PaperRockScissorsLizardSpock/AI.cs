using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    class AI : Player
    {
        public AI()
        {
            name = "Computer";
        }

        public int RandomGenerator()
        {
            Random random = new Random();
            int result = random.Next(0, 5);
            return result;
        }

        public override int ChooseGesture()
        {
            Random random = new Random();
            int result = random.Next(0, 5);
            
            return result;
        }
    }
}
