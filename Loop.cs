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
            int loop = 1;
            string inputOfMessage;
            while (loop > 0) { 
            Console.WriteLine("Введите слово exit.");
            inputOfMessage = Console.ReadLine();
            if (inputOfMessage == "exit")
                 {
                    Console.WriteLine("Вы вышли из цикла.");
                    --loop; 
                 }
            }
        }
    }
}
