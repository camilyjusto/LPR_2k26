using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static string[] nomes = new string[5];
        static int[] notas = new int[5];
        static string[] resultado = new string[5];
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome e nota de 5 alunos pra o relatório:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}° aluno:");
                nomes[i] = Console.ReadLine();
                Console.WriteLine($"Digite a nota do {i + 1}° aluno:");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------- Relatório --------");
            Aprovacao();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Aluno: {nomes[i]} - Nota: {notas[i]} - Resultado: {resultado[i]}");
            }
            Media();
        }

        static void Aprovacao()
        {
            int aprovado = 0;
            int reprovado = 0;
            int recuperacao = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 60)
                {
                    resultado[i] = "Reprovado";
                    reprovado++;
                }
                else if (notas[i] >= 60 && notas[i] < 80)
                {
                    resultado[i] = "Recuperação";
                    recuperacao++;
                }
                else
                {
                    resultado[i] = "Aprovado";
                    aprovado++;
                }
            }

            Console.WriteLine($"Aprovados: {aprovado}");
            Console.WriteLine($"Recuperação: {recuperacao}");
            Console.WriteLine($"Reprovados: {reprovado}");
        }

        static void Media()
        {
            float total = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                total = total + notas[i];
            }

            Console.WriteLine($"A média da turma foi de: {total / notas.Length}");
        }
    }
}