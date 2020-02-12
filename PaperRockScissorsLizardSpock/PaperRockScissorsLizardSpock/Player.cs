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
        public List<Gesture> choices;

        public Player()
        {
            choices = new List<Gesture>()
            {
                new Gesture("Paper"),
                new Gesture("Rock"),
                new Gesture("Scissors"),
                new Gesture("Lizard"),
                new Gesture("Spock")
            };
        }

        //class List
        //{
        //    public List<Gesture> choices;
        //    public List()
        //    { choices = new Gesture("Rock"),
        //        }
        //}



        public abstract void ChooseGesture();
    }
}

