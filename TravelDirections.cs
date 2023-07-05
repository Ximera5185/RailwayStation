using System;
using System.Collections.Generic;

namespace RailwayStation
{
    internal class TravelDirections
    {
        private Random _random = new Random();

        private readonly List<string> _startTravelDirections = new List<string>();
        private readonly List<string> _endTravelDirections = new List<string>();

        public string StartTravelDirection { get; private set; }
        public string EndTravelDirection { get; private set; }


        public TravelDirections()
        {
            AddCitiesStartTravelDirection();

            AddCitiesEndTravelDirection();

            int minValue = 0;
            int maxValueStartDirection = _startTravelDirections.Count;
            int maxValueEndDirection = _endTravelDirections.Count;

            StartTravelDirection = _startTravelDirections [_random.Next(minValue, maxValueStartDirection)];

            EndTravelDirection = _endTravelDirections [_random.Next(minValue, maxValueEndDirection)];
        }

        private void AddCitiesStartTravelDirection()
        {
            _startTravelDirections.Add("Иркутск");
            _startTravelDirections.Add("Ангарск");
            _startTravelDirections.Add("Усолье-Сибирское");
            _startTravelDirections.Add("Тайшет");
            _startTravelDirections.Add("Братск");
        }

        private void AddCitiesEndTravelDirection()
        {
            _endTravelDirections.Add("Ростов");
            _endTravelDirections.Add("Киринск");
            _endTravelDirections.Add("Москва");
            _endTravelDirections.Add("Анапа");
            _endTravelDirections.Add("Грозный");
        }
    }
}
