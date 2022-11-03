using System;
using System.Collections.Generic;

namespace TrainPlan
{
    internal class Program
    {
        static void Main()
        {
            RailStation railStation = new RailStation();
            bool isWork = true;

            while (isWork)
            {
                railStation.CreateDirection();
                railStation.SellTickets();
                railStation.FormatedTrain();
                railStation.SaveDirection();
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
        private List<string> _direction = new List<string>();
        private List<int> _numberPassagersDirection = new List<int>();
        private const int InitialNumberPassegers = 0;
        private const string InitialNameStation = "";
        private int _numberFirstStation = 2;
        private int _numberSecondStation = 1;
        private int _numberPasseger = 0 ;
        private string _firstStation = "";
        private string _secondStation = "";
        
        public void CreateDirection()
        {
            if (_numberPasseger == 0)
            {
                Console.WriteLine("Введите станцию отправления:");
                _firstStation = Console.ReadLine();
                Console.WriteLine("Введите станцию назначения");
                _secondStation = Console.ReadLine();

                if (_firstStation.ToLower() == _secondStation.ToLower())
                {
                    Console.WriteLine("Станция отправления не должна совпадать со станцией назначение");
                    _firstStation = "";
                    _secondStation = "";
                }
            }
        }

        public void SellTickets()
        {
            if (_numberPasseger == 0)
            {
                if (_firstStation != "")
                {
                    Random random = new Random();
                    int minimumPassager = 0;
                    int maximumPassager = 101;
                    _numberPasseger = random.Next(minimumPassager, maximumPassager);
                    Console.WriteLine($"Продано {_numberPasseger} билетов");
                }
            }
        }

        public void FormatedTrain()
        {
            CreateTrain();
            _trainsList[_trainsList.Count - 1].AddWagon(_numberPasseger);
        } 

        public void CreateTrain()
        {
            Train _train = new Train();
            _trainsList.Add(_train);
        }

        public void SaveDirection()
        {
            _direction.AddRange(new string[] { _firstStation, _secondStation });
            _numberPassagersDirection.Add(_numberPasseger);
        }

        public void SendTrain()
        {
            if (_trainsList[_trainsList.Count -1].GetTrainLenght() != 0)
            {
                _numberPasseger = InitialNumberPassegers;
                _firstStation = InitialNameStation;
                _secondStation = InitialNameStation;
                Console.WriteLine("Поезд отправлен\n");
            }
        }

        public void ShowInfoMarch()
        {
            if (_direction[_direction.Count - _numberFirstStation] != "")
            {
                Console.WriteLine($"Назначение {_direction[_direction.Count - _numberFirstStation]} - {_direction[_direction.Count - _numberSecondStation]}");
                Console.WriteLine($"Количество пассажиров - {_numberPassagersDirection[_numberPassagersDirection.Count - 1]}");

                if (_trainsList[_trainsList.Count - 1].GetTrainLenght() != 0)
                {
                    Console.WriteLine("Состав поезда:");
                    _trainsList[_trainsList.Count - 1].RenderTrain();
                }
            }
            else
            {
                Console.WriteLine("Направление ещё не создано ");
            }
        }
    }

    class Train
    {
        private List<Wagon> _typeWagons = new List<Wagon> { new Wagon(20), new Wagon(40), new Wagon(15) };
        private List<Wagon> _wagons = new List<Wagon>();

        public void AddWagon(int _numberPassengers)
        {
            if (_numberPassengers != 0 && _wagons.Count == 0)
            {
                bool isWork = true;

                while (isWork == true)
                {
                    if (_numberPassengers > 0)
                    {
                        Console.WriteLine($"Колличество пассажиров : {_numberPassengers}\nВыберете Вагон: ");

                        for (int i = 0; i < _typeWagons.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.Вагоон на {_typeWagons[i].NumberPlace} мест");
                        }

                        bool Number = int.TryParse(Console.ReadLine(), out int input);

                        if (Number == true)
                        {
                            if (input <= _typeWagons.Count && _numberPassengers > 0)
                            {
                                _wagons.Add(_typeWagons[input - 1]);
                                _numberPassengers -= _typeWagons[input - 1].NumberPlace;
                                Console.WriteLine("Вагон добавлен");
                            }
                            else
                            {
                                Console.WriteLine("Данного вагона нет в списке или нет не распределенных пасссажиров");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Все пассажиры распределены");
                        isWork = false;
                    }
                }
            }
        }

        public int GetTrainLenght()
        {
            return _wagons.Count;
        }

        public void DisbandTrain()
        {
            _wagons.RemoveRange(0, _wagons.Count);
        }

        public void RenderTrain()
        {
            for (int i = 0; i < _wagons.Count; i++)
            {
                Console.WriteLine($"Вагон {i + 1}. Мест:  {_wagons[i].NumberPlace}");
            }
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
