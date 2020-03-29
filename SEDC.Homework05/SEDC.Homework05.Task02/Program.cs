using SEDC.Homework05.Task02.Classes;
using System;

namespace SEDC.Homework05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver Bob = new Driver()
            {
                 Name = "Bob",
                 Skill = 6
            };

            Driver Greg = new Driver()
            {
                Name = "Greg",
                Skill = 7
            };

            Driver Jill = new Driver()
            {
                Name = "Jill",
                Skill = 4
            };

            Driver Anne = new Driver()
            {
                Name = "Anne",
                Skill = 10
            };

            Car hyundai = new Car()
            {
                Model = "Tuscon",
                Speed = 170
            };

            Car Mazda = new Car()
            {
                Model = "Speed 6",
                Speed = 200
            };

            Car Ferrari = new Car()
            {
                Model = "488",
                Speed = 280
            };

            Car Porsche = new Car()
            {
                Model = "911",
                Speed = 250
            };

            Console.WriteLine("Choose a car: (hyundai/mazda/ferrari/porsche)");
            string firstChosenCar = Console.ReadLine();
            
        }
    }
}
