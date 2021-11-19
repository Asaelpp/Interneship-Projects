using SOLIDS.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDS.Factories
{
    internal class CarTransport : Transporte
    {
        protected override IVehicles CreateTransport()
        {
            return new Car();
        }
    }
}
