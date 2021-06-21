using System;

namespace OOP
{
    public class Car : Vehicle
    {
        public int doors {get;set;}

        public Car(int passengers, string color, int numDoors) : base(passengers, color)
        {
            doors = numDoors;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Doors: {doors}");
        }
        public void Drive(int miles)
        {
            Odometer += miles;
            Console.WriteLine($"Odometer now reads: {Odometer}");
        }

    }
}