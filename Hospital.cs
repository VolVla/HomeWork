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
            const int timeService = 10;
            int time, min, hour, humans;
            
            Console.Write("Введите кол-во людей в очереди:");
            humans = Convert.ToInt32(Console.ReadLine());
            time = humans * timeService;
            hour = time / 60;
            min = time % 60;
            Console.WriteLine("Вы должны отстоять в очереди: " + hour + " часа " + min + " минут.");

        }
    }
}
