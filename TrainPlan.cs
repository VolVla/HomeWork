using System;
using System.Collections.Generic;

namespace TrainPlan
{
    internal class Program
    {
        static void Main()
        {
            List<string> namesStation = new List<string>();
            RailStation railStation = new RailStation();
            int numberPassengers = 0;
            bool isWork = true;

            while (isWork)
            {
                namesStation = railStation.FormationDirection(namesStation);
                numberPassengers = railStation.SellTicket();
                railStation.FormationTrain(numberPassengers, namesStation);
                railStation.SendTrain();
                Console.WriteLine($"Вы хотите выйти из программы?Нажмите Enter.\nДля продолжение работы программы нажмите любую другую клавишу");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    isWork = false;
                    Console.WriteLine("Вы вышли из программы");
                }

                Console.Clear();
                railStation.ShowInfoMarch();
            }
        }
    }

    class RailStation
    {
        private List<Train> _trainsList = new List<Train>();

        public List<string> FormationDirection(List<string> _namesStation)
        {
            Direction _direction = new Direction();
            _namesStation = _direction.Create();
            return _namesStation;
        }

        public int SellTicket()
        {
            Tickets _tickets = new Tickets();
            _tickets.Sell();
            return _tickets.ReturnNumberPassager();
        }

        public void FormationTrain(int _numberPassengers, List<string> _namesStation)
        {
            Train train = new Train();
            train.AddWagon(_numberPassengers);
            train.SaveDirection(_namesStation, _numberPassengers);
            _trainsList.Add(train);
        }

        public void SendTrain()
        {
            Console.WriteLine("Поезд отправлен\n");
        }

        public void ShowInfoMarch()
        {
            Console.WriteLine($"Назначение {_trainsList[_trainsList.Count - 1].numberFirstStation} - {_trainsList[_trainsList.Count - 1].numberSecondStation}");
            Console.WriteLine($"Количество пассажиров - {_trainsList[_trainsList.Count-1].numberPasseger}");

            if (_trainsList[_trainsList.Count - 1].GetTrainLenght() != 0)
            {
                Console.WriteLine("Состав поезда:");
                _trainsList[_trainsList.Count - 1].RenderTrain();
            }
        }
    }

    class Direction
    {
        private List<string> _namesStation = new List<string>();
        private string _firstStation = "";
        private string _secondStation = "";
        
        public List<string> Create()
        {
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Введите станцию отправления:");
                _firstStation = Console.ReadLine();
                Console.WriteLine("Введите станцию назначения");
                _secondStation = Console.ReadLine();

                if (_firstStation.ToLower() == _secondStation.ToLower())
                {
                    Console.WriteLine("Станция отправления не должна совпадать со станцией назначение");
                }
                else
                {
                    isWork = false;
                    _namesStation.AddRange(new string[] { _firstStation, _secondStation });
                }
            }
            return _namesStation;
        }
    }

    class Tickets
    {
        private int _numberPasseger = 0;

        public void Sell()
        {
            if (_numberPasseger == 0)
            {
                Random random = new Random();
                int minimumPassager = 0;
                int maximumPassager = 101;
                _numberPasseger = random.Next(minimumPassager, maximumPassager);
                Console.WriteLine($"Продано {_numberPasseger} билетов");
            }
        }

        public int ReturnNumberPassager()
        {
            return _numberPasseger;
        }
    }

    class Train
    {
        public string numberFirstStation { get; private set; }
        public string numberSecondStation { get; private set; }
        public int numberPasseger { get; private set; }

        private List<int> _typeWagons = new List<int> { 20, 40, 15 };
        private List<Wagon> _wagons = new List<Wagon>();
        private int _numberPassagersDirection = 0;

        public void AddWagon(int _numberPassengers)
        {
            if (_numberPassengers != 0 && _wagons.Count == 0)
            {
                bool isWork = true;

                while (isWork == true && _numberPassengers > 0)
                {
                    Console.WriteLine($"Колличество пассажиров : {_numberPassengers}\nВыберете Вагон: ");

                    for (int i = 0; i < _typeWagons.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.Вагоон на {_typeWagons[i]} мест");
                    }

                    bool number = int.TryParse(Console.ReadLine(), out int input);

                    if (number == true)
                    {
                        if (input <= _typeWagons.Count && _numberPassengers > 0)
                        {
                            Wagon wagon = new Wagon(_typeWagons[input - 1]);
                            _wagons.Add(wagon);
                            _numberPassengers -= _typeWagons[input - 1];
                            Console.WriteLine("Вагон добавлен");
                        }
                        else
                        {
                            Console.WriteLine("Данного вагона нет в списке или нет не распределенных пасссажиров");
                        }
                    }
                }
            }
        }

        public void SaveDirection(List<string> namesStation, int numberPasseger)
        {
            numberFirstStation = namesStation[namesStation.Count - 2];
            numberSecondStation = namesStation[namesStation.Count - 1];
            _numberPassagersDirection = numberPasseger;
            numberPasseger = _numberPassagersDirection;
        }

        public void RenderTrain()
        {
            for (int i = 0; i < _wagons.Count; i++)
            {
                Console.WriteLine($"Вагон {i + 1}. Мест:  {_wagons[i].NumberPlace}");
            }
        }

        public int GetTrainLenght()
        {
            return _wagons.Count;
        }
    }

    class Wagon
    {
        public int NumberPlace { get; private set; }

        public Wagon(int lenght)
        {
            NumberPlace = lenght;
        }
    }
}
