using System;

namespace SecretMessage
{
    class Program
    {
        static void Main()
        {
            int tryCount = 3;
            string password = "admin";

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль " + password);
                string inputPassword = Console.ReadLine();

                if (password == inputPassword)
                {
                    Console.WriteLine("Вы получили доступ к секретному сообщению.");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите правильный пароль. У вас осталось - " + (tryCount - i - 1) + " попыток.");
                }
            }
        }
    }
}
