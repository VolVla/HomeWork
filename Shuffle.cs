using System;

namespace Shuffle
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            
            Shuffle(array);
            OutputArray(array);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Swap(array, i, random.Next(array.Length));
            }
        }

        static void Swap(int[] array, int firstNumber, int secondNumber)
        {
            int temporaryValue = array[firstNumber];
            array[firstNumber] = array[secondNumber];
            array[secondNumber] = temporaryValue;
        }

        static void OutputArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
