using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz
            int [,] matriz = new int [3, 3];
            Console.WriteLine("Digite os valores da matriz: ");
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    Console.Write($"{matriz[i, j]} ");
                }Console.WriteLine();
            }
            //multiplicação por K
            Console.Write("Digite o valor de K: ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("A matriz multiplicada por K: ");
            int [,] matrizK = new int [3, 3];
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    matrizK[i, j] = matriz[i, j] * K;
                }
            }
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    Console.Write($"{matrizK[i, j]} ");
                }Console.WriteLine();
            }
        }
    }
}
