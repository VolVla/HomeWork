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
            int amountNaturalNumbers = 0;
            int lowerLimit = 100;
            int upperLimit = 1000;
            Random random = new Random();
            int valueElementN = random.Next(minimumValue, maximumValue);

            for (int i = 0; i < upperLimit; i += valueElementN)
            {
                if(i > lowerLimit)
                {
                    amountNaturalNumbers++;
                }
            } 
            Console.WriteLine($"Число N = {valueElementN} количество трехзначных натуральных чисел {amountNaturalNumbers}");
        }
    }
}
