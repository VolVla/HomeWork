using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DossierFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int index = 0;
            string[] arrayFullName = new string[index];
            string[] arrayPositonJob = new string[index];
            string inputUser;

            while (exit == false)
            {
                Console.WriteLine("\n1 Для добавление досье введите 1.\n2 Для вывода всех досье введите 2. \n3 Для удаления досье введите 3. \n4 Для поиска досье по фамилии введите 4. \n5 Для выхода из программы введите 5.");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        AddDosier(ref arrayFullName,ref arrayPositonJob);
                        break;
                    case "2":
                        ShowDosie(ref arrayFullName,ref arrayPositonJob);
                        break;
                    case "3":
                        RemoveDossier(ref arrayFullName, ref arrayPositonJob);
                        break;
                    case "4":
                        FindDossie(ref arrayFullName, ref arrayPositonJob);
                        break;
                    case "5":
                        Console.WriteLine("Вы вышли из программы");
                        exit = true;
                        break;
                }
            }
        }

        static void AddDosier(ref string[] arrayFullName, ref string[] arrayPositonJob)
        {
            string[] tempDossier = new string[arrayFullName.Length + 1];
            string[] tempJobName = new string[arrayPositonJob.Length + 1];

            for (int i = 0; i < arrayFullName.Length; i++)
            {
                tempDossier[i] = arrayFullName[i];
                tempJobName[i] = arrayPositonJob[i];
            }

            arrayFullName = tempDossier;
            arrayPositonJob = tempJobName;
            Console.WriteLine("Напишите ФИО сотрудника");
            arrayFullName[arrayFullName.Length - 1] = Console.ReadLine();
            Console.WriteLine("Напишите должность сотрудника");
            arrayPositonJob[arrayPositonJob.Length - 1] = Console.ReadLine();
        }

        static void ShowDosie(ref string[] arrayFullName,ref string[] arrayPositonJob)
        {
            for(int i = 0; i < arrayFullName.Length; i++)
            {
                if(arrayFullName[i] != "" && arrayPositonJob[i] != "")
                {
                    Console.WriteLine($"{i + 1}    - {arrayFullName[i]} -  {arrayPositonJob[i]}");
                }
            }
        }

        static void RemoveDossier(ref string[] arrayFullName, ref string[] arrayPositonJob)
        {
            int indexArray;
            string[] tempDossier = new string[arrayFullName.Length - 1];
            string[] tempJobName = new string[arrayPositonJob.Length - 1];
            
            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDosie(ref arrayFullName, ref arrayPositonJob);
            indexArray = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < indexArray - 1; i++)
            {
                tempDossier[i] = arrayFullName[i];
                tempJobName[i] = arrayPositonJob[i];
            }

            for (int i = indexArray; i < arrayPositonJob.Length; i++)
            {
                tempDossier[i - 1] = arrayFullName[i];
                tempJobName[i - 1] = arrayPositonJob[i];
            }

            arrayPositonJob = tempJobName;
            arrayFullName = tempDossier;
        }  

        static void FindDossie(ref string[] arrayFullName, ref string[] arrayPositonJob)
        {
            string inputSurname;
            int indexArray;

            Console.WriteLine($"Чтобы найти досье, напишите полностью фамилию");
            inputSurname = Console.ReadLine();

            for(int i = 0; i < arrayFullName.Length; i++)
            {
                if(inputSurname == arrayFullName[i])
                {
                    indexArray = i;
                    Console.WriteLine("Досье найдено!");
                    Console.WriteLine($"{indexArray + 1}    - {arrayFullName[i]} -  {arrayPositonJob[i]}");
                }
                else
                {
                    Console.WriteLine("Такое досье не было найдено!");
                }
            }
        }
    }
}
