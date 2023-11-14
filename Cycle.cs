using System;

namespace Cycle
{
    class Program
    {
        static void Main()
        {
            int _currentOfNumber = 5;
            int _stepValue = 7;
            int _maximumNumber = 96;
            char spaceChar = ' ';

            for (int i = _currentOfNumber; i <= _maximumNumber; i += _stepValue)
            {
                Console.Write($"{i} {spaceChar}");
            }

            Console.ReadKey();
        }
    }
}
