using System;

namespace Exercise3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a console application that obtains four int values from the user and displays the
            product.Hint: You may recall that the Convert.ToDouble() command was used to convert
            the input from the console to a double; the equivalent command to convert from a
            string to an int is Convert.ToInt32().
            */
            int valueOne, valueTwo, valueThree, valueFour;
            Console.WriteLine("Please enter four integer values one at a time.");
            Console.WriteLine("First value: ");
            valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second value: ");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third value: ");
            valueThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth value: ");
            valueFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The product of {valueOne}, {valueTwo}, {valueThree}, and {valueFour} is " + 
                $"{valueOne * valueTwo * valueThree * valueFour}.");
            Console.ReadKey();
        }
    }
}
