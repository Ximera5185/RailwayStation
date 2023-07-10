using System;
using System.Collections.Generic;

namespace RailwayStation
{
    internal class TravelDirections
    {
        public string StartTravelDirection { get; private set; }
        public string EndTravelDirection { get; private set; }
        public int Distance { get; private set; }
        public TravelDirections(string startTravelDirectiun, string endTravelDirection) 
        {
            StartTravelDirection = startTravelDirectiun;

            EndTravelDirection = endTravelDirection;
        }

        public void CalculateDistance( Dictionary<int,string> coordinates) 
        {
            int startCoordinate = 0;
            int finalCoordinate = 0;

            foreach (KeyValuePair<int,string> coordinate in coordinates)
            {
                if (coordinate.Value == StartTravelDirection)
                {
                    startCoordinate = coordinate.Key; 
                }
            }

            foreach (KeyValuePair<int, string> coordinate in coordinates)
            {
                if (coordinate.Value == EndTravelDirection)
                {
                    finalCoordinate = coordinate.Key;
                }
            }

            Distance = finalCoordinate - startCoordinate;
        }
    }
}
