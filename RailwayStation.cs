using System;
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

        private int Tickets { get; set; }
        public void StartStantion()
        {
            StartMenu();
        }

        private void StartMenu()
        {
            const string _createTravelDirectionMenu = "1";
            const string _sellTicketsMenu = "2"; 
            const string _createCarriage = "3";
            const string _exitProgramMenu = "5";

            bool isWorckProgram = true;

            string inputUserCommand;

            while (isWorckProgram)
            {
                Console.Clear();

                StatusStantion();

                Console.WriteLine();
                Console.WriteLine($"Для создания направления введите {_createTravelDirectionMenu}\n" +
                $"Для продажи белетов введите - {_sellTicketsMenu}\n" +
                $"Для формирования состава введите - {_createCarriage}\n" +
                $"Для выхода из программы введите - {_exitProgramMenu}");

                inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case _createTravelDirectionMenu:
                        _travelDirection.CreateTravelDirection();
                        break;

                    case _sellTicketsMenu:
                        SellTickets();
                        break;

                    case _createCarriage:
                        _train.FormTrain(Tickets);
                        break;

                    case _exitProgramMenu:
                        isWorckProgram = false;
                        break;
                }
            }
        }

        private void SellTickets() 
        {
            Random random = new Random();

            int minValue = 9;
            int maxValue = 99;

            if (_travelDirection.StartTravelDirection == null || _travelDirection.EndTravelDirection == null)
            {
                Console.Clear();
                Console.WriteLine("Для продажи билетов создайте направление");
                Console.ReadKey();
            }
            else
            {
                Tickets = random.Next( minValue, maxValue );
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
