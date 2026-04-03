#include <locale>
#include <iostream>

using namespace std;

int main(){
 
   int Soma = 0;
   
   for (int i = 51; i <= 500; i += 3){
        if (i % 2 == 1){
           Soma += i;
       }
       else {
       }
   }
   cout << "A soma dos múltiplos de 3 entre 50 e 500 é: " << Soma;
}