using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorsLizardSpock
{
    class Gestures
    {
        public List<Choice> choices;

        public Gestures()
        {
            choices = new List<Choice> 
            {   new Choice("Rock"), 
                new Choice("Paper"), 
                new Choice("Scissors"), 
                new Choice("Lizard"), 
                new Choice("Spock") 
            };
        }
    }
}
