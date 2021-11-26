using System;

namespace atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Reta 1: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Reta 2: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Reta 3: ");
            C = int.Parse(Console.ReadLine());

            if (A == B && B == C){
                Console.Write("Triangulo equilátero.");
            }else if (A != B && B != C && A != C){
                Console.Write("Triangulo escaleno.");
            }else{
                Console.Write("Trigando isoceles.");
            }

            Console.ReadLine();

        }
    }
}
