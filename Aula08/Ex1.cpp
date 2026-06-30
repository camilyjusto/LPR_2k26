#include <iostream>
using namespace std;
// Declaração da Struct
struct Filme
{
    string Titulo;
    string Diretor;
    int Anolancamento;
    int Duracaominutos;
};

Filme filmes[3];

void adicionarfilme()
{
    cout << "Informações do primeiro filme:" << endl;
    cout << "Digite o título do filme: ";
    cin >> Filme1.Titulo;
    cout << "Digite o nome do diretor: ";
    cin >> Filme1.Diretor;
    cout << "Digite o ano de lançamento: ";
    cin >> Filme1.Anolancamento;
    cout << "Digite a duração em minutos: ";
    cin >> Filme1.Duracaominutos;

    cout << "Informações do segundo filme:" << endl;
    cout << "Digite o título do filme: ";
    cin >> Filme2.Titulo;
    cout << "Digite o nome do diretor: ";
    cin >> Filme2.Diretor;
    cout << "Digite o ano de lançamento: ";
    cin >> Filme2.Anolancamento;
    cout << "Digite a duração em minutos: ";
    cin >> Filme2.Duracaominutos;

    cout << "Informações do terceiro filme:" << endl;
    cout << "Digite o título do filme: ";
    cin >> Filme3.Titulo;
    cout << "Digite o nome do diretor: ";
    cin >> Filme3.Diretor;
    cout << "Digite o ano de lançamento: ";
    cin >> Filme3.Anolancamento;
    cout << "Digite a duração em minutos: ";
    cin >> Filme3.Duracaominutos;

}
int main()
{
    int opcao;

    cout << "Análise de filmes:" << endl;
    cout << "Digite 1 para adicionar filmes" << endl;
    cout << "Digite 2 para visualizar os filmes" << endl;
    cout << "Digite 3 para sair" << endl;
    cin << opcao;
        
    if (opcao == 1)
    {
        adicionarfilme();
    }
    else if (opcao == 2)
    {
        cout << "Filme 1:" << endl;
        cout << "Título: " << Filme1.Titulo << endl;
        cout << "Diretor: " << Filme1.Diretor << endl;
        cout << "Ano de lançamento: " << Filme1.Anolancamento << endl;
        cout << "Duração em minutos: " << Filme1.Duracaominutos << endl;

        cout << "Filme 2:" << endl;
        cout << "Título: " << Filme2.Titulo << endl;
        cout << "Diretor: " << Filme2.Diretor << endl;
        cout << "Ano de lançamento: " << Filme2.Anolancamento << endl;
        cout << "Duração em minutos: " << Filme2.Duracaominutos << endl;

        cout << "Filme 3:" << endl;
        cout << "Título: " << Filme3.Titulo << endl;
        cout << "Diretor: " << Filme3.Diretor << endl;
        cout << "Ano de lançamento: " << Filme3.Anolancamento << endl;
        cout << "Duração em minutos: " << Filme3.Duracaominutos << endl;
        
    }
    else if (opcao == 3)
    {
        cout <<"Saindo do programa..."<<endl;
    }
}