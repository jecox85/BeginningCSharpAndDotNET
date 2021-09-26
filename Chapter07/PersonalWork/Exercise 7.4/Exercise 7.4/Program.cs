using System;

namespace Exercise_7._4
{
    class Program
    {
        /*
         *  This program is for Exercise 7.4 found on page 173 of the text:
         *  7.4	Given the enumeration data type orientation defined in the following code, write an application that uses 
         *  structured exception handling (SEH) to cast a byte-type variable into an orientation-type variable in a safe 
         *  way. (Note: You can force exceptions to be thrown using the checked keyword, an example of which is shown here. 
         *  This code should be used in your application.)
	     *      enum Orientation : byte
	     *      {
		 *          North = 1,
		 *          South = 2,
		 *          East = 3,
		 *          West = 4
	     *      }
	     *      myDirection = checked((Orientation)myByte);
         */
        enum Orientation : byte
        {
            North = 1,
            South = 2,
            East = 3,
            West = 4
        }
        static void Main(string[] args)
        {
            Orientation myDirection;
            for(byte myByte = 0; myByte < 8; myByte++)
            {
                try
                {
                    myDirection = checked((Orientation)myByte);
                    if (myDirection < Orientation.North || myDirection > Orientation.West)
                    {
                        throw new ArgumentOutOfRangeException("myByte", myByte, "Value must be between 1 and 4");
                    }
                    Console.WriteLine($"myDirection = {myDirection}\n");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    // If this section is reached then myByte < 1 or myByte > 4.
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Assigning default value, Orientation.North.\n");
                    myDirection = Orientation.North;
                }
            }
        }
    }
}
