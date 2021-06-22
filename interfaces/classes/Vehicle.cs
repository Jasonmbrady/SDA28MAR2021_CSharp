using System;

namespace interfaces
{
    public abstract class Vehicle
    {
        public int NumPassengers {get;set;}
        public string Color {get;set;}

        public Vehicle(int numPass){
            NumPassengers = numPass;
        }
    }
}