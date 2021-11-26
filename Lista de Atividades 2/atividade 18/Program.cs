using System;

namespace atividade_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome e  sobrenome: ");
            string nome = Console.ReadLine();
            int primeiroNome = nome.IndexOf(" ");
            string escrever = nome.Substring(0, primeiroNome);
            Console.Write($"O primeiro nome é {escrever}");
        }
    }
}
