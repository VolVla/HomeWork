using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBasePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase database = new DataBase();
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine($"Для того чтобы добавить игрока напишите 1\nДля того чтобы Забанить игрока по ID напишите 2\nДля того чтобы Разбанить игрока по ID напишите 3\nДля того чтобы Удалить игрока по ID напишите 4\nДля того чтобы Выйти из программы 5\n");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        database.AddPlayer();
                        break;
                    case 2:
                        database.BanPlayer();
                        break;
                    case 3:
                        database.UnBanPlayer();
                        break;
                    case 4: 
                        database.DeletePlayer();
                        break;
                    case 5:
                        isExit = true;
                        break;
                }
            }
        }

        class Player
        {
            public string Name  { get; private set;}
            public int Level { get; private set; }
            public bool IsBanned { get; private set; }

            public Player(string name, int level, bool isBanned)
            {
                Name = name;
                Level = level;
                IsBanned = isBanned;
            }

            public void Ban()
            {
                IsBanned = true;
            }

            public void UnBan()
            {
                IsBanned = false;
            }
        }
        class DataBase
        {
            const string TRUEANSWER = "Да";
            const string FALSEANSWER = "Нет";
            private Dictionary<int, Player> _players = new Dictionary<int, Player>();
            private int _playerIndex;
            bool isBanned;

            public DataBase()
            {
                _playerIndex = 0;
            }

            public void AddPlayer()
            {
                Console.WriteLine("\nВведите имя игрока: \n");
                string name = Console.ReadLine();
                Console.WriteLine("\nВведите уровень игрока: \n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int level);

                if(isNumber == false)
                {
                    Console.WriteLine("Уровень должен содержать только числа");
                }

                Console.WriteLine($"\nИгрок забанен? ({TRUEANSWER} или {FALSEANSWER})");
                string input = Console.ReadLine();

                if(input == TRUEANSWER)
                {
                    isBanned = true;
                }
                else if (input == FALSEANSWER)
                {
                    isBanned = false;
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                }

                _players.Add(_playerIndex, new Player(name, level, isBanned));
                _playerIndex++;
            }

            public void DeletePlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber == true && _players.ContainsKey(input) == true)
                {
                    _players.Remove(input);
                    Console.WriteLine("Игрок удалён!");
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                }
                
            }

            public void BanPlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber == true && _players.ContainsKey(input) == true)
                {
                    if(_players[input].IsBanned == false)
                    {
                        _players[input].Ban();
                        Console.WriteLine("Игрок забанен!");
                    }
                    else
                    {
                        Console.WriteLine("Игрок уже забанен!");
                    }
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                }
            }

            public void UnBanPlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if(isNumber == true && _players.ContainsKey(input) == true)
                {
                    if(_players[input].IsBanned == true)
                    {
                        _players[input].UnBan();
                        Console.WriteLine("Игрок разбанен");
                    }
                    else
                    {
                        Console.WriteLine("У игрока нету бана!");
                    }
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                }
            }
        }
    }
}
