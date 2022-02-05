using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameUser;
            string zodiacSign;
            Console.WriteLine("Как вас зовут");
            nameUser = Console.ReadLine();
            Console.WriteLine("Какой ваш знак зодиака");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Вас зовут " + nameUser + ",вам 21 год, вы " + zodiacSign + " работаете на заводе." );
        }
    }
}
