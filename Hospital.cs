using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeMinuteOfHour = 60;
            const int timeService = 10;
            int allWaitingTime;
            int waitingTimeMinute;
            int waitingTimeHour;
            
            Console.Write("Введите кол-во людей в очереди:");
            int.TryParse(Console.ReadLine(), out int numberHumans);
            allWaitingTime = numberHumans * timeService;
            waitingTimeHour = allWaitingTime / timeMinuteOfHour;
            waitingTimeMinute = allWaitingTime % timeMinuteOfHour;
            Console.WriteLine($"Вы должны отстоять в очереди: {waitingTimeHour} часа {waitingTimeMinute} минут.");
        }
    }
}
