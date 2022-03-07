using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEnteredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber;
            int sumNumbers = 0;
            int sizeArray = 0;
            int[] firstArrayNumbers = new int[sizeArray];
            bool exit = false;
            string userInput;
            string wordEnterNumbers = "1";
            string wordExit = "exit";
            string wordAmount = "sum";

            Console.WriteLine("Введите числа через пробел");
            while(exit == false)
            {
                Console.WriteLine("\nКомманды \n1)Для ввода числа напишите в чат " + wordEnterNumbers + "\n2)Для вывода суммы всех введеных чисел.Введите слово "+ wordAmount +"\n3)Для выхода из программы.Введите слово "+ wordExit);
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите число");
                        enterNumber = Convert.ToInt32 (Console.ReadLine());
                        int[] secondArray = new int [firstArrayNumbers.Length + 1];
                        secondArray[secondArray.Length - 1] = enterNumber;

                        for (int i = 0; i < firstArrayNumbers.Length; i++)
                        {
                            secondArray[i] = firstArrayNumbers[i];
                        }
                        firstArrayNumbers = secondArray;
                        sizeArray++;
                            break;
                    case "sum":

                        for (int i = 0; i < firstArrayNumbers.Length; i++)
                        {
                            sumNumbers += firstArrayNumbers[i] ;
                        }
                        Console.WriteLine(sumNumbers);    
                            break;
                    case "exit":
                        Console.WriteLine("Вы вышли из программы.");
                        exit = true;
                            break;
                } 
            }
        }
    }
}
