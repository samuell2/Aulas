using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] dados = new int [5, 5];

            for (int i = 0; i <= 4; i++){
                for (int j = 0; i <= 4; i++){
                    if (i == j){
                        dados [i, j] = 1;
                    }else{
                        dados [i, j] = 0;   
                    }
                }
            }
        }
    }
}
