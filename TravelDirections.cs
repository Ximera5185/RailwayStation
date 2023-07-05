using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class TravelDirections
    {
        Random random = new Random();

        private List<string> _startTravelDirections = new List<string>();

        private List<string> _endTravelDirections = new List<string>();
        public string StartTravelDirection{get;private set;}
        public string EndTravelDirection{ get;private set;}

        private void AddCitiesStartTravelDirection() 
        {
            _startTravelDirections.Add("Иркутск");
            _startTravelDirections.Add("Ангарск");
            _startTravelDirections.Add("Усолье-Сибирское");
            _startTravelDirections.Add("Тайшет");
            _startTravelDirections.Add("Братск");
        }
    }
}
