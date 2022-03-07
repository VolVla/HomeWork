using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string userInput;
            string wordExit = "exit";
            int positionLine = 0;
            int health = 4;
            int maxHealth = 10;
            int mana = 1;
            int maxMana = 5;
            int percentFillBar = 0;
            string healthBar = "HealthBar";
            string manaBar = "ManaBar";

            while (isExit == false)
            {
                Console.WriteLine("Введите % заполнения шкалы " + healthBar);
                health = Convert.ToInt32(Console.ReadLine());
                percentFillBar = health * maxHealth / 100;
                Console.Clear();

                DrawBar(percentFillBar, maxHealth, positionLine,'_', '#') ;

                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Введите % заполнения шкалы " + manaBar );
                mana = Convert.ToInt32(Console.ReadLine());
                percentFillBar = mana * maxMana / 100;

                DrawBar(percentFillBar, maxMana, positionLine + 1 , '_','#');

                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Для выхода из программы напишите" + wordExit);
                userInput = Console.ReadLine();
                
                if(userInput == wordExit)
                {
                    isExit = true;
                }
                Console.Clear(); 
            }
        }    
        static void DrawBar(int value, int maxValue, int positionX, char emptySymbol = ' ',char fillSymbol = ' '  )
        {
            string bar ="";
            
            for (int i = 0; i < value; i++)
            {
                bar += fillSymbol;
            }

            Console.SetCursorPosition(0, positionX);
            Console.Write('[');
            Console.Write(bar);
            bar ="";
            
            for(int i = 0; i < maxValue - value; i++)
            {
                bar += emptySymbol;
            }
             
            Console.Write(bar + "]");
        }
    }
}
