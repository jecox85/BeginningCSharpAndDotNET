using System;

namespace Ch09Ex03_ClassesVersusStructs
{
    class MyClass
    {
        public int val;
    }
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating objectA which is an instance of MyClass");
            MyClass objectA = new MyClass();
            Console.WriteLine("Creating objectB which is an instance of MyClass and setting it equal to objectA");
            MyClass objectB = objectA;
            Console.WriteLine("Setting objectA to a value of 10.");
            objectA.val = 10;
            Console.WriteLine("Setting objectB to a value of 20.");
            objectB.val = 20;
            Console.WriteLine("\nBoth object A and objectB should now equal 20 because classes are reference types, so setting \n" +
                "objectB to 20 would also set objectA to 20.\n");
            Console.WriteLine($"objectA.val = {objectA.val}");
            Console.WriteLine($"objectB.val = {objectB.val}\n");
            Console.WriteLine("Creating structA which is an instance of myStruct");
            myStruct structA = new myStruct();
            Console.WriteLine("Creating structB which is an instance of myStruct and setting it equal to structA");
            myStruct structB = structA;
            Console.WriteLine("Setting structA to a value of 30.");
            structA.val = 30;
            Console.WriteLine("Setting structB to a value of 40.");
            structB.val = 40;
            Console.WriteLine("\nstructA and structB are value types, so even though we set structB to equal structA, \n" +
                "that was just setting structB to the value of structA and they don't point to the same memory location.\n");
            Console.WriteLine($"structA.val = {structA.val}");
            Console.WriteLine($"structB.val = {structB.val}");
            Console.ReadKey();

        }
    }
}
