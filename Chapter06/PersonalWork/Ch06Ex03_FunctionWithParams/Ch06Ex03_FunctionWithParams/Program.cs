using System;

namespace Ch06Ex03_FunctionWithParams
{
    class Program
    {
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //This is the reading example 3 in chapter 6 of the text for using params in a function on page 122
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine($"Summed Values = {sum}.");
            Console.ReadKey();
        }
    }
}
