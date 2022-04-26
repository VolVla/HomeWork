using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMapX = 0;
            int sizeMapY = 0;
            int[,] Maps = new int[sizeMapX, sizeMapY];
            string userInput;

            int[,] map = new int[sizeMapX, sizeMapY];
            bool isExit = false;
            //        char[,] mapRead = ReadMap("map1");

            string wall = "#";
            while (isExit == false)
            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine($"Для установки стены напишите 1. Для удаления стены напишите 2 Для ходьбы по карте персонажем напишите 3");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"Установка стены");
                        SizeMap(out sizeMapX, out sizeMapY);
                    //    SetPositionWall(ref sizeMapX, ref sizeMapY);
                        DrawWalls(wall, sizeMapX, sizeMapY, map);
                        break;
                    case "2":
                        Console.WriteLine($"Удаление стены");
                        break;
                    case "3":
                        Console.WriteLine($"Хождение игрока");
                        // ReadMap(mapRead);
                        break;
                    case "4":
                        Console.WriteLine($"");
                        break;
                }
            }
        }

        static void DrawWalls(string wall, int sizeMapX, int sizeMapY, int[,] map)
        {
            if (sizeMapX != sizeMapY)
            {
                for (int i = 0; i < sizeMapY; i++)
                {
                    Console.SetCursorPosition(sizeMapX, i);
                    Console.WriteLine(wall);
                }
            }
            if (sizeMapX == sizeMapY)
            {
                for (int i = 0; i < sizeMapX; i++)
                {
                    Console.SetCursorPosition(i, sizeMapY);

                    Console.Write(wall);
                }
            }
        }
        static void SetPositionWall(ref int sizeMapX, ref int sizeMapY)
        {
            Console.WriteLine($"Введите первую точку");
            sizeMapX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите вторую точку");
            sizeMapY = Convert.ToInt32(Console.ReadLine());
        }

        //static char[,] ReadMap(string mapRead)
        // {

        //  }

        static void SizeMap(out int sizeMapX,out int sizeMapY )
        {
            Console.WriteLine($"Введите количество символов.");
            sizeMapX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество строк.");
            sizeMapY = Convert.ToInt32(Console.ReadLine());
        }
    }
}
