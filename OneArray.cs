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
            int[] arrayElement = new int[30];
            Random random = new Random();

            for (int i = 1; i < arrayElement.Length - 1; i++)
            {
                arrayElement[i] = random.Next(1, 10);

                if (arrayElement[0] > arrayElement[1])
                {
                    Console.Write(arrayElement[i] + " ");
                }
                else if (arrayElement[i - 1] < arrayElement[i] && arrayElement[i + 1] < arrayElement[i])
                {
                    Console.Write(arrayElement[i] + " ");
                }
            }
        }
    }
}
