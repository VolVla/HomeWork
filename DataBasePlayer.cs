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
                Console.WriteLine($"Для того чтобы добавить игрока напишите 1\nДля вывода информации о всех игроков напишите 2\nДля того чтобы Забанить игрока по ID напишите 3\nДля того чтобы Разбанить игрока по ID напишите 4\nДля того чтобы Удалить игрока по ID напишите 5\nДля того чтобы Выйти из программы 6\n");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        database.AddPlayer();
                        break;
                    case 2:
                        database.ShowInfoPlayer();
                        break;
                    case 3:
                        database.BanPlayer();
                        break;
                    case 4:
                        database.UnBanPlayer();
                        break;
                    case 5:
                        database.ShowInfoPlayer();
                        database.DeletePlayer();
                        break;
                    case 6:
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

            public void ShowInfoPlayer()
            {
                Console.WriteLine($"Имя игрока {Name}  Уровень игрока: {Level}");

                if (IsBanned == true)
                {
                    Console.WriteLine("У игрока бан");
                }
                else if (IsBanned == false)
                {
                    Console.WriteLine("У игрока нет бана");
                }
            }
        }
        class DataBase
        {
            private string _trueAnswer = "Да";
            private string _falseAnswer = "Нет";
            private Dictionary<int, Player> _players = new Dictionary<int, Player>();
            private int _playerIndex;
            private bool _conditionPlayer;
             
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
                    return;
                }

                Console.WriteLine($"\nИгрок забанен? ({_trueAnswer} или {_falseAnswer})");
                string input = Console.ReadLine();

                if(input == _trueAnswer)
                {
                    _conditionPlayer = true;
                }
                else if (input == _falseAnswer)
                {
                    _conditionPlayer = false;
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                    return;
                }

                _players.Add(_playerIndex, new Player(name, level, _conditionPlayer));
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

            public void ShowInfoPlayer()
            {
               if(_players.Count != 0)
               {
                    for(int i = 0; i < _players.Count; i++)
                    {
                        _players[i].ShowInfoPlayer();
                        Console.WriteLine($"Уникальный номер игрока {i}");
                    }
               }
               else
               {
                    Console.WriteLine("В базе нету игроков");
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
