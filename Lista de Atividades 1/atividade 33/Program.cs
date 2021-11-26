using System;

namespace atividade_33
{
    class Program
    {
        static void Main(string[] args)
        {
           double [] A = new double [10];
           double [] B = new double [10];

           for (int i = 0; i <= 9; i++){
               Console.Write($"Digite o {i + 1}o valor de A: ");
               A[i] = int.Parse(Console.ReadLine());
           }
           for (int j = 0; j <= 9; j++){
               B[j] = A[j] - (A[j] * 2);
               Console.WriteLine($"{j + 1}o valor de B: {B[j]}");
           }
        }
    }
}
