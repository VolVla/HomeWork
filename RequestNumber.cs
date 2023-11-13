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
            bool isExit = false;
            int number = 0;

            while (isExit == false)
            {
                Console.WriteLine($"Введите число");
                isExit = int.TryParse(Console.ReadLine(), out number);
            }

            Console.WriteLine("Преобразование прошло успешно.");
            return number;
        }
    }
}
