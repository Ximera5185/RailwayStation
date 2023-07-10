using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class RailwayCarriage
    {
        private readonly Random _random = new Random();

        private int _minValueNumberSeats = 1;
        private int _maxValueNumberSeats = 20;

        public RailwayCarriage()
        {
            NumberOfPassengerSeats = _random.Next(_minValueNumberSeats, _maxValueNumberSeats);
        }

        public int NumberOfPassengerSeats { get; private set; }

        public int Mileage { get; set; }
    }
}
