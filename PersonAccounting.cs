using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string inputUser;
            List<string> fullName = new List<string>();
            List<string> positionJob = new List<string>();

            while (isExit == false)
            {
                Console.WriteLine("\n1 Для добавление досье введите 1.\n2 Для вывода всех досье введите 2. \n3 Для удаления досье введите 3. \n4 Для выхода из программы введите 4.");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        AddDosier(fullName, positionJob);
                        break;
                    case "2":
                        ShowDossies(fullName, positionJob);
                        break;
                    case "3":
                        RemoveDossier(fullName,positionJob);
                        break;
                    case "4":
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

        static void RemoveDossier( List<string> fullName,  List<string> positionJob)
        {
            int indexArray = 0;
            string input;
            bool result = false;
            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossies(fullName, positionJob);

            while(result == false)
            {
                input = Console.ReadLine();

                if(int.TryParse(input,out int value))
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
