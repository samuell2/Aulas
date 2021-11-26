using System;

namespace atividade_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor N: ");
            int N = int.Parse(Console.ReadLine());
            double Resultado = Calculo (N);
            Console.WriteLine($"Resutlado: {Resultado}");
        }
        static double Calculo (double N)
        {
            double S = 0;
            for (double i = 1; i <= N; i++){
              S = S + (1/i);               
            }return S;
        }
    }
}
