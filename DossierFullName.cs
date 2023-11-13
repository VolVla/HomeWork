using System;

namespace DossierFullName
{
    class Program
    {
        static void Main()
        {
            const string CommandAddDosier = "1";
            const string CommandShowDosiers = "2";
            const string CommandRemoveDosier = "3";
            const string CommandFindDosierFullName = "4";
            const string CommandExit = "5";

            bool isExit = false;
            string[] arrayFullNames = new string[0];
            string[] arrayPositonJobs = new string[0];
            string inputUser;

            while (isExit == false)
            {
                Console.WriteLine($"\n1 Для добавление досье введите {CommandAddDosier}." +
                $"\n2 Для вывода всех досье введите {CommandShowDosiers}." +
                $"\n3 Для удаления досье введите {CommandRemoveDosier}. " +
                $"\n4 Для поиска досье по фамилии введите {CommandFindDosierFullName}." +
                $"\n5 Для выхода из программы введите {CommandExit}");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CommandAddDosier:
                        AddDossier(ref arrayFullNames, ref arrayPositonJobs);
                        break;

                    case CommandShowDosiers:
                        ShowDossies(arrayFullNames, arrayPositonJobs);
                        break;

                    case CommandRemoveDosier:
                        RemoveDossier(ref arrayFullNames, ref arrayPositonJobs);
                        break;

                    case CommandFindDosierFullName:
                        FindDossier(arrayFullNames, arrayPositonJobs);
                        break;

                    case CommandExit:
                        Console.WriteLine("Вы вышли из программы");
                        isExit = true;
                        break;
                }
            }
        }

        static void AddDossier(ref string[] arrayFullNames, ref string[] arrayPositonJobs)
        {
            Console.WriteLine("Напишите ФИО сотрудника");
            AssignValueArray(ref arrayFullNames);
            Console.WriteLine("Напишите должность сотрудника");
            AssignValueArray(ref arrayPositonJobs);
        }

        static void AssignValueArray(ref string[] nameArray)
        {
            string[] tempValueArray = new string[nameArray.Length + 1];
            tempValueArray[tempValueArray.Length - 1] = Console.ReadLine();

            for (int i = 0; i < nameArray.Length; i++)
            {
                tempValueArray[i] = nameArray[i];
            }

            nameArray = tempValueArray;
        }

        static void ShowDossies(string[] arrayFullNames, string[] arrayPositonJobs)
        {
            for (int i = 0; i < arrayFullNames.Length; i++)
            {
                if (arrayFullNames[i] != "" && arrayPositonJobs[i] != "")
                {
                    Console.WriteLine($"{i + 1}    - {arrayFullNames[i]} -  {arrayPositonJobs[i]}");
                }
            }
        }

        static void RemoveDossier(ref string[] arrayFullNames, ref string[] arrayPositonJobs)
        {
            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossies(arrayFullNames, arrayPositonJobs);
            int.TryParse(Console.ReadLine(), out int indexArray);
            DeleteValueArray(ref arrayFullNames, ref indexArray);
            DeleteValueArray(ref arrayPositonJobs, ref indexArray);
            Console.WriteLine($"Вы удалили досье");
        }

        static void DeleteValueArray(ref string[] nameArray, ref int indexArray)
        {
            string[] tempValueArray = new string[nameArray.Length - 1];

            for (int i = 0; i < indexArray - 1; i++)
            {
                tempValueArray[i] = nameArray[i];
            }

            for (int i = indexArray; i < tempValueArray.Length; i++)
            {
                tempValueArray[i - 1] = nameArray[i];
            }

            nameArray = tempValueArray;
        }

        static void FindDossier(string[] arrayFullNames, string[] arrayPositonJobs)
        {
            bool foundDossier = false;
            string[] inputFullNames;
            string inputSurname;
            char space = ' ';

            Console.WriteLine($"Чтобы найти досье, напишите полностью фамилию");
            inputSurname = Console.ReadLine();

            for (int i = 0; i < arrayFullNames.Length; i++)
            {
                inputFullNames = arrayFullNames[i].Split(space);

                if (inputSurname == inputFullNames[0])
                {
                    Console.WriteLine("Досье найдено!");
                    Console.WriteLine($"{i + 1}    - {arrayFullNames[i]} -  {arrayPositonJobs[i]}");
                    foundDossier = true;
                }
            }

            if (foundDossier == false)
            {
                Console.WriteLine("Такое досье не было найдено!");
            }
        }
    }
}
