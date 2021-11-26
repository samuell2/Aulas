using System;

namespace atividade_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de K: ");
            int K = int.Parse(Console.ReadLine());
            int i = 0;
            sumMatches(N, K, i);
        }
        static void sumMatches(int N, int K, int i) 
        {
	        
            if(N % 10 == K){
		    i++;
            }
            else if (N % 10 == 0){
                return ;
            }	        
	        if(N % 10 == N){
		        Console.Write($"O valor {K} aparece {i} vez(es)");
	            }
	        sumMatches(N / 10, K, i);
        }
    }
}
