﻿using System;

namespace Ch04Ex04_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the chapter 4 text example for a do while loop found on page 69 of the text.
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            } while (balance < targetBalance);
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")}" +
                $"you'll have a balance of {balance}.");
            Console.ReadKey();
        }
    }
}
