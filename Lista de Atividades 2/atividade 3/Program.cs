using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrizA = new int [4, 3];
            int [,] matrizB = new int [3, 4];

            //matrizA
            Console.WriteLine("Digite os valores da matriz A: ");
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 2; j++){
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <= 3; i++){
                for (int j = 0; j <= 2; j++){
                    Console.Write($"{matrizA[i, j]} ");
                }Console.WriteLine();
            }
            //matrizB
            Console.WriteLine("Matriz B:");    
            for(int i = 0; i <= 2; i++){
                for (int j = 0; j <= 3; j++){
                    matrizB[i, j] = matrizA[j, i];
                }
            }
            for(int i = 0; i <= 2; i++){
                for (int j = 0; j <= 3; j++){
                    Console.Write($"{matrizB[i, j]} ");
                }Console.WriteLine();
            }
        }
    }
}
