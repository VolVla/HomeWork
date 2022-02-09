using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "admin";
            string inputPassword;

                for(int i = 0; i < tryCount; i++)
                {
                    Console.WriteLine("Введите пароль " + password);
                    inputPassword = Console.ReadLine();

                    if(password == inputPassword)
                    {
                        Console.WriteLine("Вы получили доступ к секретному сообщению.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите правильный пароль. У вас осталось - " + (tryCount - i -1) + " попыток.");
                    }
                }
        }
    }
}
