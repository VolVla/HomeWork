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
            string[] arrayFullNames = new string[0];
            string[] arrayPositonJobs = new string[0];
            string inputUser;

            while (exit == false)
            {
                Console.WriteLine("\n1 Для добавление досье введите 1.\n2 Для вывода всех досье введите 2. \n3 Для удаления досье введите 3. \n4 Для поиска досье по фамилии введите 4. \n5 Для выхода из программы введите 5.");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        AddDosier(ref arrayFullNames, ref arrayPositonJobs);
                        break;
                    case "2":
                        ShowDossies(arrayFullNames, arrayPositonJobs);
                        break;
                    case "3":
                        RemoveDossier(ref arrayFullNames, ref arrayPositonJobs);
                        break;
                    case "4":
                        FindDossie(ref arrayFullNames, ref arrayPositonJobs);
                        break;
                    case "5":
                        Console.WriteLine("Вы вышли из программы");
                        exit = true;
                        break;
                }
            }
        }

        static string[] AddElementArray(ref string[] array)
        {
            array = new string[array.Length + 1];

            return array;
        }

        static string[] RemoveElementArray(ref string[] array)
        {
            array = new string[array.Length - 1]; ;

            return array;
        }

        static void AddDosier(ref string[] arrayFullNames, ref string[] arrayPositonJobs)
        {
            string[] tempDossier = AddElementArray(ref arrayFullNames);
            string[] tempJobName = AddElementArray(ref arrayPositonJobs);
            Console.WriteLine("Напишите ФИО сотрудника");
            arrayFullNames[arrayFullNames.Length - 1] = Console.ReadLine();
            Console.WriteLine("Напишите должность сотрудника");
            arrayPositonJobs[arrayPositonJobs.Length - 1] = Console.ReadLine(); 
            
            for (int i = 0; i < arrayFullNames.Length; i++)
            {
                tempDossier[i] = arrayFullNames[i];
                tempJobName[i] = arrayPositonJobs[i];
            }

            arrayFullNames = tempDossier;
            arrayPositonJobs = tempJobName;
        }

        static void ShowDossies(string[] arrayFullNames, string[] arrayPositonJobs)
        {
            for(int i = 0; i < arrayFullNames.Length; i++)
            {
                if(arrayFullNames[i] != "" && arrayPositonJobs[i] != "")
                {
                    Console.WriteLine($"{i + 1}    - {arrayFullNames[i]} -  {arrayPositonJobs[i]}");
                }
            }
        }

        static void RemoveDossier(ref string[] arrayFullNames, ref string[] arrayPositonJobs)
        {
            int indexArray = 0;
            string[] tempDossier = RemoveElementArray(ref arrayFullNames);
            string[] tempJobName = RemoveElementArray(ref arrayPositonJobs);

            Console.WriteLine($"Напишите порядковый номер досье,который вы хотите удалить");
            ShowDossies(arrayFullNames, arrayPositonJobs);
            indexArray = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < indexArray - 1; i++)
            {
                tempDossier[i] = arrayFullNames[i];
                tempJobName[i] = arrayPositonJobs[i];
            }

            for (int i = indexArray; i < arrayPositonJobs.Length; i++)
            {
                tempDossier[i - 1] = arrayFullNames[i];
                tempJobName[i - 1] = arrayPositonJobs[i];
            }

            arrayPositonJobs = tempJobName;
            arrayFullNames = tempDossier;
        }  

        static void FindDossie(ref string[] arrayFullNames, ref string[] arrayPositonJobs)
        {
            string[] inputFullNames;
            string inputSurname;
            int indexArray;

            Console.WriteLine($"Чтобы найти досье, напишите полностью фамилию");
            inputSurname = Console.ReadLine(); 
            inputFullNames = inputSurname.Split(' ');

            for(int i = 0; i < arrayFullNames.Length; i++)
            {
                if(inputSurname == inputFullNames[0])
                {
                    indexArray = i;
                    Console.WriteLine("Досье найдено!");
                    Console.WriteLine($"{indexArray + 1}    - {arrayFullNames[i]} -  {arrayPositonJobs[i]}");
                }
                else
                {
                    Console.WriteLine("Такое досье не было найдено!");
                }
            }
        }
    }
}