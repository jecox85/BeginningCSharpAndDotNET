using System;

namespace Exercise5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is for the end of chapter exercise 5.4 found on page 110
             * Write a console application that accepts a string from the user and outputs 
             * a string with the characters in reverse order.
             */
            Console.WriteLine("Please enter a string.");
            string userString = Console.ReadLine();
            string reverseString = "";
            for(int i = userString.Length - 1; i >= 0; i--)
            {
                reverseString += userString[i];
            }
            Console.WriteLine($"Your string reversed = {reverseString}.");
            Console.ReadKey();
        }
    }
}
