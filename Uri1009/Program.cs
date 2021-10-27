using System;
using System.Globalization;

namespace Uri1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, total, salario1;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            total = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario1 = total * 15.0 / 100 + salarioFixo;
           

            Console.WriteLine("TOTAL = R$ " + salario1.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
