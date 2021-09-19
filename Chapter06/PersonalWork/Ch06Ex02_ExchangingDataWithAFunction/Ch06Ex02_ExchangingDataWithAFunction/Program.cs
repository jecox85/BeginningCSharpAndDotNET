using System;

namespace Ch06Ex02_ExchangingDataWithAFunction
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                }
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            //This is the reading example two for chapter 6 regarding Exchanging Data with a function foundon page 119
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine($"The maximum value in myArray is {maxVal}");
            Console.ReadKey();
        }
    }
}
