using System;

namespace atividade_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome e sobrenome: ");
            string nome = Console.ReadLine();
            for (int i = 0; i < nome.Length; i++){
                if (nome[i] == ' '){
                    nome = nome.Substring(i, i + 1).ToUpper(); 
                }
            }Console.Write(nome);
        }
    }
}
