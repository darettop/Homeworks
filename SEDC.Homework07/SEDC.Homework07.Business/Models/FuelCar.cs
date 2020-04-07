﻿using System;
using System.Collections.Generic;
using System.Text;
using SEDC.Homework07.Enumeration;

namespace SEDC.Homework07.Business.Models
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType, int fuelCapacity, int  currentFuel)
            :base(brand, model, doors, topSpeed, consumption, engineType)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }
        public void Refuel(int fuel)
        {
            int emptyTankCapacity = FuelCapacity - CurrentFuel;
            if (emptyTankCapacity < fuel)
            {
                Console.WriteLine($"Cant refuel more than {emptyTankCapacity}");              
            }
            else
            {
                Console.WriteLine($"Refueled the car with {fuel} liters.");
                while (fuel > 0)
                {
                    CurrentFuel++;
                    fuel--;
                }
                
            }
            
        }
     
    }
}
