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
                        AddDosier(ref fullName, ref positionJob);
                        break;
                    case "2":
                        ShowDossies(fullName, positionJob);
                        break;
                    case "3":
                        RemoveDossier(ref fullName, ref positionJob);
                        break;
                    case "4":
                        Console.WriteLine("Вы вышли из программы");
                        isExit = true;
                        break;
                }
            }
        }

        static void AddDosier(ref List<string> fullName, ref List<string> positionJob)
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

        static void RemoveDossier(ref List<string> fullName, ref List<string> positionJob)
        {
            int indexArray = 0;

            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossies(fullName, positionJob);
            indexArray = Convert.ToInt32(Console.ReadLine());
            DeletedValue(ref fullName, ref indexArray);
            DeletedValue(ref positionJob, ref indexArray);
            Console.WriteLine($"Вы удалили досье");
        }

        static void DeletedValue(ref List<string> name, ref int indexArray)
        {
            name.RemoveAt(indexArray);
        }
    }
}
