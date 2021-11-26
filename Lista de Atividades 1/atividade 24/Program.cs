using System;

namespace atividade_24
{
    class Program
    {
        static void Main(string[] args)
        {
           

           Console.WriteLine("Digite o valor N: ");
           int N = int.Parse(Console.ReadLine());
           double H = 0;
          
           for (double I = 1; I <= N; I = I + 1)
           {    
               H = H + (1 / I);
           }
           Console.WriteLine(H);
           Console.ReadKey(); 
        }
    }
}
