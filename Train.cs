using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    internal class Train
    {
    public Train( int ticcets) 
    {
            FormTrain(ticcets);
    }  
        public int NumberSeatTrain { get; private set; }
        private int _freeSpace;
        public int NumberCarriages { get; set; }

       

        public void FormTrain(int tickets)
        {

        NumberCarriages = 0;

            if (tickets <= 0) 
            {
                Console.Clear();
                Console.WriteLine("Для формирования состава требуется продать билеты");
                Console.ReadKey();
            }
            else 
            {
                     
                while (tickets > NumberSeatTrain)
                {
                   CreateCarriage();
                }
            }

        }

        public void CreateCarriage() 
        {
            RailwayCarriage railwayCarriage = new RailwayCarriage();

            NumberSeatTrain += railwayCarriage.NumberOfPassengerSeats;

            NumberCarriages++;

           
        }

    }
}
