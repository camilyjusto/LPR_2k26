using System;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            double n = Convert.ToDouble(Console.ReadLine());

            if (n % 1 == 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"O número {n} é inteiro e par");
                }
                else
                {
                    Console.WriteLine($"O número {n} é inteiro e impar");
                }
            }
            else
            {
                Console.WriteLine($"O número {n} não é inteiro");
            }
        }
    }
}