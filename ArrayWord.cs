using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text ="Дана строка с текстом используя метод строки ";
            string[] arrayWords = text.Split(' ');

            foreach (string word in arrayWords)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
