using System;

namespace atividade_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses = 0;
            double parcelas = 700;
            double valorano = 0;
            double valorfinal = 0;
            int ano = 0;

            Console.WriteLine("Cosiderando uma primeira parcela de 700 reais, o valor anual será: ");

            while (meses < 240){
                meses++;
                valorfinal = parcelas * Math.Pow((1 + 0.85 / 100), meses);
                
                if (meses % 12 == 0){
                    ano++;
                    valorano = valorano + valorfinal;
                    Console.WriteLine($"Valor no ano {ano}: {valorano.ToString("F")} reais.");
                }
            }Console.WriteLine($"O valor total final será: {valorfinal.ToString("F")} reais.");
            Console.ReadLine();
        }
    }
}
