using System;
using System.Globalization;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] matrizA = new int [3, 3];
           int [,] matrizB = new int [3, 3];
           double [,] produto = new double [3, 3];

           //matriz A
           Console.WriteLine("Digite os valores da matriz A: ");          
           for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz A: "); 
           for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                   Console.Write($"{matrizA[i, j]} ");
                }Console.WriteLine();
            }
            //matriz B
            Console.WriteLine("Digite os valores da matriz B: "); 
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz B: "); 
           for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                   Console.Write($"{matrizB[i, j]} ");
                }Console.WriteLine();
            }
            //produto
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                    produto[i, j] = matrizA[i, j] * matrizB[i, j];
                }
            }
            Console.WriteLine("Produto: ");
            for (int i = 0; i <= 2; i++){
                for (int j = 0; j <= 2; j++){
                   Console.Write($"{produto[i, j]} ");
                }Console.WriteLine();
            } 
        }
    }
}
