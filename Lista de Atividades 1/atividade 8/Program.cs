using System;

namespace atividade_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double preço, media;

            Console.Write("Informe o nome do produto: ");
            Console.ReadLine();

            Console.Write("Informe o preço do produto: ");
            preço = double.Parse(Console.ReadLine());

            Console.Write("Informe a média de vendas: ");
            media = double.Parse(Console.ReadLine());

            if (media < 500 && preço < 30){
                Console.Write("Terá um acrescimo de 10% de: ");
                Console.Write((preço*10) /100);
                Console.WriteLine(" reais");
                Console.Write("Valor total: ");
                Console.Write((preço*110) /100);
                Console.Write(" reais");

            }else if (media >=500 && media > 1200 && preço >= 30 && preço < 80){
                Console.Write("Terá um acrescimo de 15% de: ");
                Console.Write((preço*15) /100);
                Console.WriteLine(" reais");
                Console.Write("Valor total: ");
                Console.Write((preço*115) /100);
                Console.Write(" reais");

            }else if (media >= 1200 && preço >= 80){
                Console.Write("Terá um decrescimo de 20% de: ");
                Console.Write((preço*20) /100);
                Console.WriteLine(" reais");
                Console.Write("Valor total: ");
                Console.Write((preço*80) /100);
                Console.Write(" reais");

            }else{
                Console.Write("incalculável");
            }Console.ReadKey();
        }
    }
}
