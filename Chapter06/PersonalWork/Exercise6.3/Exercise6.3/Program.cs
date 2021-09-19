using System;

namespace Exercise6._3
{
    class Program
    {
        delegate string ReadLineDelegate();
        static void Main(string[] args)
        {
            //This is the solution for the end of chapter 6 exercise 3.
            ReadLineDelegate myReadline = new ReadLineDelegate(Console.ReadLine);
            Console.WriteLine("Please enter a string.");
            string userInput = myReadline();
            Console.WriteLine($"Here is your string: {userInput}");
            Console.ReadKey();
        }
    }
}
