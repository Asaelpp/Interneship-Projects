using SOLIDS.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDS.Factories
{
      abstract class Transporte
    {
         public void StartTransport()
        {
            IVehicles vehicle = CreateTransport();
            
            vehicle.StartRoute();
        }

        protected abstract IVehicles CreateTransport();
    }   
}
