using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 30;
            int[] array = new int[sizeArray];
            Random random = new Random();
            
            for (int i = 0; i < array.Length ; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.SetCursorPosition(0,3);
            
            if (array[0] > array[1])
            {
                Console.Write(array[0] + " ");
            }

            for (int i = 1; i < array.Length -1 ; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    Console.Write(array[i] + " ");
                }
            }
            
            if (array[sizeArray - 1] > array[sizeArray - 2])
            {
               Console.Write(array[sizeArray - 1] + " ");
            }
        }
    }
}
