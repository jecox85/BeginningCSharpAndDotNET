using System;

namespace Ch05Ex02_Enumeration
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            //This is the text example 2 from Chapter 5 for using Enumeration on page 89
            byte directionByte;
            string directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.ReadKey();
        }
    }
}
