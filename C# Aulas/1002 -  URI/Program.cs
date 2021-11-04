using System;
using System.Globalization;

namespace _1002____URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio, N = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = N * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));



        }
    }
}
