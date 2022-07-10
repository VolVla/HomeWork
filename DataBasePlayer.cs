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
            int idPlayer = 0;
            DataBase database = new DataBase();
            Player player = new Player();

            while (isExit == false)
            {
                Console.WriteLine($"\nДля того чтобы добавить игрока напишите 1\nДля вывода информации о всех игроков напишите 2\nДля того чтобы Забанить игрока по ID напишите 3\nДля того чтобы Разбанить игрока по ID напишите 4\nДля того чтобы Удалить игрока по ID напишите 5\nДля того чтобы Выйти из программы 6\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        AddPlayer();
                        break;
                    case 2:
                        ShowInfo();
                        break;
                    case 3:
                        idPlayer = GetIdPlayer(idPlayer);

                        if (database._players[idPlayer].IsBanned == false)
                        {
                            database._players[idPlayer].Ban();
                            Console.WriteLine("Игрок забанен!");
                        }
                        else
                        {
                            Console.WriteLine("Игрок уже забанен!");
                        }
                        break;
                    case 4:
                        idPlayer = GetIdPlayer(idPlayer);

                        if (database._players[idPlayer].IsBanned == true)
                        {
                            database._players[idPlayer].UnBan();
                            Console.WriteLine("Игрок разбанен!");
                        }
                        else
                        {
                            Console.WriteLine("У игрока нету бана!");
                        }
                        break;
                    case 5:
                        ShowInfo();
                        idPlayer = GetIdPlayer(idPlayer);

                        if (database._idPlayers.Contains(database._idPlayers[idPlayer]))
                        {
                            database._idPlayers.RemoveAt(idPlayer);
                            database._players.RemoveAt(idPlayer);
                            Console.WriteLine("Игрок удалён!");
                        }
                        else
                        {
                            Console.WriteLine("Введено не корректное значение");
                        }
                        break;
                    case 6:
                        isExit = true;
                        break;
                }
            }

            void AddPlayer()
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

                idPlayer = player.GetIdPlayer(idPlayer);
                database._idPlayers.Add(idPlayer);
                database._players.Add(new Player(name, level, _isBanned, idPlayer));
            }

            int GetIdPlayer(int id)
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);
                id = database._idPlayers.IndexOf(input);
                return id;
            }

            void ShowInfo()
            {
                if (database._players.Count != 0)
                {
                    for (int i = 0; i < database._players.Count; i++)
                    {
                        database._players[i].ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine("В базе нету игроков");
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

        public Player(){}

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

            Console.WriteLine($"Уникальный номер игрока {Id}");
        }

        public int GetIdPlayer(int Id)
        {
            Id = CounterId();
            return Id;
        }

        private int CounterId()
        {
            Id++;
            return Id;
        }
    }

    class DataBase
    {
        public List<int> _idPlayers = new List<int>();
        public List<Player> _players = new List<Player>();
    }
}
