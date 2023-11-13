using System;
using System.Collections.Generic;

namespace Cycle
{
    class Program
    {
        static void Main()
        {
            Numbers numbers = new Numbers();

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }

    class Numbers
    {
        private int _currentOfNumber = 5;
        private int _stepValue = 7;
        private int _maximumNumber = 96;
        private int _startValue = 0;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; _currentOfNumber < _maximumNumber; i++)
            {
                if (i > _startValue)
                {
                    _currentOfNumber += _stepValue;

                }

                yield return _currentOfNumber;
            }

            Console.ReadKey();
        }
    }
}
