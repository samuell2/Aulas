using System;

namespace atividade_2_resolvida
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de B :");
            B = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            if (A > B && A > C) {
                Console.WriteLine("A é maior.");
            }
            else if (B > A && B> C) {
                Console.WriteLine("B é maior.");
            }
            else if (A == B && B == C){
                Console.WriteLine("Os números são iguais.");
            }
            else{
                Console.WriteLine("C é maior.");
            }

            if ((A + B + C) % 2 ==0){
                Console.WriteLine("A soma gera um número par.");
            }
            else{
                Console.WriteLine("A soma gera um número ímpar.");
            }
            Console.Read();

        }
    }
}
