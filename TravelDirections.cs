using System.Collections.Generic;

namespace RailwayStation
{
    internal class TravelDirections
    {
        public string StartTravelDirection { get; private set; }
        public string EndTravelDirection { get; private set; }
        public int Distance { get; private set; }

        public TravelDirections(string startTravelDirectiun, string endTravelDirection, Dictionary<string,int> coordinates) 
        {
            StartTravelDirection = startTravelDirectiun;

            EndTravelDirection = endTravelDirection;

            CalculateDistance(coordinates);
        }

        public void CalculateDistance( Dictionary<string,int> coordinates) 
        {
           int startCoordinate = coordinates [StartTravelDirection];
           int finalCoordinate = coordinates [EndTravelDirection];

            Distance = finalCoordinate - startCoordinate;
        }
    }
}