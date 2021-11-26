using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, md;
            int peso1, peso2, peso3;

            Console.Write("Digite a nota do 1 Bimestre: ");
            nota1 = double.Parse(Console.ReadLine());           
            peso1 = 2;
    
            Console.Write("Digite a nota do 2 Bimestre: ");
            nota2 = double.Parse(Console.ReadLine());
            peso2 = 3;
    
            Console.Write("Digite a nota do 3 Bimestre: ");
            nota3 = double.Parse(Console.ReadLine());
            peso3 = 5;
            md = (nota1*peso1 + nota2*peso2 + nota3*peso3)/(peso1+peso2+peso3);

            Console.WriteLine($"A sua media é: {md}");
    
            if(md >= 6.0){
                Console.WriteLine("Parabéns! Você foi aprovado!");
            }else if(md < 6.0 && md > 2.0){
                Console.WriteLine("Você está em recuperação!");
            }else{
                Console.WriteLine("Infelizmente voce foi reprovado.");
            }
            Console.ReadKey();
        }
    }
}                
        
    

