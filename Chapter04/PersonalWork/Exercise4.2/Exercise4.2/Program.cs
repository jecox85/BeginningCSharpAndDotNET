using System;

namespace Exercise4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise 4.2 on page 75
            Write an application that includes the logic from Exercise 1, obtains two numbers from the user, 
            and displays them, but rejects any input where both numbers are greater than 10 and asks for two 
            new numbers.    
            */
            Console.WriteLine("Please enter two numbers. One of which must be greater than 10.");
            double num1 = 0, num2 = 0;
            bool keepGoing = true;
            do
            {
                Console.WriteLine("Number one: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Number two: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if(((num1 > 10) ^ (num2 > 10)) || (num1 < 10 && num2 < 10))
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Both numbers can't be greater than 10.");
                }
            } while (keepGoing);
            Console.WriteLine($"Number 1 = {num1} and number 2 = {num2}.");
            Console.ReadKey();
        }
    }
}
