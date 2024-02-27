using System;

namespace RailwayStation
{
    internal class RailwayCarriage
    {
        private readonly Random _random = new Random();

        private int _minValueNumberSeats = 1;
        private int _maxValueNumberSeats = 20;

        public RailwayCarriage()
        {
            NumberOfPassengerSeats = UserUtils.GenerateRandomNumber(_minValueNumberSeats,_minValueNumberSeats);
        }

        public int NumberOfPassengerSeats { get; private set; }
    }
}