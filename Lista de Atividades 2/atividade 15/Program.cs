using System;

namespace atividade_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado = Fibonacci(4);
            Console.WriteLine(Resultado);
        }
        static int Fibonacci (int N)
        {
            if (N == 0)
                return 0;
            else
                if (N == 1)
                    return 1;
                else
                    return (Fibonacci(N - 2) + Fibonacci(N - 1));    
        }
        
    }
}
