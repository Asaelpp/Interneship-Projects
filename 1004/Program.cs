using System;
using System.Globalization;
namespace _1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
