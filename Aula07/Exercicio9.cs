using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cadeiras = new int[6, 8];


            int encerrar = 0;

            while (encerrar != 4)
            {
                Console.WriteLine("Digite 1 para reservar uma cadeira");
                Console.WriteLine("Digite 2 para cancelar uma reserva");
                Console.WriteLine("Digite 3 para mostrar as cadeiras reservadas");
                Console.WriteLine("Digite 4 para encerrar o programa");

                encerrar = Convert.ToInt32(Console.ReadLine());

                if (encerrar == 1)
                {
                    Console.WriteLine("Digite a linha da cadeira que deseja reservar (0 a 5): ");
                    int linha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a coluna da cadeira que deseja reservar (0 a 7): ");
                    int coluna = Convert.ToInt32(Console.ReadLine());

                    if (cadeiras[linha, coluna] == 0)
                    {
                        cadeiras[linha, coluna] = 1;
                        Console.WriteLine($"Cadeira {linha}, {coluna} reservada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Cadeira {linha}, {coluna} já está reservada!");
                    }
                }
                else if (encerrar == 2)
                {
                    Console.WriteLine("Digite a linha da cadeira que deseja cancelar a reserva (0 a 5): ");
                    int linha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a coluna da cadeira que deseja cancelar a reserva (0 a 7): ");
                    int coluna = Convert.ToInt32(Console.ReadLine());

                    if (cadeiras[linha, coluna] == 1)
                    {
                        cadeiras[linha, coluna] = 0;
                        Console.WriteLine($"Reserva da cadeira {linha}, {coluna} cancelada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Cadeira {linha}, {coluna} não está reservada!");
                    }
                }
                else if (encerrar == 3)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (cadeiras[i, j] == 1)
                            {
                                Console.Write($"Cadeira {i}, {j} está reservada.");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}