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
            int heightPositionLine = 6;
            int indentTextName = 1;
            int valueRow = 3;
            const int ValueInitial = 0;
            char symbol;
            string userName;
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Введите имя пользователя");
                userName = Console.ReadLine();
                Console.WriteLine("Введите любой символ");
                symbol = Convert.ToChar(Console.ReadLine());
                
                for (int y = ValueInitial; y < valueRow; y++)
                {
                    Console.WriteLine(symbol);

                        for (int x = ValueInitial; x < userName.Length + indentTextName; x++)
                        {
                            Console.Write(symbol);
                        }
                }
                Console.SetCursorPosition(indentTextName, heightPositionLine);
                Console.Write(userName);
                isExit = true;
            }
        }
    }
}
