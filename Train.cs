using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class Train
    {
        private readonly List<RailwayCarriage> _carriages = new List<RailwayCarriage>();

        private int _freeSpace;
        public int NumberSeatTrain { get; private set; }
        public void FormTrain(int tickets)
        {
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

        public void ShowTrain(int tickets) 
        {
            _freeSpace = NumberSeatTrain - tickets;

            Console.WriteLine($"Вагонов создано {_carriages.Count}\n" +
            $"Свего поссажирских мест в поезде {NumberSeatTrain}\n" +
            $"Мест занято {tickets}\n" +
            $"Свободных мест в поезде {_freeSpace}");

        }
        private void CreateCarriage() 
        {
            RailwayCarriage railwayCarriage = new RailwayCarriage();

            NumberSeatTrain += railwayCarriage.NumberOfPassengerSeats;

            _carriages.Add(railwayCarriage);
        }
    }
}
