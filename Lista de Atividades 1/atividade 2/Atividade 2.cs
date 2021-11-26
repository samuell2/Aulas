using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
           int A, B, C;
           double D, R, S;

           Console.Write("Digite A: ");
           A = int.Parse(Console.ReadLine());

           Console.Write("Digite B: ");
           B = int.Parse(Console.ReadLine());

           Console.Write("Digite C: ");
           C = int.Parse(Console.ReadLine());
          
           R = Math.Pow((A + B), 2);
           Console.WriteLine($"O valor de R = (A + B)² é: {R}");

           S = Math.Pow((B + C), 2);
           Console.WriteLine($"O valor de S = (B + C)² é: {S}");

           D = (R + S)/2;
           Console.Write($"O valor de D = (R + S)/2 é: {D}");
          
           Console.ReadKey();
        
        }
    }
}
