using System;

namespace atividade_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplos = 0;
            int quantidade = 0;

            while (quantidade < 5){
                multiplos++;
                 if (multiplos % 3 == 0){
                    Console.WriteLine(multiplos);
                    quantidade++;
                 }
            }Console.ReadLine();
        }
    }
}
