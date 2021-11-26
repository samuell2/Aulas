using System;

namespace atividade_26
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("A altura de cada degrau em milimetros é: ");
           int x = int.Parse(Console.ReadLine());
           Console.Write("O número de degraus é: ");
           int i = int.Parse(Console.ReadLine());
           double soma = 0;
           int n;
           double transformar;

           for (n = 1; n <= i; n = n + 1)
           {
               soma = n * x;
               Console.WriteLine($"A altura no {n}° degrau é: {soma / 1000} metros.");
           }
           transformar = soma / 1000;
           Console.WriteLine($"A altura total é de: {transformar} metros.");
           Console.ReadKey();
        }
    }
}
