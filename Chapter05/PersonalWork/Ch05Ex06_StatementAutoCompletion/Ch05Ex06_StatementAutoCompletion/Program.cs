using System;

namespace Ch05Ex06_StatementAutoCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the reading example 6 for chapter 5 about Statement Auto-Completion found on page 108.
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
