using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDS.Vehicles
{
    internal class Motorcycle : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            Console.WriteLine("Inianco a entreha");
        }
    }
}
