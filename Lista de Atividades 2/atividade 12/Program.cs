using System;

namespace atividade_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
            int [] B = new int [10];
            Console.WriteLine("Fatoriais de 1 a 10: ");
            int [] Resultado = obterValores(A, B);
            for (int i = 0; i <= 9; i++){
              Console.WriteLine($"{i + 1}: {Resultado[i]}");
            }
        }
        static int [] obterValores (int [] A, int [] B)
        {
            for (int i = 0; i < 10; i++){
                B[i] = A[i];
             for (int j = 0; j <= 10; j++){
                A[i] = A[i] - 1;
                if (A[i] > 0)
                B[i] = B[i] * A[i];
                else
                break;
             }    
           }return B;
        }
    }
}
