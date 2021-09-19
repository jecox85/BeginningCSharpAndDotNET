using System;

namespace Ch06Ex01_VariableScope
{
    class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine($"Local mystring = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
        }
        static void Main(string[] args)
        {
            //This program expands reading example 1 and explores variable scope.  Found on page 128
            string myString = "String defined in Main()";
            Program.myString = "Global string";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"Local mystring = {myString}");
            Console.WriteLine($"Global mystring = {Program.myString}");
            Console.ReadKey();
        }
    }
}
