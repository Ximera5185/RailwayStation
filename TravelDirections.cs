using System;
using System.Collections.Generic;

namespace RailwayStation
{
    internal class TravelDirections
    {
        public string StartTravelDirection { get; private set; }
        public string EndTravelDirection { get; private set; }

        public TravelDirections(string startTravelDirectiun, string endTravelDirection) 
        {
            StartTravelDirection = startTravelDirectiun;
            EndTravelDirection = endTravelDirection;
        }

        public void ShowTravelDirection()
        {
            if (_startTravelDirections.Count > 0 || _endTravelDirections.Count > 0)
            {
                Console.WriteLine($"Создано направлене {StartTravelDirection} - {EndTravelDirection}");
            }
            else
            {
                Console.WriteLine("Направление не создано");
            }
        }

   /*     private void AddCitiesStartTravelDirection()
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
        }*/
    }
}
