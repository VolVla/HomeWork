using System;

namespace Converter
{
    class Program
    {
        static void Main()
        {
            const string CommandExchangeOfDollarsToRubles = "1";
            const string CommandExchangeOfDollarsToYuans = "2";
            const string CommandExchangeOfRublesToDollars = "3";
            const string CommandExchangeOfRublesToYuans = "4";
            const string CommandExchangeOfYuansToDollars = "5";
            const string CommandExchangeOfYuansToRubles = "6";
            const string CommandExit = "exit";
            float balanceUsd = 100;
            float balanceRub = 20;
            float balanceCny = 10;
            float usdToRub = 75.3f;
            float usdToCny = 6.37f;
            float rubToCny = 0.085f;
            float currencyCount;
            bool isExit = false;

            Console.WriteLine("Добро пожаловать в обменик валют.Выберете основную валюту для обмена. ");

            while (isExit == false)
            {
                Console.WriteLine("Ваш баланс " + balanceUsd + " Долларов " + balanceRub + " Рублей " + balanceCny + " Юаней ");
                Console.WriteLine($"{CommandExchangeOfDollarsToRubles} - обменять доллары на рубли");
                Console.WriteLine($"{CommandExchangeOfDollarsToYuans} - обменять доллары на юани");
                Console.WriteLine($"{CommandExchangeOfRublesToDollars} - обменять рубли на доллары");
                Console.WriteLine($"{CommandExchangeOfRublesToYuans} - обменять рубли на юани");
                Console.WriteLine($"{CommandExchangeOfYuansToDollars} - обменять юани на доллары");
                Console.WriteLine($"{CommandExchangeOfYuansToRubles} - обменять юани на рубли");
                Console.WriteLine($"Введите {CommandExit} ,чтоб закончить обмен");

                switch (Console.ReadLine())
                {
                    case CommandExchangeOfDollarsToRubles:
                        Console.WriteLine("Обмен доллары на рубли.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceUsd >= currencyCount)
                        {
                            balanceUsd -= currencyCount;
                            balanceRub += usdToRub / currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("Введено недопустимое кол-во долларов.");
                        }
                        break;
                    case CommandExchangeOfDollarsToYuans:
                        Console.WriteLine("Обмен доллары на юань.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceUsd >= currencyCount)
                        {
                            balanceUsd -= currencyCount;
                            balanceCny += usdToCny / currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("Введено недопустимое кол-во долларов.");
                        }
                        break;
                    case CommandExchangeOfRublesToDollars:
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {
                            balanceRub -= currencyCount;
                            balanceUsd += usdToRub / currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("Введено недопустимое кол-во рублей.");
                        }
                        break;
                    case CommandExchangeOfRublesToYuans:
                        Console.WriteLine("Обмен рублей на юани.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {
                            balanceRub -= currencyCount;
                            balanceCny += rubToCny / currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("Введено недопустимое кол-во рублей.");
                        }
                        break;
                    case CommandExchangeOfYuansToDollars:
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
                    case CommandExchangeOfYuansToRubles:
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
                    case CommandExit:
                        Console.WriteLine("Вы закончили обмен.");
                        isExit = true;
                        break;
                }
            }
        }
    }
}
