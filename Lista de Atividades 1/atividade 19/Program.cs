using System;

namespace atividade_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, n, numeros;
            
            soma = 0;
            
            for (n = 1; n <= 10; n++){
                Console.Write("Digite o numero: ");
                numeros = int.Parse(Console.ReadLine());
                soma = soma + numeros;

            }
            Console.WriteLine($"A soma dos números é: {soma}");
        } 
    }
}
