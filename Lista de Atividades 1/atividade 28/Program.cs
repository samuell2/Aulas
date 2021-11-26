using System;

namespace atividade_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            int fatorial = N;
            int divisao;
            int dobro = N * 2;
            int fatorialDobro = dobro;

            for (int i = N - 1; i >= 1; i--){
                fatorial = fatorial * i;
            }
            for (int j = dobro - 1; j >= 1; j--){
                fatorialDobro = fatorialDobro * j;
            }
            divisao = fatorialDobro / fatorial;
            Console.WriteLine($"O quadruplo fatorial de {N} é: {divisao}");
            Console.ReadKey();
        }
    }
}
