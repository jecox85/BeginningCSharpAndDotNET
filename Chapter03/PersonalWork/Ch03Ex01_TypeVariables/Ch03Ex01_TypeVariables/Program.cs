using System;

namespace Ch03Ex01_TypeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading example found on page 37 of the text.
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();
        }
    }
}
