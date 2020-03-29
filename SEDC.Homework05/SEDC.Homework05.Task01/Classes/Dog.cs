using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05.Task01.Classes
{
    public class Dog
    {
        public string name { get; set; }
        public string race { get; set; }
        public string color { get; set; }

        public string Eat()
        {
            return "The dog is now eating.";
        }

        public string Play()
        {
            return "The dog is now playing.";
        }

        public string ChaseTail()
        {
            return "The dog is now chasing its tail.";
        }
    }

}
