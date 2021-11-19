using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDS.Vehicles
{
    internal class Car : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passgeiros");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando o Trajeto");
        }
    }
}
