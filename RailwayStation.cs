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

        public void StartStantion()
        {

        }

        private void ShowTravelDirection()
        {
            Console.WriteLine($"Старт {_travelDirections.StartTravelDirection}\n" +
            $"Конкчная станция {_travelDirections.EndTravelDirection}");
        }
    }
}
