#include <iostream>
using namespace std;

int main()
{
    int n1, n2;
    
    cout << "Digite o primeiro número inteiro:" << "\n";
    cin >> n1;
    cout << "Digite o primeiro número inteiro:" << "\n";
    cin >> n2;
    
    if (n1 % n2 == 0 || n2 % n1 == 0){

        cout << "Os números " << n1 << " e " << n2 << " são multiplos.";
    }
    else{
        cout << "Os números " << n1 << " e " << n2 << " não são multiplos.";
    }

    system("pause")
    return 0;
}