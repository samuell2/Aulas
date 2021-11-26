using System;

namespace atividade_21
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = 0;
           double razao, primeirotermo, ultimotermo, termo = 0;

           Console.Write("Digite o primeiro termo: ");
           primeirotermo = double.Parse(Console.ReadLine());

           Console.Write("Digite a razao: ");
           razao = double.Parse(Console.ReadLine());

           Console.Write("Digite o ultimo termo ");
           ultimotermo = double.Parse(Console.ReadLine());

           while (termo < ultimotermo){
             termo = primeirotermo + n * razao;
             n++;
             Console.WriteLine($"{n}:  {termo}");
           }Console.ReadLine();
        }
    }
}
