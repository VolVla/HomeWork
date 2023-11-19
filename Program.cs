using System;
using System.Collections.Generic;

namespace InputWord
{
    class Program
    {
        static void Main()
        {
            const string CommandExitProgram = "Exit";

            bool isExit = false;

            string wordCar = "Машина";
            string wordSchool = "Школа";
            string wordCat = "Кошка";
            string enterWord;

            Dictionary<string, string> word = new Dictionary<string, string>()
            {
                {wordCar ,"Лада Приора"},
                {wordSchool,"Школьники"},
                {wordCat,"не собака"}
            };

            while (isExit == false)
            {
                Console.WriteLine($"Введите свое слово./Пример {wordCar}, {wordSchool}, {wordCat}. Для выхода из программы напишите {CommandExitProgram}");
                enterWord = GetWord();

                if (enterWord == CommandExitProgram) ;
                {
                    isExit = true;
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
