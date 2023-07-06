using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class RailwayStation
    {

        private readonly TravelDirections _travelDirections = new TravelDirections();
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
            const string _exitProgramMenu = "5";

            bool isWorckProgram = true;
            string inputUserCommand = "";

            while (isWorckProgram)
            {
                StatusStantion();

                Console.WriteLine($"Для создания направления введите {_createTravelDirectionMenu}\n" +
                $"Для выхода из программы введите - {_exitProgramMenu}");

                inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case _createTravelDirectionMenu:
                        StartMenu();
                        break;

                    case _exitProgramMenu:
                        isWorckProgram = false;
                        break;
                }
            }
        }
        private void ShowTravelDirection()
        {
            Console.WriteLine($"Создано направлене {_travelDirections.StartTravelDirection}\n" +
            $"Конкчная станция {_travelDirections.EndTravelDirection}");
        }

        private void StatusStantion()
        {
            ShowTravelDirection();
        }
    }
}
