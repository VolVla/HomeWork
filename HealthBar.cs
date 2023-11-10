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
            int percent = 100;
            
            while (isExit == false)
            {
                percentFillBar = SetPercentBar(healthBar, health, maxHealth, percent, percentFillBar );
                Console.Clear();
                DrawBar(percentFillBar, maxHealth, positionLine,'_', '#') ;
                percentFillBar = SetPercentBar(manaBar, mana, maxMana, percent, percentFillBar);
                DrawBar(percentFillBar, maxMana, positionLine + 1 , '_','#');
                Console.WriteLine("\nДля выхода из программы напишите " + wordExit +" для продолжения напишите любой символ");
                userInput = Console.ReadLine();
                
                if(userInput == wordExit)
                {
                    isExit = true;
                }
                
                Console.Clear(); 
            }
        }
        
        static void StandartPositionText()
        {
            Console.SetCursorPosition(0, 6);
        }
        
        static int SetPercentBar(string nameBar, int value ,int maxValue,int percent, int percentFillBar)
        {
            StandartPositionText();
            Console.WriteLine("Введите % заполнения шкалы " + nameBar);
            value = Convert.ToInt32(Console.ReadLine());
            percentFillBar = value * maxValue / percent;
            return percentFillBar;
        }
        
        static void DrawBar(int value, int maxValue, int positionX, char emptySymbol = ' ',char fillSymbol = ' '  )
        {
            string bar ="";

            if (value >= 0)
            {
                for (int i = 0; i < value; i++)
                {
                    bar += fillSymbol;
                }
            }

            Console.SetCursorPosition(0, positionX);
            Console.Write('[');
            Console.Write(bar);
            bar ="";

            if (value <= maxValue)
            {
                for(int i = 0; i < maxValue - value; i++)
                {   
                    bar += emptySymbol;
                }
            }
            
            Console.Write(bar + "]");
        }
    }
}
