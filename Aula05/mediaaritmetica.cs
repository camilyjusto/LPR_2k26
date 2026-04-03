using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos números você irá digitar;:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            int NN = 0; // Número novo
            int SA = 0; // Soma dos números anteriores

            while (contador <= quantidade - 1)
            {
                Console.WriteLine("Digite o número:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    num = NN;
                }
                else {
                    NN = num + 1;
                }
                int soma = SA + NN;
                SA = soma;
                contador++;
            }
            int media = SA / quantidade;
            Console.WriteLine($"A média aritmética desses números é: {media} ");
        }
    }
}
