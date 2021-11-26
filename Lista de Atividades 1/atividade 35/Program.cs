using System;

namespace atividade_35
{
    class Program
    {
        static void Main(string[] args)
        {
           double [] A = new double [4];
           double [] B = new double [4];
           
           for (int i = 0; i <= 3; i++){
               Console.Write($"Digite a temperatura em Celsius do {i + 1}º dia: ");
               A[i] = double.Parse(Console.ReadLine());
               B[i] = 32 + (9 / 5 * (A[i]));
               Console.WriteLine($"A temperatura em Fahrenheit é: {B[i]}º F.");                                 
            }
        }
    }
}
