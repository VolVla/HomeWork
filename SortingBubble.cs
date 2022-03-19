using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 4, 6, 8, 1, 2, 3, 7, 9, 0, 5 };

            for (int i = 0;  i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    { 
                        int temporaryValue = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temporaryValue;
                    }
                }
            }

            foreach (int number in array)
            {
                Console.Write(number);
            }
        }
    }
}
