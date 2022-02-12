using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleName
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ValueInitial = 0;
            int heightPositionTextName = 6;
            int widthPositionTextName = 1;
            int valueRow = 3;
            int cursorPosition = 8;
            char symbol;
            string userName;

            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("Введите любой символ");
            symbol = Convert.ToChar(Console.ReadLine());

            for (int y = ValueInitial; y <= valueRow; y++)
            {
                Console.WriteLine(symbol);

                for (int x = ValueInitial; x <= userName.Length; x++)
                {
                    Console.Write(symbol);
                }
            }
                Console.SetCursorPosition(widthPositionTextName, heightPositionTextName);
                Console.Write(userName);
                Console.SetCursorPosition(ValueInitial, cursorPosition);
        }
    }
}
