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
            int lineSymbol = 0; 
            char symbol;
            string userName;
            string lineUserName;
            
            Console.WriteLine("Введите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("Введите любой символ");
            symbol = Convert.ToChar(Console.ReadLine());
            lineUserName = symbol + userName + symbol ;
            
            for(int x = lineSymbol; x < lineUserName.Length; x++)
            {
                 Console.Write(symbol);
            }
            Console.Write("\n"+ lineUserName + "\n");

            for (int x = lineSymbol; x < lineUserName.Length; x++)
            {
                Console.Write(symbol);
            }
        }
    }
}
