using System;

namespace PacMan
{
    class Program
    {
        static void Main()
        {
            int money = 0;
            int allMoney = 0;
            int heroPositionX = 0;
            int heroPositionY = 0;
            int quantitySymbolsLine;
            int quantitySymbolsColumn;
            char hero = '@';
            char wall = '#';
            char coin = '$';
            char[,] map;

            Console.WriteLine($"Добро пожаловать в создание карты.");
            SetSizeMap(out quantitySymbolsLine, out quantitySymbolsColumn);
            Console.WriteLine($"Для создание стены используете символ {wall},\nДля создание монетки используете символ {money},\nДля создание игрока используете символ {hero}");
            map = CreateMap(quantitySymbolsLine, quantitySymbolsColumn, ref heroPositionX, ref heroPositionY, hero, coin, ref allMoney);
            Console.Clear();
            DrawMap(map);
            PlayGame(heroPositionX, heroPositionY, hero, map, wall, ref money, coin, ref allMoney);
        }

        static void SetSizeMap(out int numberSymbolsInLine, out int numberSymbolsInColumn)
        {
            Console.WriteLine($"Введите количество символов в строке карты");
            int.TryParse(Console.ReadLine(), out int quantityLine);
            numberSymbolsInLine = quantityLine;
            Console.WriteLine($"Введите количество столбцов в карте");
            int.TryParse(Console.ReadLine(), out int quantityColumn);
            numberSymbolsInColumn = quantityColumn;
        }

        static char[,] CreateMap(int numberSymbolsInLine, int numberSymbolsInColumn, ref int heroPositionX, ref int heroPositionY, char hero, char coin, ref int allMoney)
        {
            bool exitLoop;
            string symbolsInLine;
            char[,] arraySymbols = new char[numberSymbolsInLine, numberSymbolsInColumn];

            for (int i = 0; i < arraySymbols.GetLength(0); i++)
            {
                exitLoop = false;
                Console.WriteLine($"Введите {i + 1} строку карты");

                while (exitLoop == false)
                {
                    symbolsInLine = Console.ReadLine();

                    if (symbolsInLine.Length == numberSymbolsInLine)
                    {
                        for (int j = 0; j < symbolsInLine.Length; j++)
                        {
                            arraySymbols[i, j] = symbolsInLine[j];

                            if (arraySymbols[i, j] == hero)
                            {
                                heroPositionX = j;
                                heroPositionY = i;
                            }

                            if (arraySymbols[i, j] == coin)
                            {
                                allMoney++;
                            }

                            exitLoop = true;
                        }
                    }
                    else
                    {
                        CheckCorrectNumberSymbols(symbolsInLine, numberSymbolsInLine);
                    }
                }
            }

            return arraySymbols;
        }

        static void CheckCorrectNumberSymbols(string symbolsInLine, int numberSymbolsInLine)
        {
            Console.WriteLine($"Ввдено не коректное значение символов");

            if (symbolsInLine.Length < numberSymbolsInLine)
            {
                Console.WriteLine($"Добавьте {numberSymbolsInLine - symbolsInLine.Length} символа");
            }
            else
            {
                Console.WriteLine($"Уберите {symbolsInLine.Length - numberSymbolsInLine} символа");
            }
        }

        static void DrawMap(char[,] maps)
        {
            for (int i = 0; i < maps.GetLength(0); i++)
            {
                for (int j = 0; j < maps.GetLength(1); j++)
                {
                    Console.Write(maps[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void PlayGame(int heroPositionX, int heroPositionY, char hero, char[,] map, char wall, ref int money, char coin, ref int allMoney)
        {
            bool isPlaying = true;
            int heroPositionDirectionX = 0;
            int heroPositionDirectionY = 1;

            Console.CursorVisible = false;

            while (isPlaying == true)
            {
                Console.SetCursorPosition(0, 25);
                Console.WriteLine($"Собрано монеток {money}/{allMoney}");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ChangeDirection(key, ref heroPositionDirectionX, ref heroPositionDirectionY);

                    if (map[heroPositionX + heroPositionDirectionX, heroPositionY + heroPositionDirectionY] != wall)
                    {
                        MovePlayer(ref heroPositionX, ref heroPositionY, heroPositionDirectionX, heroPositionDirectionY, hero);
                        CollectCoins(heroPositionX, heroPositionY, map, ref money, coin);
                    }
                }

                if (money == allMoney)
                {
                    isPlaying = false;
                }
            }

            Console.SetCursorPosition(0, 26);

            if (money == allMoney)
            {
                Console.WriteLine($"Вы собрали все монетки");
            }
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int valueStepDirectionX, ref int valueStepDirectionY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    valueStepDirectionX = -1;
                    valueStepDirectionY = 0;
                    break;

                case ConsoleKey.DownArrow:
                    valueStepDirectionX = 1;
                    valueStepDirectionY = 0;
                    break;

                case ConsoleKey.RightArrow:
                    valueStepDirectionX = 0;
                    valueStepDirectionY = 1;
                    break;

                case ConsoleKey.LeftArrow:
                    valueStepDirectionX = 0;
                    valueStepDirectionY = -1;
                    break;
            }
        }

        static void MovePlayer(ref int heroPositionX, ref int heroPositionY, int valueStepDirectionX, int valueStepDirectionY, char hero)
        {
            Console.SetCursorPosition(heroPositionY, heroPositionX);
            Console.Write(" ");
            heroPositionX += valueStepDirectionX;
            heroPositionY += valueStepDirectionY;
            Console.SetCursorPosition(heroPositionY, heroPositionX);
            Console.Write(hero);
        }

        static void CollectCoins(int heroPositionX, int heroPositionY, char[,] map, ref int money, char coins)
        {
            if (map[heroPositionX, heroPositionY] == coins)
            {
                money++;
                map[heroPositionX, heroPositionY] = ' ';
            }
        }
    }
}
