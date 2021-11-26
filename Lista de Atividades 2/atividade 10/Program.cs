using System;

namespace atividade_10_pendente
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = -1;
            double B = 100;
            double D = 0;
            double [] vetor = new double [5] {8, 9, 3, 6, 2};
            double soma = MenorMaior (vetor, A, B, D);
            Console.WriteLine ($"A soma entre o maior numero e o menor é: {soma}");
        }
        static double MenorMaior (double [] vetor, double A, double B, double D)
        {
            for (int i = 0; i < 5; i++){
                if (vetor[i] > A){
                    A = vetor[i];
                }

                if (vetor[i] < B){
                    B = vetor[i];
                }
            }
            D = A + B;
            return D;
        }
    }
}
