

using SOLIDS.Factories;
using System;

namespace SOLIDS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Transporte transport = null ;

            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport(); 
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de veículo");
            }

            if (transport != null)
            {
                transport.StartTransport();
            }
        }
    }
}
