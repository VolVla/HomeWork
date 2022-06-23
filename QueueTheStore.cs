using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTheStore
{
    class Program
    {
        static void Main()
        {
            bool isExit = false;
            int moneyAccount = 0;
            Queue<int>  amountBuy= new Queue<int>();
            amountBuy.Enqueue(100);
            amountBuy.Enqueue(20);
            amountBuy.Enqueue(600);
            amountBuy.Enqueue(90);
            amountBuy.Enqueue(10);
            amountBuy.Enqueue(60);
            amountBuy.Enqueue(90);
           
            while (isExit == false)
            {
                if (amountBuy.Count > 0)
                {
                    Console.WriteLine("Вы обслуживаете покупателя");
                    AddMoneyAccount(amountBuy, ref moneyAccount);
                    Console.WriteLine("Нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Вы закончили обслуживать посетителей");
                    isExit = true;
                }
            }
        }

        static void AddMoneyAccount(Queue<int> number,ref int moneyAccount)
        {
            moneyAccount += number.Dequeue();
            Console.WriteLine($"Вы обслужили клиента ваш счет {moneyAccount}");
        }
    }
}
