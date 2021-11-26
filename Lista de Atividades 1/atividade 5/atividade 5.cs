using System;

namespace atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.Write("Digite o valor: ");
            A = int.Parse(Console.ReadLine());

            if (A % 2 == 0){
                Console.WriteLine("Par");
            }else{
                Console.WriteLine("Impar");
            }

            Console.ReadKey();
        }
    }
}
