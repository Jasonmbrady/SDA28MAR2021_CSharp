using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike(10, 1);
            Horse mrEd = new Horse("Mr. Ed", 300);
            IRideable[] myRideables = new IRideable[]
            {
                myBike,
                mrEd
            };
            foreach(IRideable rideable in myRideables)
            {
                rideable.Ride(50);
            }
        }
    }
}
