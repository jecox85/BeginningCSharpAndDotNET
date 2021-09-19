using System;

namespace Exercise5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  This is for the end of chapter exercise 5.5 found on page 110 of the text.
             *  Write a console application that accepts a string and replaces all occurrences 
             *  of the string no with yes.
             */
            Console.WriteLine("Please enter a string.");
            string userString = Console.ReadLine();
            userString = userString.Replace("no", "yes");
            Console.WriteLine($"Here is your string, but more optimistic: {userString}");
            Console.ReadLine();
        }
    }
}
