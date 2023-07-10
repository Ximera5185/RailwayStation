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
                        _travelDirection.CreateTravelDirection();
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
