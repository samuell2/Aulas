using System;

namespace atividade_10
{
    class Program
    {
        static void Main(string[] args)
        {           
           double A, V, T, L, D;

           Console.Write("Digite a velocidade em Km/h: ");
           V = double.Parse(Console.ReadLine());
           Console.Write("Digite a altura em Km: ");
           A = double.Parse(Console.ReadLine());

           T = 36 / 3600;
           // transformando segundos em horas //
           L = V * T;
           D = Math.Sqrt(Math.Pow(L, 2) + Math.Pow(A, 2));

           Console.WriteLine($"A distância entre o ponto P e o avião é de {D} km.");
           Console.ReadKey();

        }
    }
}
