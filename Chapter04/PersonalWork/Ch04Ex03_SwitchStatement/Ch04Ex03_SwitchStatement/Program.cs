﻿using System;

namespace Ch04Ex03_SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the text example for using switch statements found on page 67
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That is a very silly name.");
                    break;
                default:
                    Console.WriteLine("That's a different name.");
                    break;
            }
            Console.WriteLine($"Hello {name}!");
            Console.ReadKey();
        }
    }
}
