using System;

namespace ArrayShift
{
    class Program
    {
        static void Main()
        {
            const int AmountArray = 5;

            int[] arrayNumbers = new int[AmountArray] { 1, 2, 3, 4, 5 };
            int valueShiftLeft;
            int tempValue;

            valueShiftLeft = Convert.ToInt32(Console.ReadLine()) % arrayNumbers.Length;

            for (int i = 0; i < valueShiftLeft; i++)
            {
                for (int j = 0; j < arrayNumbers.Length -1; j++)
                {
                    tempValue = arrayNumbers[j];
                    arrayNumbers[j] = arrayNumbers[j + 1];
                    arrayNumbers[j+1] = tempValue;
                }
            }

            foreach (int number in arrayNumbers)
            {
                Console.WriteLine($" {number}");
            }

            Console.ReadKey();
        }
    }
}
