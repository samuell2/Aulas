using System;

namespace atividade_13
{
    class Program
    {
        static void Main(string[] args)
        { 
            int [] vetor = new int [10];
            int primo = 0, indice = 0, cont = 101; 
            int [] Resultado = Primos(vetor, primo, indice, cont);
            for (int i = 0; i < 10; i++){
                Console.WriteLine(Resultado[i]);
            }
        }
        static int [] Primos (int [] vetor, int primo, int indice, int cont)
        {
            for (int i = 100; i < cont; i++){
                primo = i;
                if (indice == 10){
                } else {
                    for ( ; primo > 0; primo--){
                        if (i % primo == 0 && i != primo || i == 1){
                            cont++;
                            break;
                        }else if (primo == 2){
                            vetor[indice] = i;
                            indice++;
                            cont++;
                            break;
                        }
                    }
                }
            } return vetor;
        }    
    }
}
