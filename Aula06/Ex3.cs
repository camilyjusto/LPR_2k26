using System;

class Program
{
    int escolha1, escolha2, escolha3;
    string nome1, nome2, nome3, nome4, nome5;
    string poder1, poder2, poder3, poder4, poder5;
    string pontuacao1, pontuacao2, pontuacao3, pontuacao4, pontuacao5;
    public static void menuprincipal()
    {
        Console.WriteLine("Bem vindo ao proggrama de heróis da Marvel!");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Cadastro de heróis.");
        Console.WriteLine("2 - Seleção de equipe.");
        Console.WriteLine("3 - Equipe atual.");
        Console.WriteLine("4 - Sair.");
        int resposta = Convert.ToInt32(Console.ReadLine());

        if (resposta == 1)
        {
            cadastrarHeroi();
        }
        else if (resposta == 2)
        {
            selecionarEquipe();
        }
        else if (resposta == 3)
        {
            Equipe();
        }
        else if (resposta == 4)
        {
            Console.WriteLine("Saindo do programa...");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    public static void cadastrarHeroi()
    {
        int contador = 0;

        Console.WriteLine("Quantos heróis deseja cadastrar? (Máximo de 5)");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        while (contador < quantidade)
        {
            Console.WriteLine("Digite o nome do herói:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o poder do herói:");
            string poder = Console.ReadLine();
            Console.WriteLine("Digite a pontuação do herói:");
            string pontuacao = Console.ReadLine();

            if (contador == 0)
            {
                nome1 = nome;
                poder1 = poder;
                pontuacao1 = pontuacao;
            }
            else if (contador == 1)
            {
                nome2 = nome;
                poder2 = poder;
                pontuacao2 = pontuacao;
            }
            else if (contador == 2)
            {
                nome3 = nome;
                poder3 = poder;
                pontuacao3 = pontuacao;
            }
            else if (contador == 3)
            {
                nome4 = nome;
                poder4 = poder;
                pontuacao4 = pontuacao;
            }
            else if (contador == 4)
            {
                nome5 = nome;
                poder5 = poder;
                pontuacao5 = pontuacao;
            }

            contador++;
        }
        menuprincipal();
    }
    public static void selecionarEquipe()
    {
        Console.WriteLine("Escolha 3 heróis para formar a sua equipe:");
        Console.WriteLine($"1 - {nome1} \n 2 - {nome2} \n 3 - {nome3} \n 4 - {nome4} \n 5 - {nome5}");
        escolha1 = Convert.ToInt32(Console.ReadLine());
        escolha2 = Convert.ToInt32(Console.ReadLine());
        escolha3 = Convert.ToInt32(Console.ReadLine());
        menuprincipal();
    }

    public static void calcularPontuacaoTotal()
    {
       
    }
    static void Main()
    {
        menuprincipal();
    }
}