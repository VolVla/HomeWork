using System;

namespace SimpleCode
{
    class Program
    {
        static void Main()
        {
            string message;

            Console.WriteLine("Введите своё собщение");
            message = Console.ReadLine();
            Console.WriteLine("Введите кол-во отправляемых сообщений");
            int.TryParse(Console.ReadLine(), out int numberMessages);

            for (int i = 0; i < numberMessages; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
