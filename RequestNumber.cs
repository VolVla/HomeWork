using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            number = ReturnNumber(number);
        }
        static int ReturnNumber(int number)
        {
            string userInput;
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine($"Введите число");
                userInput = Console.ReadLine();
                bool result = int.TryParse(userInput, out number);

                if (result == true)
                {
                    Console.WriteLine($"Преобразование прошло успешно. Число {number}");
                    isExit = true; 
                }
                else
                {
                    Console.WriteLine($"Преобразование прошло не удачно введите число.");
                }
            }
             return number;
        }
    }
}
