using System;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int quadrado = num * num;
            
            int armazena = quadrado;
            int soma = 0;

            while (armazena > 0)
            {
                int digito = armazena % 10;
                soma += digito;
                armazena = armazena / 10;
            }

            Console.WriteLine($"A soma dos dígitos do quadrado é: {soma}");
        }
    }
}