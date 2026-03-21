using System;

namespace PAGAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações do primeiro produto nessa sequência: Código,quantidade e Valor unitário:");
            int codigo1 = Convert.ToInt32(Console.ReadLine());
            int numero1 = Convert.ToInt32(Console.ReadLine());
            double valorunitario1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite as informações do primeiro produto nessa sequência: Código,quantidade e Valor unitário:");
            int codigo2 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double valorunitario2 = Convert.ToDouble(Console.ReadLine());
            double total = (numero1 * valorunitario1) + (numero2 * valorunitario2);

            Console.WriteLine($" O valor a ser pago será de: {total:F2}");
        }
    }
}