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
            string fullName = "Фамилию Имя Отчество";
            string jobName = "Должность";
            int[] index = new int[1];
            int numberDosie = 0;
            string[] arrayFullName = new string[index.Length];
            string[] arrayPositonJob = new string[index.Length];

            bool exit = false;
            string inputUser;

            while (exit == false)
            {
                Console.WriteLine("\n1 Для добавление досье введите 1.\n2 Для вывода всех досье введите 2. \n3 Для удаления досье введите 3. \n4 Для поиска досье по фамилии введите 4. \n5 Для выхода из программы введите 5.");
                inputUser = Console.ReadLine();
                switch (inputUser)
                {
                    case "1":
                       index = AddIndex(index, numberDosie);
                        Console.WriteLine($"Введите {fullName}");
                     arrayFullName = AddInform(arrayFullName, numberDosie);
                        Console.WriteLine($"Введите {jobName}");
                      arrayPositonJob = AddInform(arrayPositonJob, numberDosie);
                        numberDosie++;
                        break;
                    case "2":
                        Console.WriteLine($"Номер     ФИО     Должность ") ;
                        outDosie(index,arrayFullName,arrayPositonJob);
                        break;
                    case "3":
                        Console.WriteLine("Введите номер досье");
                        RemoveDossier();
                        break;
                    case "4":
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.WriteLine("Вы вышли из программы");
                        exit = true;
                        break;
                }
            }
        }

       static string[] AddInform(string[] array,  int numberDosie)
        {
            string enterInformation;
            enterInformation = Console.ReadLine();
            string[] tempArrayInformation = new string[array.Length + 1 ];
            tempArrayInformation[tempArrayInformation.Length - 1] = enterInformation;

            for (int i = 0; i < array.Length; i++)
            {
                tempArrayInformation[i] = array[i];

            }

            array = tempArrayInformation;

            return array;
        }

        static void outDosie(int[] index,string[] arrayFullName,string[] arrayPositonJob)
        {
            foreach (int value in index)
           {
               Console.Write($"{value}  ");

                foreach (string fullName in arrayFullName)
                {
                    Console.Write($" {fullName}   ");
                    foreach(string jobName in arrayPositonJob)
                    {
                        Console.Write($" {jobName}");
                        
                    }
                    
                }
                Console.WriteLine();
            }
        }
        static int[] AddIndex( int[] index, int numberDosie)
        {
            
            index[numberDosie] = numberDosie;
            
           
                
            
            return index;

        }

        static string AddFullName(string[] arrayFullName,int numberDosie)
        {
            
            string enterFullname;
            Console.WriteLine("Введите Фамилию Имя Отчество");
            enterFullname = Console.ReadLine();
            string[] tempArrayFullname = new string[arrayFullName.Length + 1];
            tempArrayFullname[tempArrayFullname.Length - 1] = enterFullname;

            for (int i = 0; i < arrayFullName.Length; i++)
            {
                tempArrayFullname[i] = arrayFullName[i];
            
            }
            
            arrayFullName = tempArrayFullname;

            return arrayFullName[numberDosie];
        }

        static void AddPositionJob(string[] positionJob,int numberDosie)
        {
            string job;
            Console.WriteLine("Введите Должность");
            job = Console.ReadLine();
            positionJob[numberDosie] = job;
        }
        static void RemoveDossier()
        {

           int index = Convert.ToInt32(Console.ReadLine());

        }
        static void OutputAllDossier()
        {

        }
        static void SearchLastName()
        {

        }
    }
}
