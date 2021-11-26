using System;

namespace atividade_27
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero, i, tabuada;

           Console.Write("Digite um número de 1 a 10: ");
           numero = int.Parse(Console.ReadLine());

           if (numero < 1 || numero > 10)
           {
               Console.Write("Não é um número entre 1 e 10.");
           }
           else
           {
               Console.WriteLine($"A tabuada de {numero} é: ");
               for (i = 0; i <= 10; i++){
                 tabuada = numero * i;
                 Console.WriteLine($"{numero} x {i} = {tabuada}");
               }
           }
           Console.ReadKey();
        }
    }
}
