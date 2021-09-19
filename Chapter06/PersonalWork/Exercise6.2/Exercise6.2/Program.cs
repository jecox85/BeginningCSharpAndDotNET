using System;

namespace Exercise6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the end of chapter six exercise number 2 on page 143
            Console.WriteLine(args.Length);
            if (args.Length >= 2)
            {
                string argOne;
                int argTwo;
                argOne = args[0];
                argTwo = Convert.ToInt32(args[1]);
                Console.WriteLine($"Argument one = {argOne}. Argument two = {argTwo}.");
            }
            Console.ReadKey();
        }
    }
}
