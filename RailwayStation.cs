﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class RailwayStation
    {
        const string CreateTravelDirectionMenu = "1";
        const string SellTicketsMenu = "2";
        const string CreateCarriage = "3";
        const string ExitProgramMenu = "5";


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

        private readonly Dictionary<int, string> _coordinates = new Dictionary<int, string>()
        {
            {100,"Иркутск"},
            {200,"Ангарск"},
            {300,"Усолье-Сибирское"},
            {400,"Тайшет"},
            {500,"Братск"},
            {600,"Ростов"},
            {700,"Киринск"},
            {800,"Москва"},
            {900,"Анапа"},
            {1000,"Грозный"}
        };

        private List<TravelDirections> _travelDirections = new List<TravelDirections>();

        private Train _train = new Train();

        public int Tickets { get; private set; }

        string inputUserCommand;
        bool isWorckProgram = true;
        public void Work()
        {



            while (isWorckProgram)
            {
                Console.Clear();

                StatusStantion();

                Console.WriteLine();
                Console.WriteLine($"Для создания направления введите {CreateTravelDirectionMenu}\n" +

                $"Для выхода из программы введите - {ExitProgramMenu}");

                inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case CreateTravelDirectionMenu:
                        CreateTravelDirection();
                        break;

                    case SellTicketsMenu:
                        SellTickets();
                        break;

                    case CreateCarriage:
                        _train.FormTrain(Tickets);
                        break;

                    case ExitProgramMenu:
                        isWorckProgram = false;
                        break;
                }
            }
        }

        private void CreateTravelDirection()
        {
            int inputUserStartPoint;
            int inputUserEndPoint;

            Console.Clear();

            Console.WriteLine("Введите номер стартовой точки");

            foreach (KeyValuePair<int, string> startTravelDirection in _startTravelDirections)
            {
                Console.WriteLine($"key: {startTravelDirection.Key} {startTravelDirection.Value}");
            }

            inputUserStartPoint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер конечной точки");

            foreach (KeyValuePair<int, string> endTravelDirection in _endTravelDirections)
            {
                Console.WriteLine($"key: {endTravelDirection.Key} {endTravelDirection.Value}");
            }

            inputUserEndPoint = Convert.ToInt32(Console.ReadLine());

            TravelDirections travelDirection = new TravelDirections(_startTravelDirections [inputUserStartPoint], _endTravelDirections [inputUserEndPoint]);

            travelDirection.CalculateDistance(_coordinates);

            _travelDirections.Add(travelDirection);

            Console.Clear();
            Console.WriteLine($"Для продажи белетов введите - {SellTicketsMenu}\n" +
            $"Для выхода из программы введите - {ExitProgramMenu}");

            inputUserCommand = Console.ReadLine();

            switch (inputUserCommand)
            {
                case SellTicketsMenu:
                    SellTickets();
                    break;
                case ExitProgramMenu:
                    isWorckProgram = false;
                    break;
            }

        }

        private void SellTickets()
        {
            Random random = new Random();

            int minValue = 9;
            int maxValue = 99;

            if (_travelDirections == null)
            {
                Console.Clear();
                Console.WriteLine("Для продажи билетов создайте направление");
                Console.ReadKey();
            }
            else
            {
                Tickets = random.Next(minValue, maxValue);

                _travelDirections [_travelDirections.Count - 1].Tickets += this.Tickets;
            }

            Console.Clear();
            Console.WriteLine("Билеты проданы");
            Console.WriteLine($"Для формирования состава введите - {CreateCarriage}");

            inputUserCommand = Console.ReadLine();
        }

        private void ShowTravelDirection()
        {
            if (_travelDirections != null)
            {
                foreach (TravelDirections travelDirection in _travelDirections)
                {
                    Console.WriteLine("Созданные направления");
                    Console.WriteLine($"Напровление : {travelDirection.StartTravelDirection} - {travelDirection.EndTravelDirection} : Растояне {travelDirection.Distance} км Билетов продано {travelDirection.Tickets}");
                }
            }
            else
            {
                Console.WriteLine("Направление не создано");
            }
        }

        /*private void ShowTicketsSatus()
        {
            if (Tickets == 0)
            {
                Console.WriteLine("Билеты не проданы");
            }
            else
            {
                Console.WriteLine($"Колличество проданных билетов - {Tickets}");
            }
        }*/

        private void StatusStantion()
        {
            Console.WriteLine("Статус станции : ");
           /* ShowTicketsSatus();*/
            ShowTravelDirection();
            _train.ShowTrain(Tickets);
        }
    }
}
