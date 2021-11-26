using System;

namespace atividade_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "natan";
            int digitos = nome.Length;
            bool resultado = true;
            for (int i = 1, j = digitos - 1; i < j; i++, j--){
                if (nome[i] == nome[j]){
                    resultado = true;
                }else{
                    resultado = false;
                    break;
                }
                
            }if (resultado == true){
                Console.Write("É um polindromo");
            }else{
                Console.Write("Não é um polindromo");
            }
            
        }
    }
}
