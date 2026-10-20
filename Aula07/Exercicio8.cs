using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];

            Console.Write($"Digite os valores da matriz A: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor (numero inteiro) para a posição {i} e {j}: ");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write($"Digite os valores da matriz B: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor (numero inteiro) para a posição {i} e {j}: ");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] C = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}