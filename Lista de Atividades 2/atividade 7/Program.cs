using System;

namespace atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
                Console.Write("Digite o valor de x1: ");
                x1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y1: ");
                y1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de x2: ");
                x2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y2: ");
                y2 = double.Parse(Console.ReadLine());
                double Resultado = Distancia (x1, y1, x2, y2);
                Console.WriteLine($"Resultado: {Resultado}");
        }
        static double Distancia(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);
            return distancia;
        }
    }
}
