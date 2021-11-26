using System;

namespace atividade_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int [] B = new int [10] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            double [] C = new double [20];
            int o = 10;
            double aux = 0;
            double [] Resultado = VetorC (A, B, C, o, aux);
            for (int j = 0; j <= 19; j++){
                Console.WriteLine(Resultado[j]);
            }
        }
        static double [] VetorC (int [] A, int [] B, double [] C, int o, double aux)
        {
            for (int i = 0; i <= 9; i++){
                C[i] = A[i];
            }
            while (o < 19){
                for (int l = 0; l <= 9; l++){
                    C[o] = B[l];
                    o++;
                }
            }
            for(int i = 0; i < 20; i++){
                  for(int j = i + 1; j < 20; j++){
                       if(C[i] < C[j]){
                           aux = C[i];
                           C[i] = C[j];
                           C[j] = aux;
                       }
                  }
           }
            
            return C;
        }
    }
}
