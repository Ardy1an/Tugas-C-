using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspemrograman
{
    internal class TaxiInfo
    {
        static void Main(string[] args)
        {
            //class sebelumnya "program" harus dipanggil disini agar var bisa terdeteksi
            Program taxi = new Program();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
                 
        }
    }
}
