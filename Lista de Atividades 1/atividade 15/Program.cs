using System;

namespace atividade_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int T1, T2, T3, T4, CT;

            Console.WriteLine("Digite abaixo a quantidade de tomadas em cada régua.");
            Console.Write("Quantidade na primeira régua: ");
            T1 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade na segunda régua: ");
            T2 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade na terceira régua: ");
            T3 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade na quarta régua: ");
            T4 = int.Parse(Console.ReadLine());

            if (T1 < 2 || T1 > 6){
                Console.WriteLine("Número de tomadas na primeira régua inválido.");    
            }else if (T2 < 2 || T2 > 6){
                Console.WriteLine("Número de tomadas na segunda régua inválido.");                 
            }else if (T3 < 2 || T3 > 6){
                Console.WriteLine("Número de tomadas na terceira régua inválido.");
            }else if (T4 < 2 || T4 > 6){
                Console.WriteLine("Número de tomadas na quarta régua inválido."); 
            }else{             
               CT = (T1 - 1) + (T2 - 1) + (T3 - 1) + T4;
               Console.WriteLine($"É possível conectar os aparelhos em até {CT} tomadas."); 
            } 
            Console.ReadKey();      
        }
    }
}