#include <iostream>

using namespace std;

int main()
{
    int matriz[3][3];

    // i linha, j coluna

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            cout << "Digite o valor (numero inteiro) para a posição [" << i << "][" << j << "]: ";
            cin >> matriz[i][j];
        }
    }

    cout << "Matriz digitada:" << endl;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            cout << matriz[i][j] << " ";
        }
        cout << endl; // para deixar organizado, cada linha da matriz
    }

    int soma = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            soma += matriz[i][j];
        }
    }

    cout << "Soma dos elementos da matriz: " << soma << endl;
    return 0;
}