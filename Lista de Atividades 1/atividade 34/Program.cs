using System;

namespace atividade_34
{
    class Program
    {
        static void Main(string[] args)
        {
           double [] A = new double [10];
           double [] B = new double [10];

           for (int i = 0; i <= 9; i++){
               Console.Write($"Digite o valor do {i + 1}o numero A: ");
               A[i] = int.Parse(Console.ReadLine());                             
           }
           for (int j = 0; j <= 9; j++){
               B[j] = (A[j] + 9 - (A[j] * 2)) + A[j] + (((A[j] + 9 - (A[j] * 2)) + A[j]) * 0.1);
               Console.WriteLine($"B[{j}] = A[{j + 9 - (j * 2)}] + A[{j}] + 10% = {B[j]}");
           }           
        }
    }
}
