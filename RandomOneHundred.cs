using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int multiplicityFirstValue = 3;
            int multiplicitySecondtValue = 5;
            int sumNumbers = 0;
            int minimumValue = 0;
            int maximumValue = 101;

            Random random = new Random();
            number = random.Next(minimumValue, maximumValue);

            for(int i = 0; i < number; i++)
            {
                if (i %  multiplicityFirstValue == 0 || i % multiplicityFirstValue == 0 )
                {
                    sumNumbers += i;
                }
            }
            Console.WriteLine($"\nСумма всех положительных чисел которые кратные {multiplicityFirstValue} или {multiplicitySecondtValue} сумма равна {sumNumbers}");
        }
    }
}
