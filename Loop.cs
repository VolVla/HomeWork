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
            bool endLoop = false;
            string inputOfMessage;
            while (endLoop == false) 
            { 
                Console.WriteLine("Введите слово exit.");
                inputOfMessage = Console.ReadLine();
            
                if (inputOfMessage == "exit")
                 {
                    Console.WriteLine("Вы вышли из цикла.");
                    endLoop = true;
                 }
            }
        }
    }
}
