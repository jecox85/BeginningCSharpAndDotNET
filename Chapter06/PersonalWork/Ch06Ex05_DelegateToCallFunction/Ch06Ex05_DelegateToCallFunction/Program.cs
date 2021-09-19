using System;

namespace Ch06Ex05_DelegateToCallFunction
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;
        static void Main(string[] args)
        {
            //This is Reading example 5 from chapter 6 in the text regarding using a delegate to call a function found on page 140
            ProcessDelegate process;
            Console.WriteLine("Enter two numbers separated with a comma:");
            string input = Console.ReadLine();
            int commmaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commmaPos));
            double param2 = Convert.ToDouble(input.Substring(commmaPos + 1, input.Length - commmaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input.ToUpper() == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else
            {
                process = new ProcessDelegate(Divide);
            }
            Console.WriteLine($"Result: {process(param1, param2)}");
            Console.ReadKey();
        }
    }
}
