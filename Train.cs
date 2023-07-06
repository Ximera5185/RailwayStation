using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class Train
    {
       private readonly List<RailwayCarriage> _carriage = new List<RailwayCarriage>();

        public void FormTrain() 
        {
            CreateCarriage();
        }

        private void CreateCarriage() 
        {
            _carriage.Add(new RailwayCarriage());
        }
    }
}
