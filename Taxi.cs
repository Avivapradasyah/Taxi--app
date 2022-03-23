using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBaru
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        bool Duty = true;
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", Duty ? "yes" : "no");
            Console.WriteLine(" Number Of Passenger : {0} ", NumPassenger);

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang \n", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar pemumpang \n", DriverName);
        }
    }
}
