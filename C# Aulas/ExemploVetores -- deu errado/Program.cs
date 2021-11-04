using System;

namespace ExemploVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variaveis N para o vetor que o user selecionará
            //  e variavel de vetor ( in[] vet; ) para criar o vetor

            int N = int.Parse(Console.ReadLine());
            int[] vet;

            Console.ReadLine();

            vet = new int[N]; // instanciação do vetor, posição dos elementos na memória

            string[] S = Console.ReadLine().Split(' '); // criação de um vetor string para separar a quantidade de números baseado em um espaço em branco.


            for (int i = 0; i < N; i++) // neste vetor a variável string vai se converter em int desde que seus dados sejam números. 
                                        // serão alcados em vetores baseado na posição i que é a = 0. 
            {
                vet[i] = int.Parse(S[i]);

            }

            for (int i = 0; i < N; i++) // aqui é o vetor para imprimir os números desajados, no caso, números negativos.
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }



        }
    }
}
