using System;
using System.Globalization;
namespace ExemploVetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string [] str = Console.ReadLine().Split(" ");
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(str[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine();

            double soma = 0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            double media  = soma / N;

            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
