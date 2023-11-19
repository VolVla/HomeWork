using System;
using System.Collections.Generic;

namespace QueueTheStore
{
    class Program
    {
        static void Main()
        {
            Queue<int> amountBuy = new Queue<int>();

            amountBuy.Enqueue(100);
            amountBuy.Enqueue(20);
            amountBuy.Enqueue(600);
            amountBuy.Enqueue(90);
            amountBuy.Enqueue(10);
            amountBuy.Enqueue(60);
            amountBuy.Enqueue(90);
            ServiceClients(amountBuy);

            Console.WriteLine("Вы закончили обслуживать посетителей");
            Console.ReadKey();
        }

        static void ServiceClients(Queue<int> amountBuy)
        {
            int moneyAccount = 0;

            while (amountBuy.Count > 0)
            {
                Console.WriteLine("Вы обслуживаете покупателя");
                moneyAccount = AddMoneyAccount(amountBuy, moneyAccount);

                Console.WriteLine("Нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int AddMoneyAccount(Queue<int> number, int moneyAccount)
        {
            moneyAccount += number.Dequeue();
            Console.WriteLine($"Вы обслужили клиента ваш счет {moneyAccount}");
            return moneyAccount;
        }
    }
}
