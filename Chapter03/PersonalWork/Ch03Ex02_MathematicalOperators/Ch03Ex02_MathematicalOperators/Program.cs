﻿using System;

namespace Ch03Ex02_MathematicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading example for Mathematical Operators found on page 45 of the text.
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from {firstNumber} is " + $"{firstNumber - secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is " + $"{firstNumber * secondNumber}.");
            Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is " + $"{firstNumber / secondNumber}.");
            Console.WriteLine($"The remainder after dividing {firstNumber} by {secondNumber} is " + $"{firstNumber % secondNumber}.");
            Console.ReadKey();
        }
    }
}
