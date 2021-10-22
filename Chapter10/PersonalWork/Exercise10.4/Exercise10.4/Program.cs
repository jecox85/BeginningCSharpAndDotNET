using System;

namespace Exercise10._4
{
    public class MyCopyableClass
    {
        public int ClassInt { get; set; }
        public MyCopyableClass()
        {
            ClassInt = 0;
        }
        public MyCopyableClass(int val)
        {
            this.ClassInt = val;
        }
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating first object with a ClassInt of 7.");
            MyCopyableClass objectA = new MyCopyableClass(7);
            Console.WriteLine("Creating second object and using GetCopy to copy the first object into it.");
            MyCopyableClass objectB = objectA.GetCopy();
            Console.WriteLine("Changing the int in the first object so that we can verify both objects " +
                "don't point to the same place in memory.");
            objectA.ClassInt = 3;
            Console.WriteLine($"objectA.ClassInt = " + objectA.ClassInt.ToString() + " objectb.ClassInt = "
                + objectB.ClassInt.ToString());
            Console.ReadKey();

        }
    }
}
