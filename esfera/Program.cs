using System;
using System.Globalization;
namespace esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14159, conta, raio;

            raio = double.Parse(Console.ReadLine());

            conta = (4.0/3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + conta.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
