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
            float balanceDollars = 100;
            float balanceRub = 20;
            float balanceYuan = 10;
            float usdToRub = 10;
            float usdrToYuan = 20;
            float rubToYuan = 5;
            float currencyCount;
            string userInput;
            bool isExit = false;

            Console.WriteLine("Добро пожаловать в обменик валют.Выберете основную валюту для обмена. ");

            while (isExit == false)
            {   Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней ");
                Console.WriteLine("1 - обменять доллары на рубли");
                Console.WriteLine("2 - обменять доллары на юани");
                Console.WriteLine("3 - обменять рубли на доллары");
                Console.WriteLine("4 - обменять рубли на юани");
                Console.WriteLine("5 - обменять юани на рубли");
                Console.WriteLine("6 - обменять юани на доллары");
                Console.WriteLine("7 - Закончить обмен");
                userInput = Console.ReadLine();

                switch (userInput)
                {   case "1":
                        Console.WriteLine("Обмен доллары на рубли.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceDollars >= currencyCount)
                        {   balanceDollars -= currencyCount;
                            balanceRub += currencyCount / usdToRub;}
                        else{   Console.WriteLine("Введено недопустимое кол-во долларов.");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней");}
                        break;
                    case "2":
                        Console.WriteLine("Обмен доллары на юань.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceDollars >= currencyCount)
                        {   balanceDollars -= currencyCount;
                            balanceYuan += currencyCount / usdrToYuan;}
                        else{   Console.WriteLine("Введено недопустимое кол-во долларов.");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней ");}
                         break;
                    case "3":
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {   balanceRub -= currencyCount;
                            balanceDollars += currencyCount * usdToRub;}
                        else{   Console.WriteLine("Введено недопустимое кол-во рублей.");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней ");}
                        break;
                    case "4":
                        Console.WriteLine("Обмен рублей на юани.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceRub >= currencyCount)
                        {   balanceRub -= currencyCount;
                            balanceYuan += currencyCount / rubToYuan;}
                        else{   Console.WriteLine("Введено недопустимое кол-во рублей .");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней ");}
                        break;
                    case "5":
                        Console.WriteLine("Обмен юани на доллары .");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceYuan >= currencyCount)
                        {   balanceYuan -= currencyCount;
                            balanceDollars += currencyCount * usdrToYuan;}
                        else{   Console.WriteLine("Введено недопустимое кол-во юаней.");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней ");}
                            break;
                    case "6":
                        Console.WriteLine("Обмен юани на рубли.");
                        Console.WriteLine("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (balanceYuan >= currencyCount)
                        {   balanceYuan -= currencyCount;
                            balanceRub += currencyCount * rubToYuan;}
                        else{   Console.WriteLine("Введено недопустимое кол-во юаней.");
                                Console.WriteLine("Ваш баланс " + balanceDollars + " Долларов " + balanceRub + " Рублей " + balanceYuan + " Юаней");}
                        break;

                    case "7":
                        Console.WriteLine("Вы закончили обмен.");
                        isExit = true;
                        break;}
            }
        }
    }
}
