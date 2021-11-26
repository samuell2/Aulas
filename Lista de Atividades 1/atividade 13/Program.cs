using System;

namespace atividade_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D, XD, X1, X2;

            Console.WriteLine("Equação: ax² + bx + c = 0");
            Console.WriteLine("Digite os valores de a, b, e c abaixo.");
            Console.Write("A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("C: ");
            C = double.Parse(Console.ReadLine());

            if (A == 0){
                Console.Write("Não é equação de segundo grau.");
            }else{
                D = Math.Pow(B, 2) - 4 * A * C;
                Console.WriteLine($"O valor de delta é: {D}");
                if (D < 0){
                    Console.WriteLine("Não existe raiz.");
                }else if (D == 0){
                   XD = -B / (2*A);
                   Console.WriteLine($"A raiz é igual a: {XD}");
                   Console.WriteLine($"Raiz única.");     
                }else{
                    X1 = (-B + Math.Sqrt(D)) / (2 * A);
                    Console.WriteLine($"Raíz X1 = {X1}");
                    X2 = (-B - Math.Sqrt(D)) / (2 * A);
                    Console.WriteLine($"Raíz X2 = {X2}");
                }Console.ReadKey();  
            }

                      
        }
    }
}
