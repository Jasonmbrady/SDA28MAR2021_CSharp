using System;

namespace interfaces
{
    public class Horse : IRideable
    {
        public double DistanceTraveled {get;set;}
        public string Name {get;}
        public double Endurance {get;set;}
        public Horse(string name, double endurance)
        {
            Name = name;
            Endurance = endurance;
            DistanceTraveled = 0;
        }

        public void Ride(double distance)
        {
            if (distance > Endurance){
                distance = Endurance;
            }
            DistanceTraveled += distance;
            Console.WriteLine($"Giddyup! You traveled {distance} km for a total of {DistanceTraveled}");
        }
    }
}
