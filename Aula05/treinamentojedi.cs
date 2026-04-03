using System;

namespace HelloGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Digite as horas de treinamento por dia:");
           double horas = Convert.ToDouble(Console.ReadLine());
           int horasn = 1000; // horas necessárias

           double horasporsemana = horas * 5;
           double totalsemanas = horasn / horasporsemana;
           double diasuteis = totalsemanas * 5;
           double totalmeses = totalsemanas / 4.5;

           Console.WriteLine($"Você precisará de {totalsemanas} semanas, {diasuteis} dias úteis e {totalmeses} meses para se tornar um Jedi.");
        }
    }
}