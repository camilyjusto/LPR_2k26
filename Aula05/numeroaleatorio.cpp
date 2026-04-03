#include <iostream>
#include <random>
#include <locale>
using namespace std;

int main (){
    int contador = 0;
    int chute = 0;
    
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    cout << "Adivinhe o número inteiro de 1 a 100" << endl;

    do{
        contador++;
        cout << "Digite o seu chute:" << endl;
        cin >> chute;
        if ( chute > valorInteiro){
            cout << "Chutou alto!" << endl;
        }
        else if ( chute > valorInteiro){
            cout << "Chutou baixo!" << endl;
        }
        else {
            cout << "Você acertou! Seu número de tentativas foi: " << contador << endl;
            return 0;
        }
    }while(chute != valorInteiro);
}