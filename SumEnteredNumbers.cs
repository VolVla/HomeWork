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
            int sizeArray = 4;
            int[] arrayNumbers = new int[sizeArray];
            bool exit = false;
            int amountNumbers = 0;
            int number = 0;
            string inputUser;
            string wordEnterNumbers = "numbers";
            string wordExit = "exit";
            string wordAmount = "sum";

            Console.WriteLine("Введите числа через пробел");
            while(exit == false)
            {
                
                Console.WriteLine("Комманды 1) "+ wordEnterNumbers + " введите число \n2)Введите слово "+ wordAmount +" для выведения суммы всех введеных чисел \n3)Введите слово "+ wordExit+" для выхода из программы  ");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "numbers":
                        Console.WriteLine("Введите число");
                        number = Convert.ToInt32 (Console.ReadLine());
                        for (int i=0; i<sizeArray; i++)
                        {
                            arrayNumbers[i] = number;

                        Console.WriteLine(arrayNumbers[i] + " "  + " "); 
                        }
                         
                    break;

                    case "sum":
                        for (int i = 0;i<arrayNumbers.Length;i++)
                            amountNumbers += arrayNumbers[i];
                        {
                        }
                        break;

                    case "exit":

                            exit = true;

                        break;
                } 
                
            }
        }
    }
}
