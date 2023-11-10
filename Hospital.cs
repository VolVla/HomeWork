using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeMinuteOfHour = 60;
            int timeService = 10;
            int allWaitingTime;
            int waitingTimeMinute;
            int waitingTimeHour;
            
            Console.Write("Введите кол-во людей в очереди:");
            int.TryParse(Console.ReadLine(), out int numberHumans);
            allWaitingTimes = numberHumans * timeService;
            waitingTimeHour = allWaitingTime / timeMinuteOfHour;
            waitingTimeMinute = allWaitingTime % timeMinuteOfHour;
            Console.WriteLine($"Вы должны отстоять в очереди: {waitingTimeHour} часа {waitingTimeMinute} минут.");
        }
    }
}
