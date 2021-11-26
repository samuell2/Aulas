using System;

namespace atividade_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, n, numeros, divisao;
            
            soma = 0;
            
            for (n = 1; n <= 10; n++){
                Console.Write("Digite o numero: ");
                numeros = int.Parse(Console.ReadLine());
                soma = soma + numeros;

            }
            divisao = soma / 10;
            Console.WriteLine($"A soma dos numeros é: {soma}");
            Console.WriteLine($"A média dos números é: {divisao}");
       }
    }
}
