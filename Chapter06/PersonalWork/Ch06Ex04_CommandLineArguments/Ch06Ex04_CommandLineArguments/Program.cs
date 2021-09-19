using System;

namespace Ch06Ex04_CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the Chapter 6 reading example 4 regarding Command-line arguments found on page 135 of the text.
            Console.WriteLine($"{args.Length} command line arguments were specified:");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
        }
    }
}
