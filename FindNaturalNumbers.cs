using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumValue = 28;
            int minimumValue = 1;
            int number = 0;
            Random random = new Random();
            int valueElementN = random.Next(minimumValue, maximumValue);

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (i + j + k == valueElementN)
                        {
                            number++;
                            Console.Write(i * 100 + j * 10 + k +" ");
                        }
                    }
                }
            }
            Console.WriteLine($"\nЧисло N = {valueElementN} количество трехзначных натуральных чисел {number}");
        }
    }
}
