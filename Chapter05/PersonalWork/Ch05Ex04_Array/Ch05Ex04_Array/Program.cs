using System;

namespace Ch05Ex04_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading example for arrays found on page 96 of the text
            string[] friendNames = {
                "Todd Anthony",
                "Mary Chris",
                "Autry Rual" 
            };
            int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            for(i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.WriteLine("Now using a foreach loop.");
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
            Console.ReadKey();
        }
    }
}
