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
            Foreach(array);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Swap(array, i, i + random.Next(array.Length - i));
            }
        }
        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        static void Foreach(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
