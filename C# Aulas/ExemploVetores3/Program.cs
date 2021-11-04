using System;

namespace ExemploVetores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N]; 
            double [] dades = new double[N];    

            for (int i = 0; i < N; i++)
            {
                string[] s= Console.ReadLine().Split(' ');
                nomes[i] = s[0];    
                
                idades[i] =  int.Parse(s[1]);
                dades[i] = double.Parse(s[2]);

            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {

                soma = soma + dades[N];


            }

            double media = soma / N;
            Console.WriteLine("Altura méida: " + dades);
            

            int cont = 0;   
            for (int i = 0; cont < N; i++)
            {
                if (idades[i] < 16)
                {

                    cont++;

                }
            } 
            double porcentagem = (double) cont / N * 100.0;  

            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem + "%" );  
            Console.ReadLine();

        }
    }
}
