using System;

namespace SumEnteredNumbers
{
    class Program
    {
        static void Main()
        {
            int[] arrayNumbers = new int[0];
            bool isExit = false;
            string userInput;
            string wordExit = "exit";
            string commandAmount = "sum";
            
            while(isExit == false)
            {
                Console.WriteLine("Введите число\nДля вывода суммы всех введеных чисел.Введите слово "+ commandAmount + "\nДля выхода из программы.Введите слово "+ wordExit);
                userInput = Console.ReadLine(); 
                
                if (userInput == wordExit)
                {
                    Console.WriteLine("Вы вышли из программы.");
                    isExit = true;
                }
                else if (userInput == commandAmount)
                {
                    int sumNumbers = 0;

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        sumNumbers += arrayNumbers[i] ;
                    }

                    Console.WriteLine(sumNumbers);    
                }
                else 
                {
                    Console.WriteLine("\n1)Для ввода числа напишите в чат");
                    int enterNumber;
                    enterNumber = Convert.ToInt32(userInput);
                    int[] tempArrayNumbers = new int [arrayNumbers.Length + 1];
                    tempArrayNumbers[tempArrayNumbers.Length - 1] = enterNumber;

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        tempArrayNumbers[i] = arrayNumbers[i];
                    }

                    arrayNumbers = tempArrayNumbers;
                }
            }
        }
    }
}
