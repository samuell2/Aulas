using System;

namespace atividade_18
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Digite a quantidade em gramas: ");
          double gramasinicial = int.Parse(Console.ReadLine());
          int tempo = 0;

          if (gramasinicial < 1 || gramasinicial > 1000){
              Console.WriteLine("Quantidade não permitida.");
          }else{
              while(gramasinicial > 1){
                tempo = tempo + 50;
                gramasinicial = gramasinicial * 0.5;
                Console.WriteLine($"Chegamos a {gramasinicial} g em {tempo} segundos");
              }Console.ReadLine();
          }
        }
    }
}
