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
            int sizeArray = 0;
            int[] arrayNumbers = new int[sizeArray];
            bool isExit = false;
            string userInput;
            string wordEnterNumbers = "1";
            string wordExit = "exit";
            string wordAmount = "sum";

            Console.WriteLine("Введите числа через пробел");
            while(isExit == false)
            {
                Console.WriteLine("\nКомманды \n1)Для ввода числа напишите в чат " + wordEnterNumbers + "\n2)Для вывода суммы всех введеных чисел.Введите слово "+ wordAmount +"\n3)Для выхода из программы.Введите слово "+ wordExit);
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите число");
                        enterNumber = Convert.ToInt32 (Console.ReadLine());
                        int[] tempArrayNumbers = new int [arrayNumbers.Length + 1];
                        tempArrayNumbers[tempArrayNumbers.Length - 1] = enterNumber;

                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            tempArrayNumbers[i] = arrayNumbers[i];
                        }
                        arrayNumbers = tempArrayNumbers;
                        sizeArray++;
                            break;
                    case "sum":
                        int sumNumbers = 0;

                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            sumNumbers += arrayNumbers[i] ;
                        }
                        Console.WriteLine(sumNumbers);    
                            break;
                    case "exit":
                        Console.WriteLine("Вы вышли из программы.");
                        isExit = true;
                            break;
                } 
            }
        }
    }
}
