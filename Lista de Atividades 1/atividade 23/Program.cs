using System;

namespace atividade_23
{
    class Program
    {
        static void Main(string[] args)
        {
           double cidadea;
           double cidadeb;
           double porcentagema;
           double porcentagemb;
           int anos = 0;

           Console.Write("Digite a população da ciadade A: ");
           cidadea = double.Parse(Console.ReadLine());

           Console.Write("Digite a população da ciadade B: ");
           cidadeb = double.Parse(Console.ReadLine());

           Console.Write("Digite a porcentagem de crescimento da ciadade A: ");
           porcentagema = double.Parse(Console.ReadLine() + 100) / 100;

           Console.Write("Digite a porcentagem de crescimento da ciadade B: ");
           porcentagemb = double.Parse(Console.ReadLine() + 100) / 100;

           
           while(cidadea <= cidadeb){
               cidadea = cidadea * porcentagema;
               cidadeb = cidadeb * porcentagemb;
               anos++;
           }
           Console.WriteLine($"Anos: {anos}");
           Console.ReadLine();
        }
    }
}
