using System;

namespace atividade_16
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Digite o valor de N: ");
          int N = int.Parse(Console.ReadLine());
          InverterNumero(N);
        }
        static void InverterNumero (int N)
        {
            if (N == 0)
                return ;
            else
                Console.Write(N % 10);
                InverterNumero(N / 10);    
        }
    }
}
