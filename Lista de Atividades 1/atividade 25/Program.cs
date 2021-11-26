using System;

namespace atividade_25
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Digite um valor N: ");
           int N = int.Parse(Console.ReadLine());
           int [] numeros = new int [N];
           double maior = double.MinValue;

           for (int i = 0; i <= N - 1; i++)
           {
               Console.Write($"Digite o {i + 1}° numero inteiro: ");
               numeros[i] = int.Parse(Console.ReadLine());

               if (numeros[i] < 0)
               {
                  Console.WriteLine("Não é um número positivo.");
                  break;
               }
               if (numeros[i] > maior){
                   maior = numeros[i];
                } 
           }              
           Console.WriteLine($"O maior número é: {maior}");
           Console.ReadKey();           
        }
    }
}
