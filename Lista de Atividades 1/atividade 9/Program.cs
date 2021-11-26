using System;

namespace atividade_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int fosfato, niobio, A;
            double titanio, ouro;                         
            
            Console.WriteLine("1 = fosfato");
            Console.WriteLine("2 = nióbio");
            Console.WriteLine("3 = titânio");
            Console.WriteLine("4 = ouro");
            Console.Write("Digite o código do minério: ");
            A = int.Parse(Console.ReadLine());
           
            if (A == 1){
                Console.Write("Digite a quantidade em gramas de fosfato: ");
                fosfato = int.Parse(Console.ReadLine());
                Console.Write("O resultado do calculo é: ");
                Console.Write((fosfato * 100) / 2);
            }else if (A == 2){
                Console.Write("Digite a quantidade em gramas de nióbio: ");
                niobio = int.Parse(Console.ReadLine());
                Console.Write("O resultado do calculo é: ");
                Console.Write((niobio + 100) / 3);
           }else if (A == 3) {
                Console.Write("Digite a quantidade em gramas de titânio: ");
                titanio = double.Parse(Console.ReadLine());
                Console.Write("O resultado do calculo é: ");
                Console.Write((titanio * 1.5) /5);
            }else if (A == 4){
                Console.Write("Digite a quantidade em gramas de ouro: ");
                ouro = double.Parse(Console.ReadLine());
                Console.Write("O resultado do calculo é: ");
                Console.Write((Math.Pow(ouro, 5)) /5);
            }else{
                Console.Write("Minério não cadastrado.");
            }Console.ReadKey();
        }
    }
}
