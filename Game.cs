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
            int numberSymbolsInLine;
            int numberSymbolsInColumn;
            char hero = '@';
            char wall = '#';
            char coin = '$';
            char[,] map;
            
            Console.WriteLine($"Для создайти карту для игры");      
            SizeMap(out numberSymbolsInLine, out numberSymbolsInColumn);
            map = ConstructMap(numberSymbolsInLine, numberSymbolsInColumn, ref heroPositionX, ref heroPositionY, hero, coin, ref allMoney);
            Console.Clear();
            DrawMap(map);
            PlayGames(heroPositionX, heroPositionY, hero, map, wall, ref money, coin, ref allMoney);
        }

        static void SizeMap(out int numberSymbolsInLine, out int numberSymbolsInColumn)
        {
            Console.WriteLine($"Введите количество символов в строке карты");
            numberSymbolsInLine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество столбцов в карте");
            numberSymbolsInColumn = Convert.ToInt32(Console.ReadLine());
        }
    
        static char[,] ConstructMap(int numberSymbolsInLine, int numberSymbolsInColumn, ref int heroPositionX, ref int heroPositionY, char hero, char coin, ref int allMoney)
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

                            if(arraySymbols[i,j] == hero)
                            {
                                heroPositionX = j;
                                heroPositionY = i;
                            }
                            
                            if(arraySymbols[i,j] == coin)
                            {
                                allMoney++;
                            }

                            exitLoop = true;
                        }
                    }
                    else
                    {
                        InCorrectNumberSymbols(symbolsInLine, numberSymbolsInLine);
                    }
                }
            }

            return arraySymbols;
        }   

        static void InCorrectNumberSymbols(string symbolsInLine, int numberSymbolsInLine)
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

        static void DrawMap(char [,] maps)
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

        static void PlayGames(int heroPositionX, int heroPositionY, char hero, char[,] map, char wall, ref int money, char coin, ref int allMoney)
        {
            bool isPlaying = true;
            int heroPositionDx = 0;
            int heroPositionDy = 1;

            Console.CursorVisible = false;

            while (isPlaying == true)
            {
                Console.SetCursorPosition(0, 25);
                Console.WriteLine($"Собрано монеток {money}/{allMoney}");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ChangeDirection(key, ref heroPositionDx, ref heroPositionDy);
                    
                    if (map[heroPositionX + heroPositionDx, heroPositionY + heroPositionDy] != wall )
                    {
                        Move(ref heroPositionX, ref heroPositionY, heroPositionDx, heroPositionDy, hero);
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
                Console.Write($"Вы собрали все монетки");
            }
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int valueStepDirectionX, ref int valueStepDirectionY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    valueStepDirectionX = -1; valueStepDirectionY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    valueStepDirectionX = 1; valueStepDirectionY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    valueStepDirectionX = 0; valueStepDirectionY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    valueStepDirectionX = 0; valueStepDirectionY = -1;
                    break;
            }
        }

        static void Move(ref int heroPositionX, ref int heroPositionY, int valueStepDirectionX, int valueStepDirectionY, char hero)
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
