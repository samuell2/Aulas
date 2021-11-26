using System;

namespace atividade_11_pendente
{
    class Program
    {
        static void Main(string[] args)
        {
            double [,] matriz = new double [4, 4];
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 3; j++){
                    if (i == j)
                    matriz[i, j] = i + 1;
                    else
                     matriz[i, j] = j + 1;
                }
            }
            Console.WriteLine("Matriz: ");
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 3; j++){
                   Console.Write(matriz[i, j]);
                }Console.WriteLine();
            }
            double [,] S = new double [4, 4];
            double [,] Resultado = MatrizPar(matriz, S);
            Console.WriteLine("Matriz (apenas numeros pares): ");
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 3; j++){
                   Console.Write(Resultado[i, j]);
                }Console.WriteLine();
            }
        }

        static double [,] MatrizPar (double [,] matriz, double [,] S)
        {
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 3; j++){
                    if (matriz[i, j] % 2 == 0)
                    S[i, j] = matriz[i, j]; 
                }
            }return S;
            
        }
    }
}
