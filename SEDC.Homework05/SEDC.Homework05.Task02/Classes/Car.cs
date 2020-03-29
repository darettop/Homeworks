using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05.Task02.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver theDriver { get; set; }

        public int CalculateSpeed()
        {
            int calculatedSpeed = theDriver.Skill * this.Speed;
            return calculatedSpeed;
        }

        public void RaceCars(Car carOne, Car carTwo)
        {
            if(carOne.CalculateSpeed() > carTwo.CalculateSpeed())
            {
                Console.WriteLine(carOne + "was faster.");
            }
            else
            {
                Console.WriteLine(carTwo + "was faster.");
            }
            
        }


    }
}
