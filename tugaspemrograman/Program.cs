using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspemrograman
{
    internal class Program
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (OnDuty == true)
                Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOfPassenger()
        {
                Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }


          
    }
}
