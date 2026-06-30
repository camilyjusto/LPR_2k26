using System;
// Declaração da Struct
public struct Livro {
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;
    public int NumeroPaginas;
    public double Preco;
}

public static void inserir()
{
    Console.WriteLine("Informações primeiro livro:");

}
class aula9 {
    static void Main(){
        // Definindo um vetor para armazenar 
        Livro[] livros = new livros[3];

        // Inicializando os dados dos alunos
        Console.WriteLine("Cadastre três livros:");
        // Calculando a média da idade dos alunos
        float somaPreco = 0;
        foreach (Livro custo in livros){
            somaPreco+=custo.Preco;
        }
        foreach (Livro total in livros){
            somaNumeroPaginas+=total.NumeroPaginas;
        }
        float mediaPaginas = somaNumeroPaginas/turma34DS.Length;        
        // Exibindo o resultado
        Console.WriteLine("A média da idade dos alunos da turma 34DS é: " 
+ mediaPaginas);      
    }}
