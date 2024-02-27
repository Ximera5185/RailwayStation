using System;

namespace RailwayStation
{
    internal class Train
    {
        public Train(int tickets)
        {
            FormTrain(tickets);

            EnclosedPlaces = tickets;
        }

        public int NumberSeatTrain { get; private set; }

        public int NumberCarriages { get; private set; }

        public int EnclosedPlaces { get; private set; }

        private void CreateCarriage()
        {
            RailwayCarriage railwayCarriage = new RailwayCarriage();

            NumberSeatTrain += railwayCarriage.NumberOfPassengerSeats;

            NumberCarriages++;

        }

        private void FormTrain(int tickets)
        {
            NumberCarriages = 0;

            if (tickets <= 0)
            {
                Console.Clear();
                Console.WriteLine("Для формирования состава требуется продать билеты");
                Console.ReadKey();
            }
            else
            {
                while (tickets > NumberSeatTrain)
                {
                    CreateCarriage();
                }
            }
        }
    }
}