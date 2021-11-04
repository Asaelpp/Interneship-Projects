using System;

namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int []arr)
        {
            int N = arr.Length; 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1] )
                    {

                        int temp = arr[j]; 
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;  

                    }
                } 
            }


        }

        static void printArranjo(int []arr) 
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


        public static void Main()
        {
            int a,b,c,d,e, f, g,h;

            Console.WriteLine("Insira os números, 1 por 1, dando enter a cada vez que escrever um número: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());  
            c = int.Parse(Console.ReadLine());  
            d = int.Parse(Console.ReadLine());  
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            g = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            
            int []arr = {a, b, c, d, e, f, g,h};
            BubbleSort(arr);
            Console.WriteLine("");
            Console.WriteLine("Arranjo em Ordem");
            Console.WriteLine("");
            printArranjo(arr);
        }

    }
}
