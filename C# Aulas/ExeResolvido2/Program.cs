using System;
using System.Globalization;

namespace ExeResolvido2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, base1, area, perimetro, diagonal;

            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            base1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = base1 * altura ;
            perimetro = 2 * (base1 + altura) ;
            diagonal = Math.Sqrt(Math.Pow(base1, 2.0) + Math.Pow(altura, 2.0));
            
            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));



        }
    }
}
