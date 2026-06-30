#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> Numeros(5);

    cout << "Digite 5 números:" << endl;
    for (int i = 0; i < Numeros.size(); i++)
    {
        cout << "Insira o " << i + 1 << "° número:" << endl;
        cin >> Numeros[i];
    }

    int maiorValor = Numeros[0];
    int posicao = 0;

    int i = 1;

    while (i < 5)
    {
        if (Numeros[i] > maiorValor)
        {
            maiorValor = Numeros[i];
            posicao = i;
        }
        i++; // próximo número
    }

    cout << "O maior valor é: " << maiorValor << endl;
    cout << "Ele está na posição: " << posicao << endl;

    return 0;
}