using System;

namespace atividade_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, G, C, D, E, F;
            string B;
           
            Console.Write("Digite o tipo de combustível (A) alcool ou (G) gasolina: ");
            B = Console.ReadLine();

            if (B == "A"){
                Console.Write("Digite a quantidade em litros de alcool: ");
                A = double.Parse(Console.ReadLine());

                if (A <= 20 && A > 0){
                    C = ((A * 0.47) * 97) / 100;
                    Console.Write($"O valor com desconto de 3% é: {C}");
                }else if (A > 20){
                    D = ((A * 0.47) * 95) / 100;
                    Console.Write($"O valor com desconto de 5% é: {D}");
                }else{
                    Console.Write("Sem desconto.");
                }

            }else if(B == "G"){
                Console.Write("Digite a quantidade em litros de gasolina: ");
                G = double.Parse(Console.ReadLine());

                if (G <= 15 && G > 0){
                   E = ((G * 0.53) * 96.5) / 100;
                    Console.Write($"O valor com desconto de 3.5% é: {E}");
                }else if (G > 20){
                    F = ((G * 0.53) * 94) / 100;
                    Console.Write($"O valor com desconto de 6% é: {F}");
                }else{
                    Console.Write("Sem desconto.");
                }
            }else{
                Console.Write("Combustível não cadastrado");
            }

            Console.ReadKey();
        }
    }
}
