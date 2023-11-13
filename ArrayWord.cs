using System;

namespace ArrayWord
{
    class Program
    {
        static void Main()
        {
            string text = "Дана строка с текстом используется метод строки ";
            char spaceText = ' ';
            string[] arrayWords = text.Split(spaceText);

            foreach (string word in arrayWords)
            {
                Console.WriteLine($"{word}");
            }

            Console.ReadKey();
        }
    }
}
