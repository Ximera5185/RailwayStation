using System;
using System.Collections.Generic;

namespace RailwayStation
{
    internal class RailwayStation
    {
        private readonly Dictionary<int, string> _startTravelDirections = new Dictionary<int, string>()
        {
            {1,"Иркутск"},
            {2,"Ангарск"},
            {3,"Усолье-Сибирское"},
            {4,"Тайшет"},
            {5,"Братск"}
        };

        private readonly Dictionary<int, string> _endTravelDirections = new Dictionary<int, string>()
        {
            {1,"Ростов"},
            {2,"Киринск"},
            {3,"Москва"},
            {4,"Анапа"},
            {5,"Грозный"}
        };

        private readonly Dictionary<string, int> _coordinates = new Dictionary<string, int>()
        {
            {"Иркутск",100},
            {"Ангарск",200},
            {"Усолье-Сибирское",300},
            {"Тайшет",400},
            {"Братск",500},
            {"Ростов",600},
            {"Киринск",700},
            {"Москва",800},
            {"Анапа",900},
            {"Грозный",1000}
        };

        private readonly List<TravelDirections> _travelDirections = new List<TravelDirections>();

        private readonly List<Train> _trains = new List<Train>();

        public void Work()
        {
            const string CreateTravelDirectionMenu = "1";
            const string ExitProgramMenu = "5";

            bool isWorkProgram = true;

            while (isWorkProgram)
            {
                Console.Clear();
                ShowTravelDirection();
                Console.WriteLine();
                Console.WriteLine($"Для создания направления введите {CreateTravelDirectionMenu}\n" +
                $"Для выхода из программы введите - {ExitProgramMenu}");

                string inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case CreateTravelDirectionMenu:
                        CreateDeparture();
                        break;

                    case ExitProgramMenu:
                        isWorkProgram = false;
                        break;
                }
            }
        }

        private void CreateDeparture()
        {
            int inputUserStartPoint;
            int inputUserEndPoint;

            Console.Clear();

            Console.WriteLine("Введите номер стартовой точки");

            ShowCities(_startTravelDirections);

            inputUserStartPoint = InputNumber();

            Console.WriteLine("Введите номер конечной точки");

            ShowCities(_endTravelDirections);

            inputUserEndPoint = InputNumber();

            if (_startTravelDirections.ContainsKey(inputUserStartPoint) && _endTravelDirections.ContainsKey(inputUserEndPoint))
            {
                TravelDirections travelDirection = new TravelDirections(_startTravelDirections [inputUserStartPoint], _endTravelDirections [inputUserEndPoint], _coordinates);

                _travelDirections.Add(travelDirection);

                SellTickets();
            }

            Console.Clear();
        }

        private void SellTickets()
        {
            Random random = new Random();

            int minValue = 9;
            int maxValue = 99;
            int tickets;

            tickets = UserUtils.GenerateRandomNumber(minValue,maxValue);

            Console.Clear();
            Console.WriteLine("Билеты проданы");

            Train train = new Train(tickets);

            _trains.Add(train);
        }

        private void ShowTravelDirection()
        {
            if (_travelDirections != null)
            {
                for (int index = 0; index < _travelDirections.Count; index++)
                {
                    Console.WriteLine($"Направление {_travelDirections [index].StartTravelDirection} - {_travelDirections [index].EndTravelDirection} " +
                    $" Растояние  {_travelDirections [index].Distance} Билетов {_trains [index].EnclosedPlaces} Вогонов создано {_trains [index].NumberCarriages}");
                }
            }
            else
            {
                Console.WriteLine("Направление не создано");
            }
        }

        private void ShowCities(Dictionary<int, string> cities)
        {
            foreach (KeyValuePair<int, string> city in cities)
            {
                Console.WriteLine($"{city.Key} {city.Value}");
            }
        }

        private int InputNumber()
        {
            int inputNumber = 0;

            bool isValidInput = false;

            while (isValidInput == false)
            {
                Console.Write("Введите целое число: ");
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out inputNumber);

                if (isValidInput == false)
                {
                    Console.WriteLine("Введено некорректное значение. Попробуйте снова.");
                }
            }

            return inputNumber;
        }
    }
}