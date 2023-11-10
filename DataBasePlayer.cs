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
        private const string _CommandAddPlayer = "1";
        private const string _CommandConsoleBanPlayer = "2";
        private const string _CommandRemovePlayer = "3";
        private const string _CommandExit = "4";
        private bool _isDataBaseWork = true;

        private List<Player> _players = new List<Player>();

        public void Work()
        {
            string userInput;

            while (_isDataBaseWork)
            {
                Console.WriteLine("Добро пожаловать! Доступные комманды");
                Console.WriteLine($"{_CommandAddPlayer} - Добавить игрока \n{_CommandConsoleBanPlayer} - Консоль бана \n{_CommandRemovePlayer} - Удалить игрока\n{_CommandExit} - Выход");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case _CommandAddPlayer:
                        AddPlayer();
                        break;
                    case _CommandConsoleBanPlayer:
                        BanPlayer();
                        break;
                    case _CommandRemovePlayer:
                        RemovePlayer();
                        break;
                    case _CommandExit:
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
            CheckString(out levelPlayer, out result);
            Console.WriteLine("Введите Id игрока");
            CheckString(out inputId, out int idPlayer);
            isFail = GetIdPlayer(idPlayer, idPlayer, isFail);

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

        private void CheckString(out string userInput, out int result)
        {
            userInput = " ";
            result = 0;
            bool isStringNumber;

            userInput = Console.ReadLine();
            isStringNumber = int.TryParse(userInput, out result);
        }

        private bool GetIdPlayer(int result, int idPlayer, bool isFail)
        {
            int id;
            isFail = false;

            for (int i = 0; i < _players.Count; i++)
            {
                id = _players[i].IdPlayer();

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
                CheckString(out userInput, out result);
                isFail = GetIdPlayer(result, idPlayer, isFail);

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

                CheckString(out userInput, out result);

                isFail = GetIdPlayer(result, idPlayer, isFail);

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

        public int Id { get; private set; }
        public bool IsBanned { get; private set; }

        public Player(string name, int level, int id)
        {
            _nickName = name;
            _level = level;
            Id = id;
        }

        public int IdPlayer()
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
