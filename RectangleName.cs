using System;

namespace RectangleName
{
    class Program
    {
        static void Main()
        {
            int currentLine = 1;
            char symbol;
            string userName;
            string lineUserName;
            int amountSymbols = 0;
            int numberRows = 3;

            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("Введите любой символ");
            symbol = Convert.ToChar(Console.ReadLine());
            lineUserName = symbol + userName + symbol;

            while (currentLine < numberRows)
            {
                if (amountSymbols < lineUserName.Length)
                {
                    Console.Write(symbol);
                    amountSymbols++;
                }

                if (amountSymbols == lineUserName.Length)
                {
                    currentLine++;

                    if (currentLine == numberRows)
                    {
                        break;
                    }

                    Console.WriteLine("\n" + lineUserName);
                    amountSymbols = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
