using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello.");
        }
        public static string SayHi()
        {
            return "Hiya!";
        }
        static void Main(string[] args)
        {
            // PRIMITIVE DATA TYPES
            // int myInt = 10;
            // double myfloat = 3.141;
            // short myShort = 2; 
            // (Short = -32,768 to 32,767)
            // bool myBool = true;
            // char myChar = 'g';

            string language = "World";
            Console.WriteLine($"Hello {language}!");

            // && = both conditions must be true
            // || = either condition must be true
            // ! = change true to false or false to true

            // Conditionals
            int numRings = 1;
            if (numRings >= 5)
            {
              Console.WriteLine("You are welcome to join the party!");  
            }
            else if (numRings < 2)
            {
                Console.WriteLine($"{numRings} is not enough rings!");
            }
            else
            {
                Console.WriteLine("Go win some more rings!");
            }
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(2, 8));
            }

            // Collections (Arrays, Lists and Dictionaries)
            // ARRAY
            string[] strArr = {"Jason", "Corey", "Ghaida"};
            foreach (string name in strArr)
            {
                Console.WriteLine(name);
            }
            // LIST
            List<int> nums = new List<int>();
            nums.Add(10);
            nums.Add(6);
            nums.Add(15);
            nums.Add(42);
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            // DICTIONARY
            Dictionary<string, string> profile = new Dictionary<string, string>();
            string language = "C#";
            string key = "Favorite Language";
            profile.Add("Name", "Jason");
            profile.Add("Location", "Spokane, WA, USA");
            profile.Add("Favorite Language", language);
            Console.WriteLine("My Profile:");
            Console.WriteLine("Name: " + profile["Name"]);
            Console.WriteLine("From: " + profile["Location"]);
            Console.WriteLine("Favorite Language: " + profile[key]);
            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine( entry.Key + ": " + entry.Value);
            }
            // FUNCTIONS
            SayHello();
            Console.WriteLine(SayHi());

            //Implicit Casting
            int integerValue = 65;
            double doubleValue = integerValue;
            Console.WriteLine(doubleValue.ToString());

            //Explicit Casting
            double dVal = 3.14159265358;
            int iVal = (int)dVal;
            Console.WriteLine(iVal.ToString());
        }
    }
}
