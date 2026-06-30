using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static string[] nomes = new string[10];
        static int[] notas = new int[10];
            
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome e a nota de 10 alunos:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}° aluno:");
                nomes[i] = Console.ReadLine();
                Console.WriteLine($"Digite a nota do {i + 1}° aluno:");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClassificarAluno();

        }
        static void ClassificarAluno()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 60)
                    Console.WriteLine($"{nomes[i]}: Reprovado");
                else if (notas[i] >= 60 && notas[i] < 80)
                    Console.WriteLine($"{nomes[i]}: Recuperação");
                else
                    Console.WriteLine($"{nomes[i]}: Aprovado");
            }
        }
    }
}