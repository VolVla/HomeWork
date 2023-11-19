using System;
using System.Collections.Generic;

namespace PersonAccounting
{
    class Program
    {
        static void Main()
        {
            const string CommandAddDosier = "1";
            const string CommandShowDosiers = "2";
            const string CommandRemoveDosier = "3";
            const string CommandExit = "4";

            bool isExit = false;
            string inputUser;
            List<string> fullName = new List<string>();
            List<string> positionJob = new List<string>();

            while (isExit == false)
            {
                Console.WriteLine($"\n Для добавление досье введите {CommandAddDosier}.\n Для вывода всех досье введите {CommandShowDosiers}. \n Для удаления досье введите {CommandRemoveDosier}. \n Для выхода из программы введите {CommandExit}.");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CommandAddDosier:
                        AddDosier(fullName, positionJob);
                        break;

                    case CommandShowDosiers:
                        ShowDossies(fullName, positionJob);
                        break;

                    case CommandRemoveDosier:
                        RemoveDossier(fullName, positionJob);
                        break;

                    case CommandExit:
                        Console.WriteLine("Вы вышли из программы");
                        isExit = true;
                        break;
                }
            }
        }

        static void AddDosier(List<string> fullName, List<string> positionJob)
        {
            Console.WriteLine("Напишите ФИО сотрудника");
            fullName.Add(Console.ReadLine());
            Console.WriteLine("Напишите должность сотрудника");
            positionJob.Add(Console.ReadLine());
        }

        static void ShowDossies(List<string> fullName, List<string> positionJob)
        {
            for (int i = 0; i < fullName.Count; i++)
            {
                if (fullName[i] != "" && positionJob[i] != "")
                {
                    Console.WriteLine($"{i + 1}  - {fullName[i]} -  {positionJob[i]}");
                }
            }
        }

        static void RemoveDossier(List<string> fullName, List<string> positionJob)
        {
            int indexArray = 0;
            string input;
            bool result = false;
            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossies(fullName, positionJob);

            while (result == false)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    indexArray = value;
                    result = true;
                }
                else
                {
                    Console.WriteLine("Ошибка.Введите порядковый номер");
                }
            }

            if (fullName.Count < indexArray || positionJob.Count < indexArray)
            {
                fullName.RemoveAt(indexArray - 1);
                positionJob.RemoveAt(indexArray - 1);
            }

            Console.WriteLine($"Вы удалили досье");
        }
    }
}
