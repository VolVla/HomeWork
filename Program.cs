using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputWord
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            string exitProgram = "Exit";
            string firstWord = "Машина";
            string secondWord = "Школа";
            string thirdWord = "Кошка";
            string enterWord;
            Dictionary<string, string> word = new Dictionary<string, string>();
            word.Add("Машина", "Лада Приора");
            word.Add("Школа", "Школьники");
            word.Add("Кошка", "не собака");

            while (exit == false)
            {
                Console.WriteLine($"Введите свое слово./Пример {firstWord}, {secondWord}, {thirdWord}. Для выхода из программы напишите {exitProgram}");
                enterWord = GetWord();

                if (enterWord == exitProgram) ;
                {
                    exit = true;
                }

                if (word.ContainsKey($"{enterWord}"))
                {
                Console.WriteLine(word[enterWord]);
                }
                else
                {
                Console.WriteLine($"Вашего слова {enterWord} нет в списке");
                }
            }
        }

        static string GetWord()
        {
            string inputWord;
            inputWord = Console.ReadLine();

            return inputWord;
        }
    }
}