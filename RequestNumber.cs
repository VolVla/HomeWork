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
            bool isExit = false;
            string wordExit = "exit";
            string userInput;

            while (isExit == false) 
            {
                RequestNumber(ref number,out userInput);
                ExitIsProgram(userInput, wordExit,isExit);
            }
        }
        static void ExitIsProgram(string userInput,string wordExit,bool isExit)
        {
            Console.WriteLine($"Для выхода из программы ввидите слово {wordExit}");
            if (userInput == wordExit)
            {
               Console.Clear();
               isExit = true;
            } 
        }
        static void RequestNumber(ref int number,out string userInput)
        {
            Console.WriteLine($"Введите число"); 
            userInput = Console.ReadLine();
            bool result = int.TryParse(userInput, out number);

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
