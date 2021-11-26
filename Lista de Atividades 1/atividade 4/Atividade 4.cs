using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
          int A, B, C;
          Console.Write("Minutos utilizados para realizar a prova:");
          A = int.Parse(Console.ReadLine());

          B = A / 60;
          C = A % 60;

          Console.WriteLine("Equivalem a:");
        
          Console.Write(B);
          Console.Write(" horas "); 

          Console.Write("e ");
          
          Console.Write(C);
          Console.Write(" minutos");
                                
          Console.ReadLine();
        }
    }
}
