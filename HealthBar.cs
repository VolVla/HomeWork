using System;

namespace HealthBar
{
    class Program
    {
        static void Main()
        {
            char emptySymbol = '_';
            char fillSymbol = '#';
            bool isExit = false;
            string userInput;
            string wordExit = "exit";
            string healthBar = "HealthBar";
            string manaBar = "ManaBar";
            int firstLine = 0;
            int secondLine = 1;
            int maxHealth = 10;
            int maxMana = 5;
            int percentFillBar;

            while (isExit == false)
            {
                percentFillBar = SetPercentBar(healthBar, maxHealth);
                Console.Clear();
                DrawBar(percentFillBar, maxHealth, firstLine, emptySymbol, fillSymbol);
                percentFillBar = SetPercentBar(manaBar, maxMana);
                DrawBar(percentFillBar, maxMana, secondLine, emptySymbol, fillSymbol);
                Console.WriteLine("\nДля выхода из программы напишите " + wordExit + " для продолжения напишите любой символ");
                userInput = Console.ReadLine();

                if (userInput == wordExit)
                {
                    isExit = true;
                }

                Console.Clear();
            }
        }

        static void SetPositionText()
        {
            int indexY = 0;
            int indexX = 6;
            Console.SetCursorPosition(indexX, indexY);
        }

        static int SetPercentBar(string nameBar, int maxValue)
        {
            int percent = 100;
            int percentFillBar;
            SetPositionText();
            Console.WriteLine("Введите % заполнения шкалы " + nameBar);
            int value = Convert.ToInt32(Console.ReadLine());
            percentFillBar = value * maxValue / percent;
            return percentFillBar;
        }

        static void DrawBar(int value, int maxValue, int positionX, char emptySymbol, char fillSymbol)
        {
            string bar = "[";
            char rightFrame = ']';
            int positionY = 0;

            if (value >= 0)
            {
                for (int i = 0; i < maxValue; i++)
                {
                    if (i < value)
                    {
                        bar += fillSymbol;
                    }
                    else
                    {
                        bar += emptySymbol;
                    }
                }

                Console.SetCursorPosition(positionY, positionX);
                Console.Write(bar + rightFrame);
            }
        }
    }
}
