using System;

namespace Renato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha dentre as opções possíveis!! ");
            Console.WriteLine(" ");
            Console.WriteLine("1. Soma ");
            Console.WriteLine("2. Subtatração ");
            Console.WriteLine("3. Multiplicação ");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Raiz quadrada");
            Console.WriteLine("6. Potencia ");
            Console.WriteLine("7. Fatorial ");
            Console.WriteLine("8. Sair ");
            Console.WriteLine("");
            string MyOptions;
            MyOptions = Console.ReadLine();
            switch (MyOptions)
            {
                case "1":
                    Soma();
                    break;
                case "2":
                    Subtração();
                    break;
                case "3":
                    Multiplicação();
                    break;
                case "4":
                    Divisão();
                    break;
                case "5":
                    Raiz();
                    break;
                case "6":
                    Potencia();
                    break;
                case "7":
                    Fator();
                    break;
                case "8":
                    Sair();
                    break;

            }

            MainMenu();


        }

        static void Soma()
        {
            Console.WriteLine("");
            
            double A, B, soma;

            Console.WriteLine("Insira os Números para a Soma");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("");

            Console.WriteLine("O resultado da soma é: " + soma);

            Console.ReadLine();

        }

        static void Subtração()
        {
            Console.WriteLine("");

            double A, B, sub;

            Console.WriteLine("");

            Console.WriteLine("Insira os Números para a Subtração");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            sub = A - B;

            Console.WriteLine("");

            Console.WriteLine("O resultado da subtração é: " + sub);

            Console.ReadLine();


        }

        static void Multiplicação()
        {

            Console.WriteLine("");

            double A, B, Mult;

            Console.WriteLine("");

            Console.WriteLine("Insira os Números para a Multiplicação");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            Mult = A * B;

            Console.WriteLine("");

            Console.WriteLine("O resultado da Multiplicação é: " + Mult);

            Console.ReadLine();


        }

        static void Divisão()
        {
            Console.WriteLine("");

            double A, B, Div;

            Console.WriteLine("");

            Console.WriteLine("Insira os Números para a Divisão");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            Div = A / B;

            Console.WriteLine("");

            Console.WriteLine("O resultado da Divisão é: " + Div);

            Console.ReadLine();

        }

        static void Raiz()
        {
            Console.WriteLine("");

            double A, raiz;

            Console.WriteLine("Insira o número para a raiz quadrada do mesmo: ");
            A= double.Parse(Console.ReadLine());

            raiz =  Math.Sqrt(A);

            Console.WriteLine("");

            Console.WriteLine("A raiz de " + A + " é: " + raiz);

            Console.ReadLine();

        }

        static void Potencia()
        {
            Console.WriteLine("");

            double A, B, total;

            Console.WriteLine("Insira os números para a potenciação: ");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());   

            total = Math.Pow(A, B);

            Console.WriteLine("");

            Console.WriteLine("A potência de " + A + " elevado a " + B + " é de: " + total);

            Console.ReadLine();


        }

        static void Fator()
        {
            Console.WriteLine("");


            Console.WriteLine("Insira o número para a fatorização do mesmo: ");
            int a = int.Parse(Console.ReadLine());
            int fator = 1;

            for (int i = 1; i <= a; i++)
            {

                fator *= i; 

            }

            Console.WriteLine("");
            Console.WriteLine("Resultado " + fator );
            Console.ReadLine();


        }

        static void Sair()
        {
            Console.WriteLine("");
            
            Console.WriteLine("Tem certeza que deseja sair do programa? ");
            Console.WriteLine("Se sim, aperte ENTER mais uma vez.");
            Console.ReadLine();
            System.Environment.Exit(1);

        }


    }
}
