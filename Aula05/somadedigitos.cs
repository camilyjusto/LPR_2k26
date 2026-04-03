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

            while (quadrado > 0)
            {
                int digito = quadrado % 10;
                quadrado = quadrado / 10;
            }

            Console.WriteLine($"A soma dos dígitos do quadrado é: {quadrado}");
        }
    }
}