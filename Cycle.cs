using System;

namespace Cycle
{
    class Program
    {
        static void Main()
        {
            int currentOfNumber = 5;
            int stepValue = 7;
            int maximumNumber = 96;

            for (int i = 0; currentOfNumber <= maximumNumber; i++)
            {
                Console.Write(currentOfNumber + " ");
                currentOfNumber += stepValue;
            }

            Console.ReadKey();
        }
    }
}
