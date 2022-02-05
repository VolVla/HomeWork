using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeOfmin = 60;
            const int timeService = 10;
            int allWaitingTime;
            int waitingTimeMin;
            int waitingTimeHour;
            int humans;
            Console.Write("Введите кол-во людей в очереди:");
            humans = Convert.ToInt32(Console.ReadLine());
            allWaitingTime = humans * timeService;
            waitingTimeHour = allWaitingTime / timeOfmin;
            waitingTimeMin = allWaitingTime % timeOfmin;
            Console.WriteLine("Вы должны отстоять в очереди: " + waitingTimeHour + " часа " + waitingTimeMin + " минут.");
        }
    }
}
