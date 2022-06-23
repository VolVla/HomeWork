using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = true;
            string userInput;
            const string wordExit = "exit";
            const string commandAmount = "sum";
            List<int> numbers = new List<int>();

            while (isExit == true)
            {
                Console.WriteLine($"\nВведите число  \nДля вывода суммы всех введеных чисел.Введите слово {commandAmount}\nДля выхода из программы.Введите слово {wordExit}");
                userInput = Console.ReadLine();

                if (wordExit == userInput)
                {
                    Console.WriteLine("Вы вышли из программы.");
                    isExit = false;
                }
                else if (commandAmount == userInput)
                {
                    SumNumbers(numbers);
                }
                else
                {
                    bool result = int.TryParse(userInput, out int enterNumber);

                    if (result)
                    {
                        EnterNumber(numbers, userInput);
                    }
                    else
                    {
                        Console.WriteLine($"Вы ввели не число и не известную команду");
                    }
                }
            }  
        }

        static void EnterNumber(List<int> numbers,string userInput)
        { 
            int enterNumber;
            enterNumber = Convert.ToInt32(userInput);
            numbers.Add(enterNumber);
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
