using System;

namespace atividade_14
{
    class Program
    {
        static void Main(string[] args)
        {
           int A, B, C;

           Console.WriteLine("O último ano em que o cometa Hallen passou pela terra foi em 1986. Descubra quando iremos vê-lo novamento.");
           Console.Write("Digite o ano atual em que estamos: ");
           A = int.Parse(Console.ReadLine());

           if (2010 <= A && A <= 10040){
               B = (A - 1986) / 76;
               C = 1986 + (76 * (B + 1));
               Console.Write($"O cometa passará novamente em {C}");
           }else{
               Console.Write("Ja calculado.");
           }

            Console.ReadKey();
           
        }
    }
}
