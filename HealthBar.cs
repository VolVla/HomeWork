using System;

namespace HealthBar
{
    class Program
    {
        static void Main()
        {
            char fillSymbol = '#';
            bool isExit = false;
            string userInput;
            string wordExit = "exit";
            int firstLine = 0;
            int maxHealth = 10;
            double percentFillBar;

            while (isExit == false)
            {
                percentFillBar = SetPercentBar();
                DrawBar(maxHealth, percentFillBar, firstLine, fillSymbol);
                Console.WriteLine("\nДля выхода из программы напишите " + wordExit + " для продолжения напишите любой символ");
                userInput = Console.ReadLine();

                if (userInput == wordExit)
                {
                    isExit = true;
                }

                Console.Clear();
            }
        }

        static double SetPercentBar()
        {
            Console.WriteLine($"\nВведите % текущей шкалы");
            double.TryParse(Console.ReadLine(), out double percentFill);
            Console.Clear();
            return percentFill;
        }

        static void DrawBar(int lenghtBar, double percent, int positionX, char fillSymbol)
        {
            int maximumPercentFillBar = 100;
            int minumumPercentFillBar = 0;

            if (percent >= minumumPercentFillBar && percent <= maximumPercentFillBar)
            {
                string bar = "";
                char rightFrame = ']';
                char emptySymbol = '_';
                int positionY = 0;
                int currentValue = (int)Math.Round(lenghtBar * (percent / maximumPercentFillBar));

                Console.SetCursorPosition(positionY, positionX);
                Console.Write("[");

                for (int i = 0; i < lenghtBar; i++)
                {
                    if (i < currentValue)
                    {
                        bar += fillSymbol;
                    }
                    else
                    {
                        bar += emptySymbol;
                    }
                }

                Console.Write(bar + rightFrame);
            }
        }
    }
}
