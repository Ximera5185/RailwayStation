﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class RailwayStation
    {
        private List<TravelDirections> _travelDirections = new List<TravelDirections>();

        private readonly Dictionary<int,string> _startTravelDirections = new Dictionary<int, string>() 
        {
            {1,"Иркутск"},
            {2,"Ангарск"},
            {3,"Усолье-Сибирское"},
            {4,"Тайшет"},
            {5,"Братск"}
        };
        
        private readonly Dictionary<int,string> _endTravelDirections = new Dictionary<int, string>() 
        {
            {1,"Ростов"},
            {2,"Киринск"},
            {3,"Москва"},
            {4,"Анапа"},
            {5,"Грозный"}
        };

        private Train _train = new Train();

        private int Tickets { get; set; }

        public void Work()
        {
            const string CreateTravelDirectionMenu = "1";
            const string SellTicketsMenu = "2";
            const string CreateCarriage = "3";
            const string ExitProgramMenu = "5";

            bool isWorckProgram = true;

            string inputUserCommand;

            while (isWorckProgram)
            {
                Console.Clear();

                StatusStantion();

                Console.WriteLine();
                Console.WriteLine($"Для создания направления введите {CreateTravelDirectionMenu}\n" +
                $"Для продажи белетов введите - {SellTicketsMenu}\n" +
                $"Для формирования состава введите - {CreateCarriage}\n" +
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

            Console.WriteLine("Введите номер стартовой точеи");

            foreach (var item in _startTravelDirections)
            {
                Console.WriteLine($"key: {_startTravelDirections.Count}  value: {_startTravelDirections.Values}");
            }

            inputUserStartPoint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер конечной точеи");

            foreach (var item in _endTravelDirections)
            {
                Console.WriteLine($"key: {_endTravelDirections.Count}  value: {_endTravelDirections.Values}");
            }

            inputUserEndPoint = Convert.ToInt32(Console.ReadLine());

            TravelDirections travelDirection = new TravelDirections(_endTravelDirections[inputUserEndPoint],_endTravelDirections[inputUserEndPoint]);

            _travelDirections.Add(travelDirection);
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
            }
        }

        private void ShowTicketsSatus()
        {
            if (Tickets == 0)
            {
                Console.WriteLine("Билеты не проданы");
            }
            else
            {
                Console.WriteLine($"Колличество проданных билетов - {Tickets}");
            }
        }
        private void StatusStantion()
        {
            Console.WriteLine("Статус станции : ");
            ShowTicketsSatus();
            _travelDirection.ShowTravelDirection();
            _train.ShowTrain(Tickets);
        }
    }
}
