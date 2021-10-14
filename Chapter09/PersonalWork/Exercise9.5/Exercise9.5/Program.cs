using Exercise9._4;
using System;

namespace Exercise9._5
{
    class Program
    {
        static void addPassenger(IPassengerCarrier passengerCarrier)
        {
            Console.WriteLine(passengerCarrier.ToString());
        }
        static void Main(string[] args)
        {
            addPassenger(new Compact());
            addPassenger(new SUV());
            addPassenger(new PassengerTrain());
            addPassenger(new Pickup());
            Console.ReadKey();
        }
    }
}
