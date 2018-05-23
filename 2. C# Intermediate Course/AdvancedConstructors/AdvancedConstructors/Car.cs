using System;

namespace AdvancedConstructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initizlized. {0}", registrationNumber);
        }
    }
}
