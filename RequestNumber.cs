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
            int number;
            bool isExit = false;
            string wordExit = "exit";
            string userInput;

            while (isExit == false)
            {
                Console.WriteLine($"Введите число");
                RequestNumber(out number, out userInput);
                Console.WriteLine($"Для выхода из программы ввидите слово {wordExit}");

                if(userInput == wordExit)
                {
                    Console.Clear();
                    isExit = true;
                }
            }
        }
        static void RequestNumber(out int number,out string userInput)
        {
            bool result = true;
            userInput = Console.ReadLine();
            result = int.TryParse(userInput, out  number);

            if (result == true)
            {
                Console.WriteLine($"Преобразование прошло успешно. Число {number}");  
            }
            else
            {
                Console.WriteLine($"Преобразование прошло не удачно введите число.");
            }  
        }
    }
}
