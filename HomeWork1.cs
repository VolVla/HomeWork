using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            string nameUser;
            string signOfZodiac;
            
            Console.WriteLine("Как вас зовут");
            nameUser = Console.ReadLine();
            Console.WriteLine("Какой ваш знак зодиака");
            signOfZodiac = Console.ReadLine();
            Console.WriteLine("Вас зовут " + nameUser + ",вам 21 год, вы " + signOfZodiac + " работаете на заводе." );
        }
    }
}
