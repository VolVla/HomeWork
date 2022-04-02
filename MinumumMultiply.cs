using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinumumMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int minumumValueNumber = 2;
            int maxumumValueNumber = 10;
            int degree = 0;
            int superiorNumber = 1;
            int numberDegree = 2;
            Random random = new Random();
            number = random.Next(minumumValueNumber, maxumumValueNumber);

            while(superiorNumber<=number)
            {
                superiorNumber *= numberDegree;
                degree++;
            }
            Console.WriteLine($"Число {number}, степень {degree}, само число превосходящая заданое число {superiorNumber}");
        }
    }
}
