using System;

namespace atividade_30__resolver_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de carros vendidos: ");
            int carrosVendidos = int.Parse(Console.ReadLine());
            int [] valorCarros = new int [carrosVendidos];
            Console.Write("Digite o valor do salário: ");
            int salario = int.Parse(Console.ReadLine());
            double vlrTotal = 0;
            double somaTotal;

            for (int i = 0; i <= carrosVendidos - 1; i++){
                Console.Write($"Digite o valor do {i + 1}o carro vendido: ");
                valorCarros[i] = int.Parse(Console.ReadLine());
                vlrTotal = vlrTotal + valorCarros[i];
            }
            somaTotal = salario + (vlrTotal * 0.05);
            Console.WriteLine($"O valor total do salário é: {somaTotal}");
        }
    }
}
