#include <iostream>

using namespace std;

int main(){
    int matriz[4][4] = { {0,524,521,882}, {524,0,434,586}, {521,434,0,429}, {882,586,429,0} };
    int o = -2, d = -1;
    
    while(o != d){
    cout << "Digite o número correspondente à cidade:" << endl;
    cout << "1. Vitoria" << endl;
    cout << "2. Belo Horizonte" << endl;
    cout << "3. São Paulo" << endl;
    cout << "4. Brasília" << endl;
    cout << "Qual a cidade de origem?" << endl;
    cin >> o;
    cout << "Qual a cidade de destino?" << endl;
    cin >> d;

    cout << "A distância entre as cidades é: " << matriz[o-1][d-1] << endl;
    }

    cout << "A cidade de origem e o destino são iguais!" << endl;
    return 0;
}