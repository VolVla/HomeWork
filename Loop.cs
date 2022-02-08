using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string inputUser;
            string commandExit = "exit";

            while (isExit == false)
            {
                Console.WriteLine("Введите слово " + commandExit);
                inputUser = Console.ReadLine();

                if (inputUser == commandExit)
                {
                    Console.WriteLine("Вы вышли из цикла.");
                    isExit = true;
                }
            }
        }
    }
}
