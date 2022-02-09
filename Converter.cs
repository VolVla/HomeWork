using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            float balanceUsd = 100;
            float balanceRub = 20;
            float balanceCny = 10;
            float usdToRub = 75.3f;
            float usdToCny = 6.37f;
            float rubToCny = 0.085f;
            float currencyCount;
            string userInput;
            bool isExit = false;

            Console.WriteLine("Добро пожаловать в обменик валют.Выберете основную валюту для обмена. ");

            while (isExit == false)
            {   
                Console.WriteLine("Ваш баланс " + balanceUsd + " Долларов " + balanceRub + " Рублей " + balanceCny + " Юаней ");
                Console.WriteLine("1 - обменять доллары на рубли");
                Console.WriteLine("2 - обменять доллары на юани");
                Console.WriteLine("3 - обменять рубли на доллары");
                Console.WriteLine("4 - обменять рубли на юани");
                Console.WriteLine("5 - обменять юани на доллары");
                Console.WriteLine("6 - обменять юани на рубли");
                Console.WriteLine("7 - Закончить обмен");
                userInput = Console.ReadLine();

                switch (userInput)
                {   
                    case "1":
                        Console.WriteLine("Обмен доллары на рубли.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceUsd >= currencyCount)
                        {
                            balanceUsd -= currencyCount;
                            balanceRub += usdToRub / currencyCount ;
                        }
                        else
                        {  
                            Console.WriteLine("Введено недопустимое кол-во долларов.");
                        }
                            break;
                    case "2":
                        Console.WriteLine("Обмен доллары на юань.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceUsd >= currencyCount)
                        {
                            balanceUsd -= currencyCount;
                            balanceCny += usdToCny / currencyCount ;
                        }
                        else
                        {   
                            Console.WriteLine("Введено недопустимое кол-во долларов.");
                        }
                            break;
                    case "3":
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {   
                            balanceRub -= currencyCount;
                            balanceUsd += usdToRub / currencyCount ;
                        }
                        else
                        {   
                            Console.WriteLine("Введено недопустимое кол-во рублей.");
                        }
                            break;
                    case "4":
                        Console.WriteLine("Обмен рублей на юани.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {   
                            balanceRub -= currencyCount;
                            balanceCny +=  rubToCny / currencyCount ;
                        }
                        else
                        {   
                            Console.WriteLine("Введено недопустимое кол-во рублей.");
                        }
                            break;
                    case "5":
                        Console.WriteLine("Обмен юани на доллары .");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceCny >= currencyCount)
                        {   
                            balanceCny -= currencyCount;
                            balanceUsd += usdToCny / currencyCount;
                        }
                        else
                        {   
                             Console.WriteLine("Введено недопустимое кол-во юаней.");
                        }
                            break;
                    case "6":
                        Console.WriteLine("Обмен юани на рубли.");
                        Console.WriteLine("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceCny >= currencyCount)
                        {   
                            balanceCny -= currencyCount;
                            balanceRub += rubToCny / currencyCount;
                        }
                        else
                        {   
                            Console.WriteLine("Введено недопустимое кол-во юаней.");
                        }
                            break;
                    case "7":
                            Console.WriteLine("Вы закончили обмен.");
                        isExit = true;
                        break;
                }
            }
        }
    }
}
