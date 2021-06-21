using System;

namespace OOP
{
    public class Vehicle
    {
        public int NumPassengers {get;set;}
        public string Color {get;set;}
        protected int Odometer;
        public Vehicle()
        {
            NumPassengers = 2;
        }
        public Vehicle(int val, string color)
        {
            NumPassengers = val;
            Color = color;
        }
        public void Honk()
        {
            Console.WriteLine("Car go BEEP!");
        }
        public void Honk(string noise)
        {
            Console.WriteLine($"Car go {noise}");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Numer of Passengers: {NumPassengers}");
            Console.WriteLine($"Color: {Color}");
        }
        // public void drive(int miles)
        // {
        //     Odometer += miles;
        //     Console.WriteLine($"Odometer now reads: {Odometer}");
        // }
    }
}