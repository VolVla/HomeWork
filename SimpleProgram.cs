using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string colorText;
            string colorFonConsole;
            string userInput;
            string exitText;
            string clearText;
            string wordClear = "clear";
            string wordExit = "exit";
            string wordsWelcome = "Добро пожаловать в мою программу.";
            int sizeHeightConsole;
            int sizeWidthConsole;
            int heightPositionCursor;
            int widthPositionCursor;

            while (isExit == false)
            {
                Console.WriteLine( wordsWelcome + "\nЗдесь вы можете. \n 1 - Установить цвет текста.\n 2 - Установить цвет фона консоли.\n 3 - Установить размер окна консоли.\n 4 - Установить слова приветсвия в программе.\n 5 - Установить позицию курсора в консоли. \n 6 - Очистить консоль.\n 7 - Выход из программы.");
                    userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\n 1 - Установить красный  цвет текста.\n 2 - Установить зелёный  цвет текста.\n 3 - Установить жёлтый  цвет текста.\n 4 - Установить синий  цвет текста. ");
                            colorText = Console.ReadLine();

                        switch (colorText)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "2":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "4":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;   
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n 1 - Установить красный  цвет фона.\n 2 - Установить зелёный  цвет фона.\n 3 - Установить жёлтый  цвет фона.\n 4 - Установить синий  цвет фона. ");
                        colorFonConsole = Console.ReadLine();

                        switch (colorFonConsole)
                        {
                            case "1":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "2":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "3":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "4":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine(" Предупреждение.Размер консоли ограничен до 63.\nУстановите размер высоты окна консоли.");
                            sizeHeightConsole = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Установите размер ширины окна консоли.");
                            sizeWidthConsole = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = sizeHeightConsole;
                        Console.WindowWidth = sizeWidthConsole;
                        break;
                    case "4":
                        Console.WriteLine("Введите текст приветствия в программе.");
                            wordsWelcome = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine(" Установите положение высоты позиции курсора.");
                            heightPositionCursor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Установите положение ширины позиции курсора.");
                            widthPositionCursor = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(widthPositionCursor, heightPositionCursor);
                        break;
                    case "6":
                        Console.WriteLine("Введите слово " + wordClear + " для очистки консоли.");
                            clearText = Console.ReadLine();

                        if (clearText == wordClear)
                        {
                            Console.Clear();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введите слово " + wordExit + " для выхода из приложенния.");
                        exitText = Console.ReadLine();

                        if (wordExit == exitText)
                        {
                            isExit = true;
                        }
                        break;
                }    
            }
        }
    }
}
