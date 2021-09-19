using System;

namespace Exercise5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is is the solution for the end of chapter exercise 5.6 found on page 110 of the text
             * Write a console application that places double quotes around each word in a string.
             */
            Console.WriteLine("Please enter a sentence.");
            string userString = Console.ReadLine();
            if (userString.Length > 0)
            {
                userString = "\"" + userString.Replace(" ", "\" \"") + "\"";
            }
            Console.WriteLine($"Here is your new string with quotations around each word: \n{userString}");
            Console.ReadKey();
        }
    }
}
