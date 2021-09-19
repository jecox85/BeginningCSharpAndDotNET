using System;

namespace Ch04Ex02_IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the if Statement text example on page 62 of the text.
            string comparison;
            Console.WriteLine("Enter a number: ");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
            {
                comparison = "Less than";
            }
            else
            {
                if (var1 == var2)
                {
                    comparison = "equal to";
                }
                else
                {
                    comparison = "greater than";
                }
            }
            Console.WriteLine($"The first number is {comparison} the second number.");
            Console.ReadKey();
        }
    }
}
