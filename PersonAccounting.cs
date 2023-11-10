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
                Console.WriteLine($"\n1 Для добавление досье введите {CommandAddDosier}.\n2 Для вывода всех досье введите {CommandShowDosiers}. \n3 Для удаления досье введите {CommandRemoveDosier}. \n4 Для выхода из программы введите {CommandExit}.");
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
            AssigningValue(ref fullName);
            Console.WriteLine("Напишите должность сотрудника");
            AssigningValue(ref positionJob);
        }

        static void AssigningValue(ref List<string> name)
        {
            string valueName = Console.ReadLine();
            name.Add(valueName);
        }

        static void ShowDossies(List<string> fullName, List<string> positionJob)
        {
            for (int i = 0; i < fullName.Count; i++)
            {
                if (fullName[i] != "" && positionJob[i] != "")
                {
                    Console.WriteLine($"{i}    - {fullName[i]} -  {positionJob[i]}");
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

            DeletedValue(ref fullName, indexArray);
            DeletedValue(ref positionJob, indexArray);
            Console.WriteLine($"Вы удалили досье");
        }

        static void DeletedValue(ref List<string> name, int indexArray)
        {
            name.RemoveAt(indexArray);
        }
    }
}
