using System;

namespace atividade_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, M, AH, AM;
            string B;

            Console.Write("Você é homem (H) ou mulher (M)? ");
            B = Console.ReadLine();

            if (B == "H"){
                Console.Write("Digite sua altura: ");
                AH = double.Parse(Console.ReadLine());
                H = (72.7 * AH) - 58;
                Console.Write($"Seu peso ideal é: {H} kilos.");

            }else if (B == "M"){
                Console.Write("Digite sua altura: ");
                AM = double.Parse(Console.ReadLine());
                M = (62.1 * AM) - 44.7; 
                Console.Write($"Seu peso ideal é: {M} kilos.");
            }else{
                Console.Write("Código não cadastrado.");
            }

            Console.ReadKey();
        }
    }
}
