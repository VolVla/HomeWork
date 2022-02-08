using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMessages;
            string message;
            Console.WriteLine("Введите своё собщение");
            message = Console.ReadLine();
            Console.WriteLine("Введите кол-во отправляемых сообщений");
            numberMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberMessages; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
