#include <iostream>
using namespace std;

int main (){
    int numeros[5] = {8, 3, 12, 7, 5};

    int maiorValor = numeros[0];
    int posicao = 0;

    int i = 1;

    while (i < 5) {
        if (numeros[i] > maiorValor) {
            maiorValor = numeros[i];
            posicao = i;
        }
        i++; // próximo número
    }

    cout << "O maior valor é: " << maiorValor << endl;
    cout << "Ele está na posição: " << posicao << endl;

    return 0;
}