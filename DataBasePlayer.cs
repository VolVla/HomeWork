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
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        database.AddPlayer();
                        break;
                    case 2:
                        database.ShowInfo();
                        break;
                    case 3:
                        database.BanPlayer();
                        break;
                    case 4:
                        database.UnBanPlayer();
                        break;
                    case 5:
                        database.ShowInfo();
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
            public int Index { get; private set; }

            public Player(string name, int level, bool isBanned,int index)
            {
                Name = name;
                Level = level;
                IsBanned = isBanned;
                Index = index;
            }

            public void Ban()
            {
                IsBanned = true;
            }

            public void UnBan()
            {
                IsBanned = false;
            }

            public void ShowInfo()
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
                Console.WriteLine($"Уникальный номер игрока {Index}");
            }
        }

        class DataBase
        {
            private List<int> _idPlayers = new List<int>();
            private List<Player> _players = new List<Player>();
            private int _playerIndex;
            private int _idPlayer = 0;

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

                Console.WriteLine($"\nИгрок забанен? (Да или Нет)");
                string input = Console.ReadLine();
                bool _isBanned;

                if (input == "Да")
                {
                    _isBanned = true;
                }
                else if (input == "Нет")
                {
                    _isBanned = false;
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                    return;
                }

                _playerIndex = TryGetIndexPlayer(_playerIndex);
                _players.Add(new Player(name, level, _isBanned, _playerIndex));
                _idPlayers.Add(_playerIndex);
            }

            private int TryGetIndexPlayer(int _playerIndex)
            {
                bool isExitLoop = false;

                while (isExitLoop == false)
                {
                    Console.WriteLine("\nВведите уникальный номер игрока\n");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int _Index);

                    if (isNumber ==  false)
                    {
                        Console.WriteLine("Введено не коректное значение");
                    }
                    else if (isNumber == true)
                    {
                        _playerIndex = _Index;
                        isExitLoop = true;
                    }
                }

                return _playerIndex;
            }

            public void DeletePlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber == true )
                {
                    int id = GetIdPlayer(ref _idPlayer, ref input);
                    _idPlayers.RemoveAt(id);
                    _players.RemoveAt(id);
                    Console.WriteLine("Игрок удалён!");
                }
                else
                {
                    Console.WriteLine("Введено не коректное значение");
                }
            }

            public int GetIdPlayer(ref int _playerIndex, ref int input)
            {
                _playerIndex = _idPlayers.IndexOf(input);
                return _playerIndex;
            }
            
            public void ShowInfo()
            {
               if(_players.Count != 0)
               {
                    for(int i = 0; i < _players.Count; i++)
                    {
                        _players[i].ShowInfo();
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

                if (isNumber == true )
                {
                    int id = GetIdPlayer(ref _idPlayer, ref input);
                    
                    if(_players[id].IsBanned == false)
                    {
                        _players[id].Ban();
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

                if(isNumber == true )
                {
                    int id = GetIdPlayer(ref _idPlayer, ref input);

                    if (_players[id].IsBanned == true)
                    {
                        _players[id].UnBan();
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
