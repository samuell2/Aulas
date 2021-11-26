using System;

namespace atividade_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial, numero, i, y;

            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            fatorial = numero;
            

            for (i = numero - 1; i >= 1; i--){
                 fatorial = fatorial * i;
                for (y = i; y >= 1; y--){
                 fatorial = fatorial * y;
            }                              
            }
            Console.WriteLine($"Superfatorial de {numero} é {fatorial} ");
            Console.ReadKey();
        }
    }
}
