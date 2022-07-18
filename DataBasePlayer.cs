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
            bool isExit = false;
            DataBase database = new DataBase();

            while (isExit == false)
            {
                Console.WriteLine($"\nДля того чтобы добавить игрока напишите 1\nДля вывода информации о всех игроков напишите 2\nДля того чтобы Забанить игрока по ID напишите 3\nДля того чтобы Разбанить игрока по ID напишите 4\nДля того чтобы Удалить игрока по ID напишите 5\nДля того чтобы Выйти из программы 6\n");
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
    }

    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public bool IsBanned { get; private set; }
        public int Id { get; private set; }

        public Player()
        {
            
        }

        public Player(string name, int level, bool isBanned, int id)
        {
            Name = name;
            Level = level;
            IsBanned = isBanned;
            Id = id;
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

            Console.WriteLine($"Уникальный номер игрока {Id - 1}");
        }

    } 
     
    class DataBase
    {
        private int _playerIndex;
        public DataBase()
        {
            _playerIndex = 0;
        }

        Player player = new Player();
        int idPlayer = 0;
        public List<Player> _players = new List<Player>();
        bool isNumber;
        

        public void AddPlayer()
        {
            Console.WriteLine("\nВведите имя игрока: \n");
            string name = Console.ReadLine();
            Console.WriteLine("\nВведите уровень игрока: \n");
            bool isNumber = int.TryParse(Console.ReadLine(), out int level);

            if (isNumber == false)
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

            _playerIndex++;
            _players.Add(new Player(name, level, _isBanned, _playerIndex));
        }

        public int GetPlayerId()
        {
            Console.WriteLine("\nВведите уникальный номер игрока\n");
            isNumber = int.TryParse(Console.ReadLine(), out int input);

            for(int i = 0; i < _players.Count; i++)
            {
                if(player.Id == input)
                {
                    idPlayer = player.Id;
                    
                }
                else
                {
                    Console.WriteLine("Неккоректный ввод");
                    break;
                }
            }
            return idPlayer;
            /*if (_players.Contains(_players[input]) == true)
            {
                _players.IndexOf(_players[input]);
            }*/
            
        }

        public void ShowInfo()
        {
            if (_players.Count != 0)
            {
                for (int i = 0; i < _players.Count; i++)
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
            int idads;
            idads = GetPlayerId();

            if (isNumber == true   )
            {
                if (_players[idads].IsBanned == false) 
                {
                    _players[idads].Ban();
                    Console.WriteLine("Игрок забанен!");
                }
                else
                {
                    Console.WriteLine("Игрок уже забанен!");
                }
            }
            else
            {
                Console.WriteLine("Неккоректный ввод");
            }
            
        }

        public void UnBanPlayer()
        {
           

            if (_players.Contains(player) == false & isNumber == true)
            {
                if (_players[idPlayer].IsBanned == true)
                {
                    _players[idPlayer].UnBan();
                    Console.WriteLine("Игрок разбанен!");
                }
                else
                {
                    Console.WriteLine("У игрока нету бана!");
                }
            }
            else
            {
                Console.WriteLine("Неккоректный ввод");
            }
        }

        public void DeletePlayer()
        {
            

            if (_players.Contains(player) == true & isNumber == true)
            {
                if (_players.Contains(_players[idPlayer]))
                {
                    _players.RemoveAt(idPlayer);
                    Console.WriteLine("Игрок удалён!");
                }
                else
                {
                    Console.WriteLine("Введено не корректное значение");
                }
            }
            else
            {
                Console.WriteLine("Неккоректный ввод");
            }
        }
    }
}
