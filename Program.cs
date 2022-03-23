using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBaru
{
    class Program
    {
            static void Main(string[] args)
        {
                // membuat objek Taxi
                Taxi taxi = new Taxi();

                // pengesetan nilai properties
                taxi.DriverName = "abdul";
                taxi.OnDuty = true;
                taxi.NumPassenger = 10;

                // pengembalian method
                taxi.TaxiInfo();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();

                Console.ReadKey();
           
        }
    }
}
