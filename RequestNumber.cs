using System;

namespace RequestNumber
{
    class Program
    {
        static void Main()
        {
            int number;

            number = GetNumber();
            Console.ReadKey();
        }

        static int GetNumber()
        {
            int number;

            Console.WriteLine($"Введите число");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Введите число");
            }

            Console.WriteLine("Преобразование прошло успешно.");

            return number;
        }
    }
}
