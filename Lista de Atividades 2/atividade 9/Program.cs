using System;

namespace atividade_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] vetor = new double [5] {5, 8, 9, 2, 3};
            double B = 100;
            double Resultado = Menor (vetor, B);
            Console.WriteLine ($"O menor numero é: {Resultado}");
        }
        static double Menor (double [] vetor, double B)
        {
            for (int i = 0; i < 5; i++){
                if (vetor[i] < B){
                    B = vetor[i];
                }
            }
            return B;
           
        }
    }
}
