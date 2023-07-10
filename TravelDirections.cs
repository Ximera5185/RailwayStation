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
    }
}
