using System;

namespace atividade_32
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] dados = new int [9] {10, 20, 30, 40, 50, 60, 70, 80, 90};
           int i;
           string Encontrou = "NAO";
           Console.Write("Digite um numero: ");
           int variavel = int.Parse(Console.ReadLine());
           
           for(i = 0; i <= 8; i = i + 1){
               if(variavel == dados[i]){
                   Encontrou = "SIM";
                   break;
               }
           }
           Console.WriteLine(Encontrou);
           Console.ReadKey();
        }
    }
}
