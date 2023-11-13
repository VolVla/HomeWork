using System;

namespace RectangleName
{
    class Program
    {
        static void Main()
        {
            char symbol;
            string userName;
            string lineUserName;
            string frame = "";

            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("Введите любой символ");
            symbol = Convert.ToChar(Console.ReadLine());
            lineUserName = symbol + userName + symbol;

            for (int i = 0; i < lineUserName.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine(frame);
            Console.WriteLine(lineUserName);
            Console.WriteLine(frame);
            Console.ReadKey();
        }
    }
}
