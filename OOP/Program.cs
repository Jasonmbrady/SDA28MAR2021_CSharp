using System;
using System.Collections.Generic;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            myVehicle.NumPassengers = 4;
            // Console.WriteLine(myVehicle.NumPassengers);
            // myVehicle.Honk();
            // myVehicle.Honk("awoooooooga");
            Car myCar = new Car(4, "blue", 4);
            myCar.GetInfo();
            myCar.Drive(100);
            myCar.Drive(10);
            List<Vehicle> myList = new List<Vehicle>();
            myList.Add(myVehicle);
            myList.Add(myCar);
        }
    }
}
