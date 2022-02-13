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
            int userNameLenght;
            char symbol;
            string userName;
            int valueIndent = 1;

            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            userNameLenght = userName.Length;
            Console.WriteLine("Введите любой символ");
            symbol = Convert.ToChar(Console.ReadLine());

            for (int x= 0; x <= userNameLenght + valueIndent; x++)
            {
                Console.Write(symbol);
            }
            Console.SetCursorPosition(0,5);
            
            for (int x = 0; x <= userNameLenght + valueIndent; x++)
            {
                Console.Write(symbol);
            }
            Console.SetCursorPosition(1, 5);
            Console.Write(userName);
            Console.SetCursorPosition(0, 6);
            
            for (int x = 0; x <= userNameLenght + valueIndent; x++)
            {
                Console.Write(symbol);
            }
        }
    }
}
