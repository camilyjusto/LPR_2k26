using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}° número:");
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
            
            if (ocorrencia > 0)
            Console.WriteLine($"Esse número apareceu {ocorrencia} vezes");
            else
            Console.WriteLine("Não foi possivel encontrar esse número.");
        }
    }
}