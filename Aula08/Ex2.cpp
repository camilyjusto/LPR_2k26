#include <iostream>
using namespace std;

struct Produto
{
    string Nome;
    int Codigo;
    double Preco;
    int Quantidade;
};

Produto Produto1, Produto2, Produto3;

void inserir()
{

    cout << "Informações do primeiro produto:" << endl;
    cout << "Nome: ";
    cin >> Produto1.Nome;
    cout << "Código: ";
    cin >> Produto1.Codigo;
    cout << "Preço: ";
    cin >> Produto1.Preco;
    cout << "Quantidade: ";
    cin >> Produto1.Quantidade;

    cout << "Informações do segundo produto:" << endl;
    cout << "Nome: ";
    cin >> Produto2.Nome;
    cout << "Código: ";
    cin >> Produto2.Codigo;
    cout << "Preço: ";
    cin >> Produto2.Preco;
    cout << "Quantidade: ";
    cin >> Produto2.Quantidade;

    cout << "Informações do terceiro produto:" << endl;
    cout << "Nome: ";
    cin >> Produto3.Nome;
    cout << "Código: ";
    cin >> Produto3.Codigo;
    cout << "Preço: ";
    cin >> Produto3.Preco;
    cout << "Quantidade: ";
    cin >> Produto3.Quantidade;
}

void estoque()
{
    cout << "Produto 1 (" << Produto1.Nome << "): " << Produto1.Preco * Produto1.Quantidade << endl;
    cout << "Produto 2 (" << Produto2.Nome << "): " << Produto2.Preco * Produto2.Quantidade << endl;
    cout << "Produto 3 (" << Produto3.Nome << "): " << Produto3.Preco * Produto3.Quantidade << endl;

    int total;

    total = (Produto1.Preco * Produto1.Quantidade) + (Produto2.Preco * Produto2.Quantidade) + (Produto3.Preco * Produto3.Quantidade);
    cout << "Valor total:" << total << endl;
}

int main()
{
    cout << "Insira três produtos:" << endl;
    inserir();
    cout << "Produtos inseridos com sucesso!" << endl;

    cout << "Valor de produtos em estoque:" << endl;
    estoque();
}