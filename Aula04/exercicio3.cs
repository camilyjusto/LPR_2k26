using System;
using System.Diagnostics;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes de personagem:");
            Console.WriteLine("Guerreira");
            Console.WriteLine("Mago");
            Console.WriteLine("Arqueiro");
            Console.WriteLine("Escolha uma classe:");
            string classe = Console.ReadLine();

            switch (classe) {
                case "Guerreira":
                Console.WriteLine("Suas habilidades são: Ataque Pesado e Defesa Total");
                break;
                case "Mago":
                Console.WriteLine("Suas habilidades são: Bola de Fogo e Escudo de Gelo");
                break;
                case "Arqueira":
                Console.WriteLine("Suas habilidades são: Flecha Precisa e Disparo Triplo");
                break;
                default:
                Console.WriteLine("Não é uma das opções de classe");
                break;
            }
        }
    }
}