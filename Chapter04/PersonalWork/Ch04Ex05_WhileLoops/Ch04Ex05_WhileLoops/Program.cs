using System;

namespace Ch04Ex05_WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the text example for using while loops found in chapter 4 page 71 of the text.
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have");
            do
            {
                targetBalance = Convert.ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                    Console.WriteLine("You must enter an amount greater than your current balance\n" +
                        "Please enter another value.");
            } while (targetBalance <= balance);
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            if (totalYears == 0)
            {
                Console.WriteLine("To be honest, you really didn't need to use this calculator.");
            }
            Console.ReadKey();
        }
    }
}
