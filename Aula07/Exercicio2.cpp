#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> Numeros(10);
    vector<int> Pares();

    for (int i = 0; i < Numeros.size(); i++)
    {
        cout << "Digite um número:" << endl;
        cin >> Numeros[i];
    }

    cout << "Números pares:";
    for (int p = 0; p < Numeros.size(); p++)
        if (Numeros[p] % 2 == 0)
            cout << Numeros[p] << " ";

    cout << "Números impares:";
    for (int i = 0; i < Numeros.size(); i++)
        if (Numeros[i] % 2 != 0)
            cout << Numeros[i] << " ";
}