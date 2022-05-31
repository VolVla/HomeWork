using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
             bool exitIsGame = false;
            while (exitIsGame == false)
            {
               
                int pacmanX = 0;
                int pacmanY = 0;
                int numberLine = 0 ;
                int numberColumn = 0;
                char hero = '@';
                char[,] map; 
                const int CreateMap = 1;
                const int PlayGame = 2;
                Console.WriteLine($"Для создание карты и редактирования напишите {CreateMap},для игры на карте напишите {PlayGame}");
                int number;
                number = Convert.ToInt32(Console.ReadLine());
                
                switch (number)
                {
                    case CreateMap:
                        SizeMap(out numberLine, out numberColumn);
                      //  charArray = new char[numberLine, numberColumn];
                      map = ConstructMap(numberLine, numberColumn, ref pacmanX,ref pacmanY, hero);
                        DrawMap(map);
                        break;
                    case PlayGame:
                        DrawMap(map);
                        PlayGames( pacmanX,  pacmanY, hero);

                        break;
                }
            } 
        }

        static void PlayGames(  int pacmanY, int pacmanX,char hero)
        {
          //  Console.CursorVisible = false;
            bool isPlaying = true;
            
            while (isPlaying == true)
            {
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(hero);
            }
        }

        static void SizeMap(out int numberLine, out int numberColumn)
        {
            Console.WriteLine($"Введите количество символов в строке карты");
            numberLine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество столбцов в карте");
            numberColumn = Convert.ToInt32(Console.ReadLine());
            
        }

        static char[,] ConstructMap( int numberLine, int numberColumn, ref int pacmanX,  ref int pacmanY,char hero)
        {
           
            bool exit = false;
            string line;
            char[,] charArray = new char[numberLine, numberColumn];


            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                exit = false;
                Console.WriteLine($"Введите {i + 1} строку карты");

                while (exit == false)
                {
                    line = Console.ReadLine();

                    if (line.Length == numberLine)
                    {
                        for (int j = 0; j < line.Length; j++)
                        {
                            charArray[i, j] = line[j];

                            if(charArray[i,j] == hero)
                            {
                                pacmanX = i;
                                pacmanY = j;
                            }
                            exit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Ввдено не коректное значение символов");

                        if (line.Length < numberLine)
                        {
                            Console.WriteLine($"Добавьте {numberLine - line.Length} символа");
                        }
                        else
                        {
                            Console.WriteLine($"Уберите {line.Length - numberLine} символа");
                        }
                    }
                }
            }
            return charArray;
            // сдесь надо сделать возрат массива символов в глобальную переменую
        }

        static void DrawMap( char [,] maps)
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
    }
}

