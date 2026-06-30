using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nt[] numeros = new int[10];i

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Qual número você deseja pesquisar?");
            int pesquisar = Convert.ToInt32(Console.ReadLine());
            
            int ocorrencia = 0;
            
            for (int n = 0; n <numeros.Length; n++){
                if(pesquisar == numeros[n]){
                    ocorrencia++;
                    Console.WriteLine($"Esse número aparece na posição: {n}");
                }
            }

            Console.WriteLine($"Esse número apareceu {ocorrencia} vezes");
        }
    }
}