using System;
using System.Collections.Generic;

namespace DateBasePlayer
{
    class Program
    {
        static void Main()
        {
            DateBase dateBase = new DateBase();
            dateBase.Work();
        }
    }

    class DateBase
    {
        private const string CommandAddPlayer = "1";
        private const string CommandConsoleBanPlayer = "2";
        private const string CommandRemovePlayer = "3";
        private const string CommandExit = "4";
        private bool _isDataBaseWork = true;

        private List<Player> _players = new List<Player>();

        public void Work()
        {
            string userInput;

            while (_isDataBaseWork)
            {
                Console.WriteLine("Добро пожаловать! Доступные комманды");
                Console.WriteLine($"{CommandAddPlayer} - Добавить игрока \n{CommandConsoleBanPlayer} - Консоль бана \n{CommandRemovePlayer} - Удалить игрока\n{CommandExit} - Выход");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case CommandAddPlayer:
                        AddPlayer();
                        break;
                    case CommandConsoleBanPlayer:
                        BanPlayer();
                        break;
                    case CommandRemovePlayer:
                        RemovePlayer();
                        break;
                    case CommandExit:
                        _isDataBaseWork = false;
                        break;
                    default:
                        Console.WriteLine("Данные не корректны");
                        break;
                }
            }
        }

        private void AddPlayer()
        {
            string nickName;
            string levelPlayer;
            string inputId;
            int result;
            bool isFail = true;

            Console.WriteLine("Введите никнейм игрока");
            nickName = Console.ReadLine();
            Console.WriteLine("Какой у него уровень");
            FindInfo(out levelPlayer, out result);
            Console.WriteLine("Введите Id игрока");
            FindInfo(out inputId, out int idPlayer);
            isFail = CheckIdPlayer(idPlayer, idPlayer, isFail);

            if (isFail == false)
            {
                _players.Add(new Player(nickName, result, idPlayer));
            }
            else
            {
                Console.WriteLine("Введены не корректные данные");
            }

            Console.ReadKey();
            Console.Clear();
        }

        private void FindInfo(out string userInput, out int result)
        {
            userInput = "";
            result = 0;
            bool isStringNumber;

            userInput = Console.ReadLine();
            isStringNumber = int.TryParse(userInput, out result);
        }

        private bool CheckIdPlayer(int result, int idPlayer, bool isFail)
        {
            int id;
            isFail = false;

            for (int i = 0; i < _players.Count; i++)
            {
                id = _players[i].GetId();

                if (id == result)
                {
                    idPlayer = i;
                    isFail = true;
                }
            }

            return isFail;
        }

        private void ShowInfoPlayers()
        {
            Console.WriteLine("Персонажи на сервере");

            for (int i = 0; i < _players.Count; i++)
            {
                Console.Write($" ");
                _players[i].ShowDetails();
            }
        }

        private void RemovePlayer()
        {
            string userInput;
            int result;
            int idPlayer = 0;
            bool isFail = false;

            if (_players.Count > 0)
            {
                ShowInfoPlayers();
                Console.WriteLine("Какого игрока удалить из сервера, ведите порядковый номер");
                FindInfo(out userInput, out result);
                isFail = CheckIdPlayer(result, idPlayer, isFail);

                if (isFail == true)
                {
                    _players.RemoveAt(idPlayer);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Данные не корректны");
                }
            }
            else
            {
                Console.WriteLine("На сервере нету не одного игрока");
            }
        }

        private void BanPlayer()
        {
            string userInput;
            int result;
            int idPlayer = 0;
            bool isFail = true;

            if (_players.Count > 0)
            {
                ShowInfoPlayers();
                Console.WriteLine("Что - бы изменить статус бана персонажа, напиши его порядковый номер");

                FindInfo(out userInput, out result);
                isFail = CheckIdPlayer(result, idPlayer, isFail);

                if (isFail == true)
                {
                    if (_players[idPlayer].IsBanned == false)
                    {
                        _players[idPlayer].Ban();
                    }
                    else
                    {
                        _players[idPlayer].Unban();
                    }

                    _players[idPlayer].ShowDetails();
                }
                else if (isFail == false)
                {
                    Console.WriteLine("Данные не корректны");
                }
            }
            else
            {
                Console.WriteLine("На сервере нету не одного игрока");
            }
        }
    }

    class Player
    {
        private string _nickName;
        private int _level;

        public Player(string name, int level, int id)
        {
            _nickName = name;
            _level = level;
            Id = id;
        }

        public int Id { get; private set; }
        public bool IsBanned { get; private set; }

        public int GetId()
        {
            return Id;
        }

        public void Unban()
        {
            IsBanned = false;
        }

        public void Ban()
        {
            IsBanned = true;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Ник персонажа - {_nickName}, его уровень - {_level}, статус бана - {IsBanned}, Id игрока {Id}");
        }
    }
}
