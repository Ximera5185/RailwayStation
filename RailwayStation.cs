﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class RailwayStation
    {
        private TravelDirections _travelDirection = new TravelDirections();
        private Train _train = new Train();

        public RailwayStation()
        {
            StartStantion();
        }

        public void StartStantion()
        {
            StartMenu();
        }

        private void StartMenu()
        {
            const string _createTravelDirectionMenu = "1";
            const string _createCarriage = "2";
            const string _exitProgramMenu = "5";

            bool isWorckProgram = true;

            string inputUserCommand;

            while (isWorckProgram)
            {
                Console.Clear();

                StatusStantion();

                Console.WriteLine();
                Console.WriteLine($"Для создания направления введите {_createTravelDirectionMenu}\n" +
                $"Для создания вакона {_createCarriage}" +
                $"Для выхода из программы введите - {_exitProgramMenu}");

                inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case _createTravelDirectionMenu:
                        _travelDirection.CreateTravelDirection();
                        break;

                    case _createCarriage:
                        _train.FormTrain();
                        break;

                    case _exitProgramMenu:
                        isWorckProgram = false;
                        break;
                }
            }
        }

        private void StatusStantion()
        {
            Console.WriteLine("Статус станции : ");
            _travelDirection.ShowTravelDirection();
        }
    }
}
