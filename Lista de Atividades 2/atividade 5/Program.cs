using System;

namespace atividade_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int valor = int.Parse(Console.ReadLine());
            Analise(valor);
        }
        static void Analise(int valor)
        {
            if (valor % 2 == 0){
                Console.WriteLine("Par.");
            }else{
                Console.WriteLine("Impar.");
            }
        }
    }
}
