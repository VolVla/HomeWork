using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main()
        {
            const string CommandSetColorText = "1";
            const string CommandSetColorFonConsole = "2";
            const string CommandSetConsoleSize = "3";
            const string CommandSetWordOfWelcome = "4";
            const string CommandSetPositionCursor = "5";
            const string CommandClearConsole = "6";
            const string CommandExitProgram = "exit";
            const string CommandSetRed = "1";
            const string CommandSetGreen = "2";
            const string CommandSetBlue = "3";
            const string CommandSetYellow = "4";
            bool isExit = false;
            string userInput;
            string wordsWelcome = "Добро пожаловать в мою программу.";
            int sizeHeightConsole;
            int sizeWidthConsole;
            int heightPositionCursor;
            int widthPositionCursor;

            while (isExit == false)
            {
                Console.WriteLine(wordsWelcome + "\nЗдесь вы можете. \n 1 - Установить цвет текста.\n 2 - Установить цвет фона консоли.\n 3 - Установить размер окна консоли.\n 4 - Установить слова приветсвия в программе.\n 5 - Установить позицию курсора в консоли. \n 6 - Очистить консоль.\n 7 - Выход из программы.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSetColorText:
                        Console.WriteLine("\n 1 - Установить красный  цвет текста.\n 2 - Установить зелёный  цвет текста.\n 3 - Установить жёлтый  цвет текста.\n 4 - Установить синий  цвет текста. ");

                        switch (Console.ReadLine())
                        {
                            case CommandSetRed:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case CommandSetGreen:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case CommandSetYellow:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case CommandSetBlue:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                        }
                        break;
                    case CommandSetColorFonConsole:
                        Console.WriteLine("\n 1 - Установить красный  цвет фона.\n 2 - Установить зелёный  цвет фона.\n 3 - Установить жёлтый  цвет фона.\n 4 - Установить синий  цвет фона. ");

                        switch (Console.ReadLine())
                        {
                            case CommandSetRed:
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case CommandSetGreen:
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case CommandSetYellow:
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case CommandSetBlue:
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                        }
                        break;
                    case CommandSetConsoleSize:
                        Console.WriteLine(" Предупреждение.Размер консоли ограничен до 63.\nУстановите размер высоты окна консоли.");
                        sizeHeightConsole = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Установите размер ширины окна консоли.");
                        sizeWidthConsole = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = sizeHeightConsole;
                        Console.WindowWidth = sizeWidthConsole;
                        break;
                    case CommandSetWordOfWelcome:
                        Console.WriteLine("Введите текст приветствия в программе.");
                        wordsWelcome = Console.ReadLine();
                        break;
                    case CommandSetPositionCursor:
                        Console.WriteLine(" Установите положение высоты позиции курсора.");
                        heightPositionCursor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Установите положение ширины позиции курсора.");
                        widthPositionCursor = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(widthPositionCursor, heightPositionCursor);
                        break;
                    case CommandClearConsole:
                        Console.Clear();
                        break;
                    case CommandExitProgram:
                        Console.WriteLine("Введите слово " + CommandExitProgram + " для выхода из приложенния.");

                        if (CommandExitProgram == Console.ReadLine())
                        {
                            isExit = true;
                        }
                        break;
                }
            }
        }
    }
}
