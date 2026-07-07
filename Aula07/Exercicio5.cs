using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static string[] nomes = new string[5];
        static int[] notas = new int[5];
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
        }

        static void Aprovacao()
        {
            int aprovados = 0;
            int reprovados = 0;
            int recuperacao = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 60)
                    reprovados++;
                else if (notas[i] >= 60 && notas[i] < 80)
                    recuperacao++;
                else
                    aprovados++;
            }
            Console.WriteLine($"Aprovados: {aprovados} \n Recuperação: {recuperacao} \n Reprovado {reprovados}");
        }

        static void Media()
        {
            float total = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                total = total + numeros[i];
            }

            Console.WriteLine($"A média da turma foi de: {total / notas.Length}");
        }
    }
}