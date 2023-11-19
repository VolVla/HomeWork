using System;
using System.Collections.Generic;

namespace LiteDynamicArray
{
    class Program
    {
        static void Main()
        {
            const string WordExit = "exit";
            const string CommandAmount = "sum";

            bool isExit = true;
            string userInput;
            List<int> numbers = new List<int>();

            while (isExit == true)
            {
                Console.WriteLine($"\nВведите число  \nДля вывода суммы всех введеных чисел.Введите слово {CommandAmount}\nДля выхода из программы.Введите слово {WordExit}");
                userInput = Console.ReadLine();

                if (WordExit == userInput)
                {
                    Console.WriteLine("Вы вышли из программы.");
                    isExit = false;
                }
                else if (CommandAmount == userInput)
                {
                    SumNumbers(numbers);
                }
                else
                {
                    numbers = AddNumbers(userInput, numbers);
                }
            }
        }

        static List<int> AddNumbers(string userInput, List<int> numbers)
        {
            bool isNumber = int.TryParse(userInput, out int enterNumber);

            if (isNumber == true)
            {
                numbers.Add(enterNumber);
            }
            else if (isNumber == false)
            {
                Console.WriteLine($"Вы ввели не число и не известную команду");
            }

            return numbers;
        }

        static void SumNumbers(List<int> numbers)
        {
            int sumNumbers = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sumNumbers += numbers[i];
            }

            Console.WriteLine($"{sumNumbers} сумма всех ваших чисел\n");
        }
    }
}
