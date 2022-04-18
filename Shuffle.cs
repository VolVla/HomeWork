using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AmountNumbers = 5;
            int[] array = new int[AmountNumbers] { 1, 2, 3, 4, 5 };
            Shuffle(array);
            ForeachArray(array);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Swap(ref array, i, i + random.Next(array.Length - i));
            }
        }
        static void Swap(ref int[] array, int firstNumber , int secondNumber)
        {
            int temporaryValue = array[firstNumber];
            array[firstNumber] = array[secondNumber];
            array[secondNumber] = temporaryValue;
        }
        static void ForeachArray(int[] array)
        {
            foreach(int value in array)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
