using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
          int x1, y1, x2, y2;
          double distancia;
            
            Console.Write("Digite o valor de x1: ");
            x1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de y1: ");
            y1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de x2: ");
            x2 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de y2: ");
            y2 = int.Parse(Console.ReadLine());
            
            distancia = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);
            Console.Write("A distancia é: ");
            Console.WriteLine(distancia); 
              
            Console.ReadKey();       
        }
    }
}
