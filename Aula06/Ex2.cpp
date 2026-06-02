#include <iostream>
#include <string>
using namespace std;

int media(){
            cout << "Informe quantos números você irá digitar: " << endl;
            cin >> quantidade;

            int contador = 0;
            int NN = 0; // Número novo
            int SA = 0; // Soma dos números anteriores

            while (contador <= quantidade - 1)
            {
                cout << "Digite o número: " << endl;
                cin >> num;
                if (num % 2 == 0)
                {
                    num = NN;
                }
                else {
                    NN = num + 1;
                }
                int soma = SA + NN;
                SA = soma;
                contador++;
            }
            int mediaaritmetica = SA / quantidade;
            cout << "A média aritmética desses números é:" << mediaaritmetica << endl;
}

int multiplos(){
    int Soma = 0;
   
    for (int i = 51; i <= 500; i += 3){
        if (i % 2 == 1){
            Soma += i;
        }
        else {
        }
   }
   cout << "A soma dos múltiplos de 3 entre 50 e 500 é: " << Soma << endl;
}

int soma(){
    Console.WriteLine("Digite um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            int quadrado = num * num;
            int soma = 0;

            while (quadrado > 0)
            {
                int digito = quadrado % 10;
                soma += digito;
                quadrado /= 10;
            }
            Console.WriteLine($"A soma dos dígitos do quadrado de {num} é: {soma} ");
            cout << "A soma dos dígitos do quadrado de " << num << "é: " << soma << endl;
}

int main()
{
    cout << "Escolha uma opção: " << endl;
    cout << "1. Média aritmética." << endl;
    cout << "2. Múltiplos de 3 entre 50 e 500." << endl;
    cout << "3. Soma dos dígitos do quadrado de um número." << endl;
    cin >> resposta;

    if (reposta == 1){
        media();
    }
    else if (resposta == 2){
        multiplo();
    }
    else if (resposta == 3){
        soma();
    }
    else {
        cout << "Opção inválida." << endl;
    }
}
