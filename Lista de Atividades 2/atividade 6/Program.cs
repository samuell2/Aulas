using System;

namespace atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int valor = int.Parse(Console.ReadLine());
            int Resultado = Fatorial(valor);
            Console.WriteLine($"Resultado: {Resultado}");
        }
        static int Fatorial (int valor)
        {
            int fatorial = 1;
            for (int i = valor ; i > 0; i--){
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
