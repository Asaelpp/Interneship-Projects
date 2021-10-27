using System;
using System.Globalization;
namespace salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, numero;
            double salarioH, salarioT;

            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioH = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            salarioT = salarioH * horas;


            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$" + salarioT.ToString("F2"));
        }
    }
}
